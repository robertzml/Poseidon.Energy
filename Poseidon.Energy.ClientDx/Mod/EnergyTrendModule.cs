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
    using Poseidon.Core.Utility;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 能耗趋势组件
    /// </summary>
    public partial class EnergyTrendModule : UserControl
    {
        #region Field
        /// <summary>
        /// 当前关联部门
        /// </summary>
        private Department currentDepartment;

        /// <summary>
        /// 能源类型
        /// </summary>
        private EnergyType energyType;

        private int startYear = 2011;

        private int nowYear;
        #endregion //Field

        #region Constructor
        public EnergyTrendModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入数据
        /// </summary>
        /// <param name="period">0:年度  1:季度</param>
        /// <param name="showAmount">是否显示金额</param>
        private async void LoadData(int period, bool showAmount)
        {
            var task = Task.Run(() =>
            {
                List<SeriesPoint> points = new List<SeriesPoint>();
                List<SeriesPoint> linePoints = new List<SeriesPoint>();

                if (period == 0)
                {
                    for (int i = startYear; i <= nowYear; i++)
                    {
                        var item = BusinessFactory<SettlementBusiness>.Instance.GetDepartmentSummary(i, energyType, currentDepartment);
                        if (item != null)
                        {
                            var point = new SeriesPoint();
                            point.Argument = item.Year.ToString() + "年";
                            point.Values = new double[] { Convert.ToDouble(item.SettleQuantum) };

                            points.Add(point);

                            var point2 = new SeriesPoint();
                            point2.Argument = item.Year.ToString() + "年";
                            point2.Values = new double[] { Convert.ToDouble(item.SettleAmount) };

                            linePoints.Add(point2);
                        }
                    }
                }
                else if (period == 1)
                {
                    var settlements = BusinessFactory<SettlementBusiness>.Instance.FindAll().Reverse();
                    foreach (var settlement in settlements)
                    {
                        var record = BusinessFactory<SettlementRecordBusiness>.Instance.FindByDepartment(settlement.Id, currentDepartment.Id, energyType);
                        if (record == null)
                            continue;

                        var point = new SeriesPoint();
                        point.Argument = settlement.BelongTime;
                        point.Values = new double[] { Convert.ToDouble(record.Quantum) };

                        points.Add(point);

                        var point2 = new SeriesPoint();
                        point2.Argument = settlement.BelongTime;
                        point2.Values = new double[] { Convert.ToDouble(record.Amount) };

                        linePoints.Add(point2);
                    }
                }

                var data = new
                {
                    BarPoint = points,
                    LinePoint = linePoints
                };
                return data;
            });

            var chartPoints = await task;

            string energyPostfix = "";
            if (this.energyType == EnergyType.Electric)
                energyPostfix = "用电量(度)";
            else if (this.energyType == EnergyType.Water)
                energyPostfix = "用水量(吨)";

            if (period == 0)
            {
                this.trendChart.SetChartTitle(string.Format("{0}年度用能", currentDepartment.ShortName));
            }
            else if (period == 1)
            {
                this.trendChart.SetChartTitle(string.Format("{0}季度用能", currentDepartment.ShortName));
            }

            this.trendChart.SetBar(chartPoints.BarPoint, energyPostfix);

            if (showAmount)
            {
                this.trendChart.SetLine(chartPoints.LinePoint, "金额(元)");
            }
            this.trendChart.ShowLine(showAmount);
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

            LoadData(this.cmbPeriod.SelectedIndex, this.chkShowAmount.Checked);
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 周期选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(this.cmbPeriod.SelectedIndex, this.chkShowAmount.Checked);
        }

        /// <summary>
        /// 是否显示金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkShowAmount_CheckedChanged(object sender, EventArgs e)
        {
            LoadData(this.cmbPeriod.SelectedIndex, this.chkShowAmount.Checked);
        }
        #endregion //Event
    }
}
