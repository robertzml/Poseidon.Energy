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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 指标趋势组件
    /// </summary>
    public partial class TargetTrendModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联部门
        /// </summary>
        private Department currentDepartment;

        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;

        /// <summary>
        /// 指标类型
        /// </summary>
        private int targetType;
        #endregion //Field

        #region Constructor
        public TargetTrendModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入数据
        /// </summary>
        /// <param name="department"></param>
        /// <param name="targetType"></param>
        private async void LoadData(Department department, int targetType)
        {
            var task = Task.Run(() =>
            {
                var records = BusinessFactory<TargetRecordBusiness>.Instance.FindByDepartment(department.Id, targetType);

                List<SeriesPoint> points = new List<SeriesPoint>();
                List<SeriesPoint> linePoints = new List<SeriesPoint>();

                foreach (var item in records)
                {
                    var target = BusinessFactory<TargetBusiness>.Instance.FindById(item.TargetId);

                    var point = new SeriesPoint();
                    point.Argument = target.Year.ToString() + "年";
                    point.Values = new double[] { Convert.ToDouble(item.PlanQuantum) };

                    points.Add(point);

                    var point2 = new SeriesPoint();
                    point2.Argument = target.Year.ToString() + "年";
                    point2.Values = new double[] { Convert.ToDouble(item.PlanAmount) };

                    linePoints.Add(point2);
                }

                var data = new
                {
                    BarPoint = points,
                    LinePoint = linePoints
                };
                return data;
            });

            var chartPoints = await task;

            this.trendChart.SetChartTitle($"{department.ShortName}历年指标情况");

            if (targetType == 1)
            {
                this.trendChart.SetBar(chartPoints.BarPoint, "计划用电量(度)");
                this.trendChart.SetLine(chartPoints.LinePoint, "计划金额(元)");
            }
            else if (targetType == 2)
            {
                this.trendChart.SetBar(chartPoints.BarPoint, "计划用水量(吨)");
                this.trendChart.SetLine(chartPoints.LinePoint, "计划金额(元)");
            }
        }

        private async void LoadData(Group group, int targetType)
        {
            var targets = BusinessFactory<TargetBusiness>.Instance.FindAll();            
            var groupItems = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置部门
        /// </summary>
        /// <param name="department">部门</param>
        /// <param name="targetType">指标类型</param>
        public void SetDepartment(Department department, int targetType)
        {
            this.currentDepartment = department;
            this.targetType = targetType;

            LoadData(department, targetType);
        }
        #endregion //Method
    }
}
