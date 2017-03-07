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
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 支出总览窗体
    /// </summary>
    public partial class FrmExpenseOverview : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前选择账户
        /// </summary>
        private ExpenseAccount currentAccount;

        /// <summary>
        /// 今年
        /// </summary>
        private int nowYear;
        #endregion //Field

        #region Constructor
        public FrmExpenseOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.nowYear = DateTime.Now.Year;
            this.lbWaterRecords.DrawItem += EventUtil.lbMonth_DrawItem;
            base.InitForm();
        }

        /// <summary>
        /// 载入账户基本信息
        /// </summary>
        private void LoadBaseInfo()
        {
            this.txtName.Text = this.currentAccount.Name.ToString();
            this.txtShortName.Text = this.currentAccount.ShortName.ToString();

            if (this.currentAccount.EnergyType.Contains(1))
                this.chkType1.Checked = true;
            if (this.currentAccount.EnergyType.Contains(2))
            {
                this.chkType2.Checked = true;
                LoadWater();
            }
            if (this.currentAccount.EnergyType.Contains(3))
                this.chkType3.Checked = true;
            if (this.currentAccount.EnergyType.Contains(4))
                this.chkType4.Checked = true;
        }

        /// <summary>
        /// 载入水费相关数据
        /// </summary>
        private void LoadWater()
        {
            this.tabPageWaterMeter.PageVisible = true;
            this.waterMeterGrid.DataSource = this.currentAccount.WaterMeters;

            this.tabPageWaterExpense.PageVisible = true;
            this.waterYearGrid1.DataSource = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(this.currentAccount.Id, nowYear).ToList();
            this.waterYearGrid2.DataSource = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(this.currentAccount.Id, nowYear - 1).ToList();

            for (int i = 2010; i <= nowYear; i++)
                this.cmbWaterExpenseYear.Properties.Items.Add(i.ToString() + "年");

            var expense = BusinessFactory<WaterExpenseBusiness>.Instance.FindByAccount(this.currentAccount.Id);
            this.tabPageWaterRecord.PageVisible = true;
            this.bsWaterExpense.DataSource = expense.OrderByDescending(r => r.BelongDate);
        }

        /// <summary>
        /// 显示水费支出信息
        /// </summary>
        /// <param name="entity">水费支出</param>
        private void ShowWaterExpense(WaterExpense entity)
        {
            this.txtWaterBelongDate.Text = entity.BelongDate.ToString("yyyy年MM月");
            this.txtWaterTicketDate.Text = entity.TicketDate.ToDateString();
            this.txtWaterFeeType.Text = entity.FeeType.ToString();
            this.txtWaterTotalQuantity.Text = entity.TotalQuantity.ToString();
            this.txtWaterTotalAmount.Text = entity.TotalAmount.ToString();

            this.waterExpRecGrid.DataSource = entity.Records;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 账户选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accountTree_AccountSelected(object sender, EventArgs e)
        {
            string id = this.accountTree.GetCurrentSelectAccountId();
            if (id == null)
                this.currentAccount = null;
            else
            {
                this.currentAccount = BusinessFactory<ExpenseAccountBusiness>.Instance.FindById(id);
                LoadBaseInfo();
            }
        }

        /// <summary>
        /// 登记水费
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddWater_Click(object sender, EventArgs e)
        {
            if (this.currentAccount == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmExpenseWaterAdd), new object[] { this.currentAccount.Id });
            LoadWater();
        }

        /// <summary>
        /// 选择水费年份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbWaterExpenseYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(this.cmbWaterExpenseYear.SelectedText.Substring(0, 4));
        }

        /// <summary>
        /// 选择水费支出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbWaterRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbWaterRecords.SelectedValue == null)
                return;

            ShowWaterExpense(this.lbWaterRecords.SelectedItem as WaterExpense);
        }

        /// <summary>
        /// 编辑水费支出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditWaterExpense_Click(object sender, EventArgs e)
        {
            if (this.currentAccount == null || this.lbWaterRecords.SelectedValue == null)
                return;

            var expense = this.lbWaterRecords.SelectedItem as WaterExpense;
            ChildFormManage.ShowDialogForm(typeof(FrmExpenseWaterEdit), new object[] { expense.Id, this.currentAccount.Id });
            LoadWater();
        }

        /// <summary>
        /// 删除水费支出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteWaterExpense_Click(object sender, EventArgs e)
        {
            if (this.currentAccount == null || this.lbWaterRecords.SelectedValue == null)
                return;

            var expense = this.lbWaterRecords.SelectedItem as WaterExpense;

            if (MessageUtil.ConfirmYesNo("是否确认删除选中水费支出") == DialogResult.Yes)
            {
                try
                {
                    BusinessFactory<WaterExpenseBusiness>.Instance.Delete(expense);

                    LoadWater();
                    MessageUtil.ShowInfo("删除成功");
                }
                catch (PoseidonException pe)
                {
                    MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
                }
            }
        }
        #endregion //Event
    }
}
