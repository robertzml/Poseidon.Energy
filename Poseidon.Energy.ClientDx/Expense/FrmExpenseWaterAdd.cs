using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 添加水费支出窗体
    /// </summary>
    public partial class FrmExpenseWaterAdd : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联支出账户
        /// </summary>
        private ExpenseAccount currentAccount;
        #endregion //Field

        #region Constructor
        public FrmExpenseWaterAdd(string accountId)
        {
            InitializeComponent();

            InitData(accountId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentAccount = BusinessFactory<ExpenseAccountBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.txtAccountName.Text = this.currentAccount.Name;
            this.dpTicketDate.DateTime = DateTime.Now;
            ControlUtil.BindDictToComboBox(this.cmbFeeType, typeof(WaterExpense), "FeeType");

            InitRecords();

            var last = BusinessFactory<WaterExpenseBusiness>.Instance.FindLast(this.currentAccount.Id);
            if (last != null)
            {
                this.txtPreviousDate.Text = last.BelongDate.ToString("yyyy年MM月");
                this.previousGrid.DataSource = last.Records;
            }

            base.InitForm();
        }

        /// <summary>
        /// 初始化支出记录，关联水表
        /// </summary>
        private void InitRecords()
        {
            List<WaterExpenseRecord> records = new List<WaterExpenseRecord>();

            foreach (var item in this.currentAccount.WaterMeters)
            {
                WaterExpenseRecord record = new WaterExpenseRecord();
                record.MeterNumber = item.Number;
                record.MeterName = item.Name;

                records.Add(record);
            }

            this.expenseGrid.DataSource = records;
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(WaterExpense entity)
        {
            entity.AccountId = this.currentAccount.Id;
            entity.BelongDate = this.dpBelongDate.DateTime.Date;
            entity.TicketDate = this.dpTicketDate.DateTime.Date;
            entity.FeeType = Convert.ToInt32(this.cmbFeeType.EditValue);
            entity.TotalQuantity = this.spTotalQuantity.Value;
            entity.TotalAmount = this.spTotalAmount.Value;
            entity.Remark = this.txtRemark.Text;

            entity.Records = this.expenseGrid.DataSource;
            foreach (var item in entity.Records)
            {
                item.MeterNumber = item.MeterNumber ?? "";
                item.MeterName = item.MeterName ?? "";
                item.Remark = item.Remark ?? "";
            }
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (this.dpBelongDate.EditValue == null)
            {
                errorMessage = "归属日期不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.cmbFeeType.SelectedIndex == -1)
            {
                errorMessage = "请选择费用类型";
                return new Tuple<bool, string>(false, errorMessage);
            }

            foreach (var item in this.expenseGrid.DataSource)
            {
                if (string.IsNullOrEmpty(item.MeterName))
                {
                    errorMessage = "水表名称不能为空";
                    return new Tuple<bool, string>(false, errorMessage);
                }
            }

            return new Tuple<bool, string>(true, "");
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSum_Click(object sender, EventArgs e)
        {
            this.expenseGrid.CloseEditor();

            decimal totalQuantity = 0;
            decimal totalAmount = 0;
            foreach (var item in this.expenseGrid.DataSource)
            {
                totalQuantity += item.Quantity;
                totalAmount += item.Amount;
            }

            this.spTotalQuantity.Value = totalQuantity;
            this.spTotalAmount.Value = totalAmount;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.expenseGrid.CloseEditor();

            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            WaterExpense entity = new WaterExpense();
            SetEntity(entity);

            try
            {
                BusinessFactory<WaterExpenseBusiness>.Instance.Create(entity, this.currentUser);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
