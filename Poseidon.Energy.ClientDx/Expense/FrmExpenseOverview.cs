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

            for (int i = nowYear; i >= 2010; i--)
                this.cmbWaterExpenseYear.Properties.Items.Add(i.ToString() + "年");

            base.InitForm();
        }

        /// <summary>
        /// 隐藏标签
        /// </summary>
        private void HideTab()
        {
            this.tabPageElectricMeter.PageVisible = false;
            this.tabPageWaterMeter.PageVisible = false;

            this.tabPageElectricReceipt.PageVisible = false;
            this.tabPageWaterExpense.PageVisible = false;
            this.tabPageWaterReceipt.PageVisible = false;
        }

        /// <summary>
        /// 设置账户信息
        /// </summary>
        private void InitAccountInfo()
        {
            this.ctrAccountInfo.SetAccount(this.currentAccount);

            if (this.currentAccount.EnergyType.Contains(1))
            {
                LoadElectric();
            }
            if (this.currentAccount.EnergyType.Contains(2))
            {
                LoadWater();
            }
            if (this.currentAccount.EnergyType.Contains(3))
            { }
            if (this.currentAccount.EnergyType.Contains(4))
            { }
        }

        /// <summary>
        /// 载入电费相关数据
        /// </summary>
        private void LoadElectric()
        {
            // 电表
            this.tabPageElectricMeter.PageVisible = true;
            this.electricMeterGrid.DataSource = this.currentAccount.ElectricMeters;

            // 电费单据
            this.tabPageElectricReceipt.PageVisible = true;
            this.electricExpenseReceipt.SetAccount(this.currentAccount);
        }

        /// <summary>
        /// 载入水费相关数据
        /// </summary>
        private void LoadWater()
        {
            this.tabPageWaterMeter.PageVisible = true;
            this.waterMeterGrid.DataSource = this.currentAccount.WaterMeters;

            // 水费支出
            this.tabPageWaterExpense.PageVisible = true;
            var currentYearList = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(this.currentAccount.Id, nowYear).ToList();
            this.waterYearGrid1.DataSource = currentYearList;
            this.waterYearGrid2.DataSource = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(this.currentAccount.Id, nowYear - 1).ToList();
            this.waterYearGrid3.Clear();

            // 水费单据
            this.tabPageWaterReceipt.PageVisible = true;
            this.waterExpenseReceipt.SetAccount(this.currentAccount);

            // 水费图表  
            this.waterExpChart.SetDataSource(currentYearList);
            this.waterExpChart.Visible = true;
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

            HideTab();
            if (id == null)
                this.currentAccount = null;
            else
            {
                this.currentAccount = BusinessFactory<ExpenseAccountBusiness>.Instance.FindById(id);
                InitAccountInfo();
            }
        }

        /// <summary>
        /// 选择水费年份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbWaterExpenseYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(this.cmbWaterExpenseYear.SelectedItem.ToString().Substring(0, 4));
            this.waterYearGrid3.DataSource = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(this.currentAccount.Id, year).ToList();
        }
        #endregion //Event
    }
}
