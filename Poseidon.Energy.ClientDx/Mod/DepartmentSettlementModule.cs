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
    using DevExpress.XtraCharts;
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Core.Utility;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 部门能源结算模块
    /// </summary>
    public partial class DepartmentSettlementModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联部门
        /// </summary>
        private Department currentDepartment;

        private int startYear = 2011;

        private int nowYear;
        #endregion //Field

        #region Constructor
        public DepartmentSettlementModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入能源结算
        /// </summary>
        private void LoadSettlements()
        {
            this.bsSettlement.DataSource = BusinessFactory<SettlementBusiness>.Instance.FindAll();
        }

        /// <summary>
        /// 显示能源结算信息
        /// </summary>
        /// <param name="settlement">能源结算</param>
        private void DisplaySettlementInfo(Settlement settlement)
        {
            this.txtName.Text = settlement.Name;
            this.txtBelongTime.Text = settlement.BelongTime;
            this.txtYear.Text = settlement.Year.ToString();
            this.txtType.Text = ((SettlementType)settlement.Type).DisplayName();

            var target = BusinessFactory<TargetBusiness>.Instance.FindById(settlement.TargetId);
            this.txtTargetName.Text = target.Name;

            if (string.IsNullOrEmpty(settlement.PreviousId))
                this.txtPrevious.Text = "首次结算";
            else
            {
                var previous = BusinessFactory<SettlementBusiness>.Instance.FindById(settlement.PreviousId);
                this.txtPrevious.Text = previous.Name;
            }

            this.txtRemark.Text = settlement.Remark;
        }

        /// <summary>
        /// 显示部门结算记录信息
        /// </summary>
        /// <param name="settlement">能源结算</param>
        /// <param name="department">部门</param>
        private void DisplayRecordInfo(Settlement settlement, Department department)
        {
            this.txtDepartmentName.Text = department.Name;

            var erecord = BusinessFactory<SettlementRecordBusiness>.Instance.FindByDepartment(settlement.Id, department.Id, EnergyType.Electric);
            if (erecord != null)
            {
                this.txtElectricUnitPrice.Text = erecord.UnitPrice.ToString();
                this.txtElectricBeginQuantum.Text = erecord.BeginQuantum.ToString();
                this.txtElectricBeginAmount.Text = erecord.BeginAmount.ToString();
                this.txtElectricQuantum.Text = erecord.Quantum.ToString();
                this.txtElectricAmount.Text = erecord.Amount.ToString();
                this.txtElectricEndQuantum.Text = (erecord.BeginQuantum - erecord.Quantum).ToString();
                this.txtElectricEndAmount.Text = (erecord.BeginAmount - erecord.Amount).ToString();
                this.txtElectricRemark.Text = erecord.Remark;
            }

            var wrecord = BusinessFactory<SettlementRecordBusiness>.Instance.FindByDepartment(settlement.Id, department.Id, EnergyType.Water);
            if (wrecord != null)
            {
                this.txtWaterUnitPrice.Text = wrecord.UnitPrice.ToString();
                this.txtWaterBeginQuantum.Text = wrecord.BeginQuantum.ToString();
                this.txtWaterBeginAmount.Text = wrecord.BeginAmount.ToString();
                this.txtWaterQuantum.Text = wrecord.Quantum.ToString();
                this.txtWaterAmount.Text = wrecord.Amount.ToString();
                this.txtWaterEndQuantum.Text = (wrecord.BeginQuantum - wrecord.Quantum).ToString();
                this.txtWaterEndAmount.Text = (wrecord.BeginAmount - wrecord.Amount).ToString();
                this.txtWaterRemark.Text = wrecord.Remark;
            }
        }

        /// <summary>
        /// 显示结算汇总
        /// </summary>
        /// <param name="department">部门</param>
        private async void DisplaySummary(Department department)
        {
            var task1 = Task.Run(() =>
            {
                List<DepartmentSettlementSummary> data = new List<DepartmentSettlementSummary>();
                for (int i = nowYear; i >= startYear; i--)
                {
                    var item = BusinessFactory<SettlementBusiness>.Instance.GetDepartmentSummary(i, EnergyType.Electric, department);
                    if (item != null)
                        data.Add(item);
                }

                return data;
            });
            var data1 = await task1;
            this.depElectricSettleGrid.SetEnergyType(EnergyType.Electric);
            this.depElectricSettleGrid.DataSource = data1;

            var task2 = Task.Run(() =>
            {
                List<SettlementQuantumSummary> data = new List<SettlementQuantumSummary>();
                for (int i = nowYear; i >= startYear; i--)
                {
                    var item = BusinessFactory<SettlementBusiness>.Instance.GetDepartmentQuantumSummary(i, EnergyType.Electric, department);
                    if (item != null)
                        data.Add(item);
                }

                return data;
            });
            var data2 = await task2;
            this.electricQSGrid.SetEnergyType(EnergyType.Electric);
            this.electricQSGrid.DataSource = data2;

            var task3 = Task.Run(() =>
            {
                List<SettlementAmountSummary> data = new List<SettlementAmountSummary>();
                for (int i = nowYear; i >= startYear; i--)
                {
                    var item = BusinessFactory<SettlementBusiness>.Instance.GetDepartmentAmountSummary(i, EnergyType.Electric, department);
                    if (item != null)
                        data.Add(item);
                }

                return data;
            });
            var data3 = await task3;
            this.electricASGrid.DataSource = data3;

            var task4 = Task.Run(() =>
            {
                List<DepartmentSettlementSummary> data = new List<DepartmentSettlementSummary>();
                for (int i = nowYear; i >= startYear; i--)
                {
                    var item = BusinessFactory<SettlementBusiness>.Instance.GetDepartmentSummary(i, EnergyType.Water, department);
                    if (item != null)
                        data.Add(item);
                }

                return data;
            });
            var data4 = await task4;
            this.depWaterSettleGrid.SetEnergyType(EnergyType.Water);
            this.depWaterSettleGrid.DataSource = data4;

            var task5 = Task.Run(() =>
            {
                List<SettlementQuantumSummary> data = new List<SettlementQuantumSummary>();
                for (int i = nowYear; i >= startYear; i--)
                {
                    var item = BusinessFactory<SettlementBusiness>.Instance.GetDepartmentQuantumSummary(i, EnergyType.Water, department);
                    if (item != null)
                        data.Add(item);
                }

                return data;
            });
            var data5 = await task5;
            this.waterQSGrid.SetEnergyType(EnergyType.Water);
            this.waterQSGrid.DataSource = data5;

            var task6 = Task.Run(() =>
            {
                List<SettlementAmountSummary> data = new List<SettlementAmountSummary>();
                for (int i = nowYear; i >= startYear; i--)
                {
                    var item = BusinessFactory<SettlementBusiness>.Instance.GetDepartmentAmountSummary(i, EnergyType.Water, department);
                    if (item != null)
                        data.Add(item);
                }

                return data;
            });
            var data6 = await task6;
            this.waterASGrid.DataSource = data6;
        }

        /// <summary>
        /// 显示结算趋势
        /// </summary>
        /// <param name="department">部门</param>
        private void DisplayTrend(Department department)
        {
            this.electricTrendMod.SetDepartment(department, EnergyType.Electric);
            this.waterTrendMod.SetDepartment(department, EnergyType.Water);

            this.electricSettleMod.SetDepartment(department, EnergyType.Electric);
            this.waterSettleMod.SetDepartment(department, EnergyType.Water);
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置关联部门
        /// </summary>
        /// <param name="id">部门ID</param>
        public void SetDepartment(string id)
        {
            this.currentDepartment = BusinessFactory<DepartmentBusiness>.Instance.FindById(id);
            this.nowYear = DateTime.Now.Year;

            LoadSettlements();
            DisplaySummary(this.currentDepartment);
            DisplayTrend(this.currentDepartment);
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.txtDepartmentName.Text = "";

            this.txtElectricUnitPrice.Text = "";
            this.txtElectricBeginQuantum.Text = "";
            this.txtElectricBeginAmount.Text = "";
            this.txtElectricQuantum.Text = "";
            this.txtElectricAmount.Text = "";
            this.txtElectricEndQuantum.Text = "";
            this.txtElectricEndAmount.Text = "";
            this.txtElectricRemark.Text = "";

            this.txtWaterUnitPrice.Text = "";
            this.txtWaterBeginQuantum.Text = "";
            this.txtWaterBeginAmount.Text = "";
            this.txtWaterQuantum.Text = "";
            this.txtWaterAmount.Text = "";
            this.txtWaterEndQuantum.Text = "";
            this.txtWaterEndAmount.Text = "";
            this.txtWaterRemark.Text = "";
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 选择结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbSettlements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbSettlements.SelectedItem == null)
            {
                return;
            }

            Clear();

            var settlement = this.lbSettlements.SelectedItem as Settlement;

            DisplaySettlementInfo(settlement);
            DisplayRecordInfo(settlement, this.currentDepartment);
        }
        #endregion //Event
    }
}
