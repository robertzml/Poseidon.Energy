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
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 用水支出对比图表
    /// </summary>
    public partial class WaterCompareChart : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        CrosshairFreePosition crosshairPosition = new CrosshairFreePosition();
        #endregion //Field

        #region Constructor
        public WaterCompareChart()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 添加系列
        /// </summary>
        /// <param name="legendTest">图例标题</param>
        /// <param name="points">数据点</param>
        /// <param name="unit">单位</param>
        private void AddSeries(string legendTest, List<SeriesPoint> points, string unit)
        {
            Series series = new Series(legendTest, ViewType.Bar);
            series.LegendText = legendTest;
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series.ArgumentScaleType = ScaleType.Qualitative;
            series.Points.AddRange(points.ToArray());
            series.CrosshairLabelPattern = "{S}{A}:{V}" + unit.ToString();

            var label = series.Label as SideBySideBarSeriesLabel;
            label.Position = BarSeriesLabelPosition.Top;

            this.chartMain.Series.Add(series);
            this.chartMain.Update();

            crosshairPosition.DockCorner = DockCorner.LeftTop;
            crosshairPosition.DockTarget = ((XYDiagram2D)chartMain.Diagram).DefaultPane;
            this.chartMain.CrosshairOptions.CommonLabelPosition = crosshairPosition;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 添加系列
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="data">数据</param>
        /// <param name="type">显示数据类型</param>
        public void AddSeries(string title, List<WaterExpense> data, int type)
        {
            List<SeriesPoint> points = new List<SeriesPoint>();
            string unit = "";
            for (int i = 0; i < data.Count; i++)
            {
                string month = string.Format("{0}月", data[i].BelongDate.Month);
                SeriesPoint point = new SeriesPoint();
                point.Argument = month;
                if (type == 0)
                {
                    point.Values = new double[] { Convert.ToDouble(data[i].TotalQuantity) };
                    unit = "吨";
                }
                else if (type == 1)
                {
                    point.Values = new double[] { Convert.ToDouble(data[i].TotalAmount) };
                    unit = "元";
                }
                points.Add(point);
            }

            AddSeries(title, points, unit);
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.chartMain.Series.Clear();
        }
        #endregion //Method
    }
}
