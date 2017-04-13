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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.ClientDx.Model;

    /// <summary>
    /// 分组费用支出组件
    /// </summary>
    public partial class GroupExpenseModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;

        /// <summary>
        /// 今年
        /// </summary>
        private int year;
        #endregion //Field

        #region Constructor
        public GroupExpenseModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 显示基本信息
        /// </summary>
        /// <param name="group">分组</param>
        private void DisplayInfo(Group group)
        {
            this.txtGroupName.Text = group.Name;
        }

        /// <summary>
        /// 显示今年支出
        /// </summary>
        /// <param name="group">分组</param>
        private async void DisplayYearExpense(Group group)
        {
            var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

            var task1 = Task.Run(() =>
            {
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
                        }
                        else
                        {
                            var model = new EnergyExpense();
                            model.BelongDate = exp.BelongDate;
                            model.Quantum = exp.TotalQuantity;
                            model.Amount = exp.TotalAmount;

                            data.Add(model);
                        }
                    }
                }

                return data;
            });

            var data1 = await task1;
            this.currentYearElectricGrid.DataSource = data1;

            var task2 = Task.Run(() =>
            {
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

                            waterData.Add(model);
                        }
                    }
                }

                return waterData;
            });

            var data2 = await task2;
            this.currentYearWaterGrid.DataSource = data2;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置关联分组
        /// </summary>
        /// <param name="id">分组ID</param>
        public void SetGroup(string id)
        {
            this.currentGroup = BusinessFactory<GroupBusiness>.Instance.FindById(id);
            this.year = DateTime.Now.Year;

            DisplayInfo(this.currentGroup);
            DisplayYearExpense(this.currentGroup);
        }
        #endregion //Method
    }
}
