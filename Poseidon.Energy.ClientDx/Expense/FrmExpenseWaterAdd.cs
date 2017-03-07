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

        #region Field
        private void InitData(string id)
        {
            this.currentAccount = BusinessFactory<ExpenseAccountBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.txtAccountName.Text = this.currentAccount.Name;
            this.dpTicketDate.DateTime = DateTime.Now;

            SetRecords();

            base.InitForm();
        }

        /// <summary>
        /// 设置关联水表
        /// </summary>
        private void SetRecords()
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

        private void SetEntity(WaterExpense entity)
        {
            entity.AccountId = this.currentAccount.Id;
            entity.BelongDate = this.dpBelongDate.DateTime.Date;
            entity.TicketDate = this.dpTicketDate.DateTime.Date;
            entity.FeeType = Convert.ToInt32(this.spFeeType.Value);

        }
        #endregion //Field

        #region Event
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSum_Click(object sender, EventArgs e)
        {
            decimal totalQuantity = 0;
            decimal totalAmount = 0;
            foreach(var item in this.expenseGrid.DataSource)
            {
                totalQuantity += item.Quantity;
                totalAmount += item.Amount;
            }

            this.spTotalQuantity.Value = totalQuantity;
            this.spTotalAmount.Value = totalAmount;
        }
        #endregion //Event
    }
}
