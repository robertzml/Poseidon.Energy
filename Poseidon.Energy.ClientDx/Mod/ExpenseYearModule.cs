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
    using Poseidon.Energy.ClientDx.Model;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 年度支出模块
    /// </summary>
    public partial class ExpenseYearModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private ExpenseAccount currentAccount;

        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;

        /// <summary>
        /// 能源类型
        /// </summary>
        private EnergyExpenseType energyType;

        private int startYear = 2011;

        private int nowYear;

        /// <summary>
        /// 显示类型  1:部门  2:分组
        /// </summary>
        private int showType;
        #endregion //Field

        #region Constructor
        public ExpenseYearModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化控件
        /// </summary>
        private void InitControls()
        {
            this.cmbYear.Properties.Items.Clear();

            for (int i = nowYear; i >= startYear; i--)
            {
                this.cmbYear.Properties.Items.Add(i.ToString() + "年");
            }

            this.cmbYear.SelectedIndex = 0;
        }

        /// <summary>
        /// 载入数据
        /// </summary>
        /// <param name="account">支出账户</param>
        /// <param name="year">年度</param>
        /// <param name="energyType">能源类型</param>
        private async void LoadAccountData(ExpenseAccount account, int year, EnergyExpenseType energyType)
        {
            switch (energyType)
            {
                case EnergyExpenseType.Electric:
                    var data1 = await LoadElectric(account, year);
                    this.expenseGrid.DataSource = data1;
                    this.expenseGrid.ShowUnitPrice = false;
                    this.expenseGrid.ShowAddition("功率因数奖(元)");
                    break;
                case EnergyExpenseType.Water:
                    var data2 = await LoadWater(account, year);
                    this.expenseGrid.DataSource = data2;
                    this.expenseGrid.ShowUnitPrice = true;
                    break;
            }
        }

        /// <summary>
        /// 载入分组数据
        /// </summary>
        /// <param name="group">分组</param>
        /// <param name="year">年度</param>
        /// <param name="energyType">能源类型</param>
        private async void LoadGroupData(Group group, int year, EnergyExpenseType energyType)
        {
            switch (energyType)
            {
                case EnergyExpenseType.Electric:
                    var data1 = await LoadElectric(group, year);
                    this.expenseGrid.DataSource = data1;
                    this.expenseGrid.ShowUnitPrice = false;
                    this.expenseGrid.ShowAddition("功率因数奖(元)");
                    this.expenseGrid.SetEnergyType(EnergyExpenseType.Electric);
                    break;
                case EnergyExpenseType.Water:
                    var data2 = await LoadWater(group, year);
                    this.expenseGrid.DataSource = data2;
                    this.expenseGrid.ShowUnitPrice = true;
                    this.expenseGrid.SetEnergyType(EnergyExpenseType.Water);
                    break;
            }
        }

        /// <summary>
        /// 载入电费支出
        /// </summary>
        /// <param name="account"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        private async Task<List<EnergyExpense>> LoadElectric(ExpenseAccount account, int year)
        {
            var task = Task.Run(() =>
            {
                List<EnergyExpense> electricData = new List<EnergyExpense>();
                var electricExpense = BusinessFactory<ElectricExpenseBusiness>.Instance.FindYearByAccount(account.Id, year);

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

            return await task;
        }

        /// <summary>
        /// 载入电费支出
        /// </summary>
        /// <param name="group"></param>
        /// <param name="year"></param>
        private async Task<List<EnergyExpense>> LoadElectric(Group group, int year)
        {
            var task = Task.Run(() =>
            {
                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                List<EnergyExpense> data = new List<EnergyExpense>();

                foreach (var item in items)
                {
                    var expense = BusinessFactory<ElectricExpenseBusiness>.Instance.FindYearByAccount(item.OrganizationId, year);
                    foreach (var exp in expense)
                    {
                        var energyExpense = data.SingleOrDefault(r => r.BelongDate == exp.BelongDate);
                        if (energyExpense != null)
                        {
                            energyExpense.Amount += exp.TotalAmount;
                            energyExpense.Quantum += exp.TotalQuantity;
                            energyExpense.AdditionData += exp.TotalPrize;
                        }
                        else
                        {
                            var model = new EnergyExpense();
                            model.BelongDate = exp.BelongDate;
                            model.Quantum = exp.TotalQuantity;
                            model.Amount = exp.TotalAmount;
                            model.AdditionData = exp.TotalPrize;

                            data.Add(model);
                        }
                    }
                }

                return data;
            });

            return await task;
        }

        /// <summary>
        /// 载入水费支出
        /// </summary>
        /// <param name="account"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        private async Task<List<EnergyExpense>> LoadWater(ExpenseAccount account, int year)
        {
            var task = Task.Run(() =>
            {
                List<EnergyExpense> expenseData = new List<EnergyExpense>();
                var waterExpense = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(account.Id, year);

                foreach (var exp in waterExpense)
                {
                    var model = new EnergyExpense();
                    model.BelongDate = exp.BelongDate;
                    model.Quantum = exp.TotalQuantity;
                    model.Amount = exp.TotalAmount;
                    model.UnitPrice = exp.TotalAmount / exp.TotalQuantity;

                    expenseData.Add(model);
                }
                return expenseData;
            });

            return await task;
        }

        /// <summary>
        /// 载入水费支出
        /// </summary>
        /// <param name="group"></param>
        /// <param name="year"></param>
        private async Task<List<EnergyExpense>> LoadWater(Group group, int year)
        {
            var task = Task.Run(() =>
            {
                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                List<EnergyExpense> waterData = new List<EnergyExpense>();
                foreach (var item in items)
                {
                    var expense = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(item.OrganizationId, year);
                    foreach (var exp in expense)
                    {
                        var energyExpense = waterData.SingleOrDefault(r => r.BelongDate == exp.BelongDate);
                        if (energyExpense != null)
                        {
                            energyExpense.Amount += exp.TotalAmount;
                            energyExpense.Quantum += exp.TotalQuantity;
                        }
                        else
                        {
                            var model = new EnergyExpense();
                            model.BelongDate = exp.BelongDate;
                            model.Quantum = exp.TotalQuantity;
                            model.Amount = exp.TotalAmount;
                            model.UnitPrice = exp.TotalAmount / exp.TotalQuantity;

                            waterData.Add(model);
                        }
                    }
                }

                return waterData;
            });

            return await task;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置账户
        /// </summary>
        /// <param name="account">支出账户</param>
        /// <param name="energyType">能源类型</param>
        public void SetAccount(ExpenseAccount account, EnergyExpenseType energyType)
        {
            this.currentAccount = account;
            this.energyType = energyType;
            this.showType = 1;
            this.nowYear = DateTime.Now.Year;

            InitControls();
        }

        /// <summary>
        /// 设置分组
        /// </summary>
        /// <param name="group">分组</param>
        /// <param name="energyType">能源类型</param>
        public void SetGroup(Group group, EnergyExpenseType energyType)
        {
            this.currentGroup = group;
            this.energyType = energyType;
            this.nowYear = DateTime.Now.Year;
            this.showType = 2;

            InitControls();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.cmbYear.EditValue = "";
            this.expenseGrid.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 年度选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbYear.SelectedIndex == -1)
                return;

            int year = Convert.ToInt32(this.cmbYear.SelectedItem.ToString().Substring(0, 4));
            if (this.showType == 1)
                LoadAccountData(this.currentAccount, year, this.energyType);
            else if (this.showType == 2)
                LoadGroupData(this.currentGroup, year, this.energyType);
        }
        #endregion //Event
    }
}