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
    using Poseidon.Common;
    using Poseidon.Energy.ClientDx.Model;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 账户支出模块
    /// </summary>
    public partial class AccountExpenseModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private ExpenseAccount currentAccount;

        private int startYear = 2011;

        /// <summary>
        /// 今年
        /// </summary>
        private int nowYear;
        #endregion //Field

        #region Constructor
        public AccountExpenseModule()
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

            this.electricCompareGridMod.Clear();
            this.electricCompareChartMod.Clear();
            this.waterCompareGridMod.Clear();
            this.waterCompareChartMod.Clear();

            this.electricYearGridMod.Clear();
            this.waterYearGridMod.Clear();
        }

        /// <summary>
        /// 显示摘要
        /// </summary>
        /// <param name="account"></param>
        private async void DisplaySummary(ExpenseAccount account)
        {
            this.ctrAccountInfo.SetAccount(account);

            //用电
            if (account.EnergyType.Contains(1))
            {
                this.electricMeterGrid.DataSource = account.ElectricMeters;

                var task = Task.Run(() =>
                {
                    List<EnergyExpense> electricData = new List<EnergyExpense>();
                    var electricExpense = BusinessFactory<ElectricExpenseBusiness>.Instance.FindYearByAccount(account.Id, this.nowYear);

                    foreach (var exp in electricExpense)
                    {
                        var model = new EnergyExpense();
                        model.BelongDate = exp.BelongDate;
                        model.Quantum = exp.TotalQuantity;
                        model.Amount = exp.TotalAmount;
                        model.AdditionData = exp.TotalPrize;

                        electricData.Add(model);
                    }
                    return electricData;
                });

                var data = await task;
                this.currentYearElectricGrid.DataSource = data;
                this.currentYearElectricGrid.ShowAddition("功率因数奖(元)");

                this.currentYearElectricChart.SetChartTitle(string.Format("{0}{1}年电量消耗", account.ShortName, this.nowYear));
                this.currentYearElectricChart.SetDataSource(data);
            }

            //用水
            if (account.EnergyType.Contains(2))
            {
                this.waterMeterGrid.DataSource = account.WaterMeters;

                var task = Task.Run(() =>
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

                    return waterData;
                });

                var data = await task;
                this.currentYearWaterGrid.DataSource = data;

                this.currentYearWaterChart.SetChartTitle(string.Format("{0}{1}年水量消耗", account.ShortName, this.nowYear));
                this.currentYearWaterChart.SetDataSource(data);
            }
        }

        /// <summary>
        /// 显示单据
        /// </summary>
        /// <param name="account"></param>
        private void DisplayReceipt(ExpenseAccount account)
        {
            this.electricExpenseReceipt.SetAccount(account);

            this.waterExpenseReceipt.SetAccount(account);
        }

        /// <summary>
        /// 显示对比
        /// </summary>
        /// <param name="account"></param>
        private void DisplayCompare(ExpenseAccount account)
        {
            this.electricCompareGridMod.SetAccount(account);
            this.electricCompareChartMod.SetAccount(account);

            this.waterCompareGridMod.SetAccount(account);
            this.waterCompareChartMod.SetAccount(account);
        }

        /// <summary>
        /// 显示年度汇总
        /// </summary>
        /// <param name="account"></param>
        private async void DisplayYear(ExpenseAccount account)
        {
            var task1 = Task.Run(() =>
            {
                List<EnergyExpense> data = new List<EnergyExpense>();
                for (int i = startYear; i <= nowYear; i++)
                {
                    var yearData = BusinessFactory<ElectricExpenseBusiness>.Instance.FindYearByAccount(account.Id, i);
                    if (yearData.Count() == 0)
                        continue;

                    EnergyExpense energyExpense = new EnergyExpense();
                    energyExpense.BelongDate = new DateTime(i, 1, 1);
                    energyExpense.Quantum = yearData.Sum(r => r.TotalQuantity);
                    energyExpense.Amount = yearData.Sum(r => r.TotalAmount);

                    data.Add(energyExpense);
                }

                return data;
            });

            var result1 = await task1;

            this.electricYearChart.SetChartTitle(account.ShortName + "历年用电对比");
            this.electricYearChart.SetSeriesLengedText(0, "用电量(度)");
            this.electricYearChart.DataSource = result1;

            var task2 = Task.Run(() =>
            {
                List<EnergyExpense> data = new List<EnergyExpense>();
                for (int i = startYear; i <= nowYear; i++)
                {
                    var yearData = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(account.Id, i);
                    if (yearData.Count() == 0)
                        continue;

                    EnergyExpense energyExpense = new EnergyExpense();
                    energyExpense.BelongDate = new DateTime(i, 1, 1);
                    energyExpense.Quantum = yearData.Sum(r => r.TotalQuantity);
                    energyExpense.Amount = yearData.Sum(r => r.TotalAmount);

                    data.Add(energyExpense);
                }
                return data;
            });

            var result2 = await task2;

            this.waterYearChart.SetChartTitle(account.ShortName + "历年用水对比");
            this.waterYearChart.SetSeriesLengedText(0, "用水量(吨)");
            this.waterYearChart.DataSource = result2;

            this.electricYearGridMod.SetAccount(this.currentAccount.Id, EnergyType.Electric);
            this.waterYearGridMod.SetAccount(this.currentAccount.Id, EnergyType.Water);
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
            DisplaySummary(this.currentAccount);
            DisplayReceipt(this.currentAccount);
            DisplayCompare(this.currentAccount);
            DisplayYear(this.currentAccount);
        }
        #endregion //Method
    }
}
