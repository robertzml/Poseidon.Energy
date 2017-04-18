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
    using DevExpress.XtraReports.UI;
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;
    using Poseidon.Energy.ClientDx.Utility;
    using Poseidon.Energy.ClientDx.Report;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 分组能源结算组件
    /// </summary>
    public partial class GroupSettlementModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;
        #endregion //Field

        #region Constructor
        public GroupSettlementModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 显示汇总信息
        /// </summary>
        /// <param name="group">分组</param>
        private void DisplaySummary(Group group)
        {
            this.txtGroupName.Text = group.Name;

            var settlements = BusinessFactory<SettlementBusiness>.Instance.FindAll();

            this.lbYears.Items.Clear();
            var years = settlements.GroupBy(r => r.Year).Select(s => s.Key).OrderByDescending(t => t);

            foreach (var year in years)
            {
                this.lbYears.Items.Add(year.ToString() + "年");
            }
        }

        /// <summary>
        /// 显示记录信息
        /// </summary>
        /// <param name="group">分组</param>
        private void DisplayRecords(Group group)
        {
            this.txtGroupName2.Text = group.Name;

            var settlements = BusinessFactory<SettlementBusiness>.Instance.FindAll();
            this.bsSettlement.DataSource = settlements;
        }

        /// <summary>
        /// 显示对比信息
        /// </summary>
        /// <param name="group">分组</param>
        private void DisplayCompare(Group group)
        {
            this.electricCompareMod.SetGroup(group, EnergyType.Electric);
            this.waterCompareMod.SetGroup(group, EnergyType.Water);
        }

        /// <summary>
        /// 载入汇总数据
        /// </summary>
        /// <param name="year">年度</param>
        /// <param name="group">分组</param>
        private async Task LoadSummaryData(int year, Group group)
        {
            this.txtYear.Text = year.ToString();

            var departments = BusinessFactory<DepartmentBusiness>.Instance.FindInGroup(group.Code, true).ToList();

            var task1 = Task.Run(() =>
            {
                var data = BusinessFactory<SettlementBusiness>.Instance.GetQuantumSummary(year, EnergyType.Electric, departments);
                return data.ToList();
            });
            var elecQuantum = await task1;
            this.electricQSGrid.SetEnergyType(EnergyType.Electric);
            this.electricQSGrid.DataSource = elecQuantum;

            var task2 = Task.Run(() =>
            {
                var data = BusinessFactory<SettlementBusiness>.Instance.GetQuantumSummary(year, EnergyType.Water, departments);
                return data.ToList();
            });
            var waterQuantum = await task2;
            this.waterQSGrid.SetEnergyType(EnergyType.Water);
            this.waterQSGrid.DataSource = waterQuantum;

            var task3 = Task.Run(() =>
            {
                var data = BusinessFactory<SettlementBusiness>.Instance.GetAmountSummary(year, EnergyType.Electric, departments);
                return data.ToList();
            });
            var elecAmount = await task3;
            this.elecASGrid.DataSource = elecAmount;

            var task4 = Task.Run(() =>
            {
                var data = BusinessFactory<SettlementBusiness>.Instance.GetAmountSummary(year, EnergyType.Water, departments);
                return data.ToList();
            });
            var waterAmount = await task4;
            this.watASGrid.DataSource = waterAmount;

            this.txtTotalElectricQuantum.Text = string.Format("{0}度", elecQuantum.Sum(r => r.TotalQuantum));
            this.txtTotalElectricAmount.Text = string.Format("{0}元", elecAmount.Sum(r => r.TotalAmount));
            this.txtTotalWaterQuantum.Text = string.Format("{0}吨", waterQuantum.Sum(r => r.TotalQuantum));
            this.txtTotalWaterAmount.Text = string.Format("{0}元", waterAmount.Sum(r => r.TotalAmount));

            this.electricSettleChart.SetGroup(year, group, EnergyType.Electric);
            this.waterSettleChart.SetGroup(year, group, EnergyType.Water);
        }

        /// <summary>
        /// 显示能源结算信息
        /// </summary>
        /// <param name="entity">能源结算</param>
        /// <param name="group">分组</param>
        private async Task LoadSettlmentInfo(Settlement entity, Group group)
        {
            this.txtName.Text = entity.Name;
            this.txtYear2.Text = entity.Year.ToString();
            this.txtBelongTime.Text = entity.BelongTime;
            this.txtSettlementType.Text = ((SettlementType)entity.Type).DisplayName();
            this.txtCreateUser.Text = entity.CreateBy.Name;
            this.txtCreateTime.Text = entity.CreateBy.Time.ToDateTimeString();
            this.txtEditUser.Text = entity.UpdateBy.Name;
            this.txtEditTime.Text = entity.UpdateBy.Time.ToDateTimeString();
            this.txtRemark.Text = entity.Remark;

            var target = BusinessFactory<TargetBusiness>.Instance.FindById(entity.TargetId);
            this.txtTargetName.Text = target.Name;

            if (string.IsNullOrEmpty(entity.PreviousId))
                this.txtPrevious.Text = "首次结算";
            else
            {
                var previous = BusinessFactory<SettlementBusiness>.Instance.FindById(entity.PreviousId);
                this.txtPrevious.Text = previous.Name;
            }

            var groupItems = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

            var task1 = Task.Run(() =>
            {
                var records = BusinessFactory<SettlementRecordBusiness>.Instance.FindBySettlement(entity.Id, EnergyType.Electric);
                return records;
            });
            var electricRecords = await task1;
            this.electricSRGrid.DataSource = electricRecords.Where(r => groupItems.Select(s => s.OrganizationId).Contains(r.DepartmentId)).ToList();
            this.electricSRGrid.SetEnergyType(EnergyType.Electric);

            var task2 = Task.Run(() =>
            {
                var records = BusinessFactory<SettlementRecordBusiness>.Instance.FindBySettlement(entity.Id, EnergyType.Water);
                return records;
            });
            var waterRecords = await task2;
            this.waterSRGrid.DataSource = waterRecords.Where(r => groupItems.Select(s => s.OrganizationId).Contains(r.DepartmentId)).ToList();
            this.waterSRGrid.SetEnergyType(EnergyType.Water);
        }

        /// <summary>
        /// 载入结算报表数据
        /// </summary>
        /// <param name="settlement"></param>
        /// <param name="electricRecords"></param>
        /// <param name="waterRecords"></param>
        /// <returns></returns>
        private List<SettlementReportModel> LoadReportData(Settlement settlement, List<SettlementRecord> electricRecords, List<SettlementRecord> waterRecords)
        {
            List<SettlementReportModel> data = new List<SettlementReportModel>();

            foreach (var item in electricRecords)
            {
                var department = BusinessFactory<DepartmentBusiness>.Instance.FindById(item.DepartmentId);
                var targetRecord = BusinessFactory<TargetRecordBusiness>.Instance.FindByDepartment(settlement.TargetId, department.Id, (int)EnergyType.Electric);

                var model = ReportUtil.SettlementReportTranslate(department.Name, settlement, item, targetRecord);

                data.Add(model);
            }

            foreach (var item in waterRecords)
            {
                var department = BusinessFactory<DepartmentBusiness>.Instance.FindById(item.DepartmentId);
                var targetRecord = BusinessFactory<TargetRecordBusiness>.Instance.FindByDepartment(settlement.TargetId, department.Id, (int)EnergyType.Water);

                var model = ReportUtil.SettlementReportTranslate(department.Name, settlement, item, targetRecord);

                data.Add(model);
            }

            return data;
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

            DisplaySummary(this.currentGroup);
            DisplayRecords(this.currentGroup);
            DisplayCompare(this.currentGroup);
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 选择年度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void lbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbYears.SelectedIndex == -1)
                return;

            string text = this.lbYears.SelectedItem.ToString();
            int year = Convert.ToInt32(text.Substring(0, 4));

            await LoadSummaryData(year, this.currentGroup);
        }

        /// <summary>
        /// 选择结算记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void lbSettlements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbSettlements.SelectedItem == null)
            {
                return;
            }

            var settlement = this.lbSettlements.SelectedItem as Settlement;
            await LoadSettlmentInfo(settlement, this.currentGroup);
        }

        /// <summary>
        /// 打印结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.lbSettlements.SelectedItem == null)
            {
                return;
            }

            var settlement = this.lbSettlements.SelectedItem as Settlement;
            var data = LoadReportData(settlement, this.electricSRGrid.DataSource, this.waterSRGrid.DataSource);

            RepSettlement report = new RepSettlement();
            report.DataSource = data;

            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowRibbonPreview();
        }
        #endregion //Event
    }
}
