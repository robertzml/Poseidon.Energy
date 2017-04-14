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
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 结算图表模块
    /// </summary>
    public partial class SettlementChartModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;

        /// <summary>
        /// 当前关联部门
        /// </summary>
        private Department currentDepartment;

        /// <summary>
        /// 能源类型
        /// </summary>
        private EnergyType energyType;

        /// <summary>
        /// 显示类型  1:部门  2:分组
        /// </summary>
        private int showType;

        private int selectYear;

        private int startYear = 2011;

        private int nowYear;
        #endregion //Field

        #region Constructor
        public SettlementChartModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入单个部门数据
        /// </summary>
        /// <param name="type">0:金额 1:用量</param>
        private async void LoadDepartmentData(int type)
        {
            var task = Task.Run(() =>
            {
                List<SeriesPoint> targetPoints = new List<SeriesPoint>();
                List<SeriesPoint> realPoints = new List<SeriesPoint>();
                List<SeriesPoint> linePoints = new List<SeriesPoint>();

                for (int i = startYear; i <= nowYear; i++)
                {
                    var item = BusinessFactory<SettlementBusiness>.Instance.GetDepartmentSummary(i, energyType, currentDepartment);
                    if (item != null)
                    {
                        var point1 = new SeriesPoint();
                        point1.Argument = item.Year.ToString() + "年";
                        if (type == 0)
                            point1.Values = new double[] { Convert.ToDouble(item.PlanAmount) };
                        else if (type == 1)
                            point1.Values = new double[] { Convert.ToDouble(item.PlanQuantum) };
                        targetPoints.Add(point1);

                        var point2 = new SeriesPoint();
                        point2.Argument = item.Year.ToString() + "年";
                        if (type == 0)
                            point2.Values = new double[] { Convert.ToDouble(item.SettleAmount) };
                        else if (type == 1)
                            point2.Values = new double[] { Convert.ToDouble(item.SettleQuantum) };
                        realPoints.Add(point2);

                        var point3 = new SeriesPoint();
                        point3.Argument = item.Year.ToString() + "年";
                        if (type == 0)
                        {
                            decimal diff = 0;
                            if (item.PlanAmount == 0)
                                diff = 1;
                            else
                                diff = Math.Round((item.PlanAmount - item.SettleAmount) / item.PlanAmount, 2);

                            point3.Values = new double[] { Convert.ToDouble(diff) };
                        }
                        else if (type == 1)
                        {
                            decimal diff = 0;
                            if (item.PlanQuantum == 0)
                                diff = 1;
                            else
                                diff = Math.Round((item.PlanQuantum - item.SettleQuantum) / item.PlanQuantum, 2);

                            point3.Values = new double[] { Convert.ToDouble(diff) };
                        }
                        linePoints.Add(point3);
                    }
                }

                var data = new
                {
                    TargetPoint = targetPoints,
                    RealPoint = realPoints,
                    LinePoint = linePoints
                };
                return data;
            });

            var chartPoints = await task;

            if (energyType == EnergyType.Electric)
            {
                this.settlementChart.SetChartTitle(string.Format("{0}年度用电指标使用情况", currentDepartment.ShortName));
                if (type == 0)
                {
                    this.settlementChart.SetTarget(chartPoints.TargetPoint, "年度指标金额(元)");
                    this.settlementChart.SetReal(chartPoints.RealPoint, "年度用电金额(元)");
                }
                else if (type == 1)
                {
                    this.settlementChart.SetTarget(chartPoints.TargetPoint, "年度指标电量(度)");
                    this.settlementChart.SetReal(chartPoints.RealPoint, "年度用电量(度)");
                }
                this.settlementChart.SetLine(chartPoints.LinePoint, "指标偏离度");
            }
            else
            {
                this.settlementChart.SetChartTitle(string.Format("{0}年度用水指标使用情况", currentDepartment.ShortName));
                if (type == 0)
                {
                    this.settlementChart.SetTarget(chartPoints.TargetPoint, "年度指标金额(元)");
                    this.settlementChart.SetReal(chartPoints.RealPoint, "年度用水金额(元)");
                }
                else if (type == 1)
                {
                    this.settlementChart.SetTarget(chartPoints.TargetPoint, "年度指标水量(吨)");
                    this.settlementChart.SetReal(chartPoints.RealPoint, "年度用水量(吨)");
                }
                this.settlementChart.SetLine(chartPoints.LinePoint, "指标偏离度");
            }
        }

        /// <summary>
        /// 载入分组数据
        /// </summary>
        /// <param name="type">0:金额 1:用量</param>
        private async void LoadGroupData(int type)
        {
            var task = Task.Run(() =>
            {
                List<SeriesPoint> targetPoints = new List<SeriesPoint>();
                List<SeriesPoint> realPoints = new List<SeriesPoint>();
                List<SeriesPoint> linePoints = new List<SeriesPoint>();

                var departments = BusinessFactory<DepartmentBusiness>.Instance.FindInGroup(this.currentGroup.Code, true).ToList();

                foreach (var department in departments)
                {
                    var item = BusinessFactory<SettlementBusiness>.Instance.GetDepartmentSummary(this.selectYear, energyType, department);
                    if (item == null)
                        continue;

                    var point1 = new SeriesPoint();
                    point1.Argument = department.ShortName;
                    if (type == 0)
                        point1.Values = new double[] { Convert.ToDouble(item.PlanAmount) };
                    else if (type == 1)
                        point1.Values = new double[] { Convert.ToDouble(item.PlanQuantum) };
                    targetPoints.Add(point1);

                    var point2 = new SeriesPoint();
                    point2.Argument = department.ShortName;
                    if (type == 0)
                        point2.Values = new double[] { Convert.ToDouble(item.SettleAmount) };
                    else if (type == 1)
                        point2.Values = new double[] { Convert.ToDouble(item.SettleQuantum) };
                    realPoints.Add(point2);

                    var point3 = new SeriesPoint();
                    point3.Argument = department.ShortName;
                    if (type == 0)
                    {
                        decimal diff = 0;
                        if (item.PlanAmount == 0)
                            diff = 1;
                        else
                            diff = Math.Round((item.PlanAmount - item.SettleAmount) / item.PlanAmount, 2);

                        point3.Values = new double[] { Convert.ToDouble(diff) };
                    }
                    else if (type == 1)
                    {
                        decimal diff = 0;
                        if (item.PlanQuantum == 0)
                            diff = 1;
                        else
                            diff = Math.Round((item.PlanQuantum - item.SettleQuantum) / item.PlanQuantum, 2);

                        point3.Values = new double[] { Convert.ToDouble(diff) };
                    }
                    linePoints.Add(point3);
                }

                var data = new
                {
                    TargetPoint = targetPoints,
                    RealPoint = realPoints,
                    LinePoint = linePoints
                };
                return data;
            });

            var chartPoints = await task;

            if (energyType == EnergyType.Electric)
            {
                this.settlementChart.SetChartTitle(string.Format("{0}年度用电指标使用情况", currentGroup.Name));
                if (type == 0)
                {
                    this.settlementChart.SetTarget(chartPoints.TargetPoint, "年度指标金额(元)");
                    this.settlementChart.SetReal(chartPoints.RealPoint, "年度用电金额(元)");
                }
                else if (type == 1)
                {
                    this.settlementChart.SetTarget(chartPoints.TargetPoint, "年度指标电量(度)");
                    this.settlementChart.SetReal(chartPoints.RealPoint, "年度用电量(度)");
                }
                this.settlementChart.SetLine(chartPoints.LinePoint, "指标偏离度");
            }
            else
            {
                this.settlementChart.SetChartTitle(string.Format("{0}年度用水指标使用情况", currentGroup.Name));
                if (type == 0)
                {
                    this.settlementChart.SetTarget(chartPoints.TargetPoint, "年度指标金额(元)");
                    this.settlementChart.SetReal(chartPoints.RealPoint, "年度用水金额(元)");
                }
                else if (type == 1)
                {
                    this.settlementChart.SetTarget(chartPoints.TargetPoint, "年度指标水量(吨)");
                    this.settlementChart.SetReal(chartPoints.RealPoint, "年度用水量(吨)");
                }
                this.settlementChart.SetLine(chartPoints.LinePoint, "指标偏离度");
            }
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置部门
        /// </summary>
        /// <param name="department">部门</param>
        /// <param name="energyType">能源类型</param>
        public void SetDepartment(Department department, EnergyType energyType)
        {
            this.currentDepartment = department;
            this.energyType = energyType;
            this.nowYear = DateTime.Now.Year;
            this.showType = 1;

            LoadDepartmentData(this.cmbType.SelectedIndex);
        }

        /// <summary>
        /// 设置分组
        /// </summary>
        /// <param name="year"></param>
        /// <param name="group"></param>
        /// <param name="energyType"></param>
        public void SetGroup(int year, Group group, EnergyType energyType)
        {
            this.currentGroup = group;
            this.energyType = energyType;
            this.showType = 2;
            this.selectYear = year;

            LoadGroupData(this.cmbType.SelectedIndex);
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 类型选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.showType == 1)
            {
                LoadDepartmentData(this.cmbType.SelectedIndex);
            }
            else if (this.showType == 2)
            {
                LoadGroupData(this.cmbType.SelectedIndex);
            }
        }
        #endregion //Event
    }
}
