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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
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
        private int year;
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
            this.year = DateTime.Now.Year;
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

            this.waterYearGrid1.DataSource = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(this.currentAccount.Id, year).ToList();
            this.waterYearGrid2.DataSource = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(this.currentAccount.Id, year - 1).ToList();

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
        }

        /// <summary>
        /// 选择水费支出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbWaterRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbWaterRecords.SelectedItem == null)
                return;

            ShowWaterExpense(this.lbWaterRecords.SelectedItem as WaterExpense);
        }
        #endregion //Event
    }
}
