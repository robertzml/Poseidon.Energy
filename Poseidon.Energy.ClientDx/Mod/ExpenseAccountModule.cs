using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Energy.ClientDx.Model;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 支出账户组件
    /// </summary>
    public partial class ExpenseAccountModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private ExpenseAccount currentAccount;

        /// <summary>
        /// 今年
        /// </summary>
        private int nowYear;
        #endregion //Field

        #region Constructor
        public ExpenseAccountModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 清空显示
        /// </summary>
        private void ClearDisplay()
        {
            this.currentYearElectricGrid.Clear();
            this.currentYearWaterGrid.Clear();
            this.currentYearElectricChart.Clear();
            this.currentYearWaterChart.Clear();

            this.modElecCompGrid.Clear();
            this.modElectricCompare.Clear();
            this.modWaterCompareGrid.Clear();
            this.modWaterCompare.Clear();
        }

        /// <summary>
        /// 显示信息
        /// </summary>
        /// <param name="account">相关账户</param>
        private void DisplayInfo(ExpenseAccount account)
        {
            this.ctrAccountInfo.SetAccount(account);

            LoadSummary(account);
            if (account.EnergyType.Contains(1))
            {
                LoadElectric();
            }
            else
            {
                this.tabPageElectricMeter.PageVisible = false;
                this.tabPageElectricCompareGrid.PageVisible = false;
                this.tabPageElectricCompareChart.PageVisible = false;
                this.tabPageElectricReceipt.PageVisible = false;
            }

            if (account.EnergyType.Contains(2))
            {
                LoadWater();
            }
            else
            {
                this.tabPageWaterMeter.PageVisible = false;
                this.tabPageWaterCompareGrid.PageVisible = false;
                this.tabPageWaterCompareChart.PageVisible = false;
                this.tabPageWaterReceipt.PageVisible = false;
            }


            if (account.EnergyType.Contains(3))
            { }
            if (account.EnergyType.Contains(4))
            { }
        }

        /// <summary>
        /// 载入摘要
        /// </summary>
        private void LoadSummary(ExpenseAccount account)
        {
            if (account.EnergyType.Contains(1))
            {
                List<EnergyExpense> electricData = new List<EnergyExpense>();
                var electricExpense = BusinessFactory<ElectricExpenseBusiness>.Instance.FindYearByAccount(account.Id, this.nowYear);

                foreach (var exp in electricExpense)
                {
                    var model = new EnergyExpense();
                    model.BelongDate = exp.BelongDate;
                    model.Quantum = exp.TotalQuantity;
                    model.Amount = exp.TotalAmount;

                    electricData.Add(model);
                }
                this.currentYearElectricGrid.DataSource = electricData;

                this.currentYearElectricChart.SetChartTitle(string.Format("{0}年用电支出", this.nowYear));
                this.currentYearElectricChart.OnlyShowMonth();
                this.currentYearElectricChart.SetDataSource(electricData);
            }

            if (account.EnergyType.Contains(2))
            {
                List<EnergyExpense> waterData = new List<EnergyExpense>();
                var electricExpense = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(account.Id, this.nowYear);

                foreach (var exp in electricExpense)
                {
                    var model = new EnergyExpense();
                    model.BelongDate = exp.BelongDate;
                    model.Quantum = exp.TotalQuantity;
                    model.Amount = exp.TotalAmount;

                    waterData.Add(model);
                }
                this.currentYearWaterGrid.DataSource = waterData;

                this.currentYearWaterChart.SetChartTitle(string.Format("{0}年用水支出", this.nowYear));
                this.currentYearWaterChart.OnlyShowMonth();
                this.currentYearWaterChart.SetDataSource(waterData);
            }
        }

        /// <summary>
        /// 载入电费相关数据
        /// </summary>
        private void LoadElectric()
        {
            // 电表
            this.tabPageElectricMeter.PageVisible = true;
            this.electricMeterGrid.DataSource = this.currentAccount.ElectricMeters;

            // 用电对比表
            this.tabPageElectricCompareGrid.PageVisible = true;
            this.modElecCompGrid.SetAccount(this.currentAccount);

            // 用电对比图
            this.tabPageElectricCompareChart.PageVisible = true;
            this.modElectricCompare.SetAccount(this.currentAccount);

            // 电费单据
            this.tabPageElectricReceipt.PageVisible = true;
            this.electricExpenseReceipt.SetAccount(this.currentAccount);
        }

        /// <summary>
        /// 载入水费相关数据
        /// </summary>
        private void LoadWater()
        {
            // 水表
            this.tabPageWaterMeter.PageVisible = true;
            this.waterMeterGrid.DataSource = this.currentAccount.WaterMeters;

            // 用水对比表
            this.tabPageWaterCompareGrid.PageVisible = true;
            var currentYearList = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(this.currentAccount.Id, nowYear).ToList();
            this.modWaterCompareGrid.SetAccount(this.currentAccount);

            // 用水对比图
            this.tabPageWaterCompareChart.PageVisible = true;
            this.modWaterCompare.SetAccount(this.currentAccount);

            // 水费单据
            this.tabPageWaterReceipt.PageVisible = true;
            this.waterExpenseReceipt.SetAccount(this.currentAccount);
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置账户
        /// </summary>
        /// <param name="id">支出账户ID</param>
        public void SetAccount(string id)
        {
            this.currentAccount = BusinessFactory<ExpenseAccountBusiness>.Instance.FindById(id);
            this.nowYear = DateTime.Now.Year;

            ClearDisplay();
            DisplayInfo(this.currentAccount);
        }
        #endregion //Method
    }
}
