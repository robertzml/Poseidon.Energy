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
    using DevExpress.XtraCharts;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 能源比较图表
    /// </summary>
    /// <remarks>
    /// X轴为月份，Y轴为数据
    /// </remarks>
    public partial class EnergyCompareChart : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        CrosshairFreePosition crosshairPosition = new CrosshairFreePosition();
        #endregion //Field

        #region Constructor
        public EnergyCompareChart()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置图表标题
        /// </summary>
        /// <param name="text"></param>
        public void SetChartTitle(string text)
        {
            this.chartMain.Titles[0].Text = text;
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.chartMain.Series.Clear();
        }

        /// <summary>
        /// 添加系列
        /// </summary>
        /// <param name="legendTest">图例标题</param>
        /// <param name="points">数据点</param>
        /// <param name="unit">Y轴单位</param>
        public void AddSeries(string legendTest, List<SeriesPoint> points, string unit)
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
        #endregion //Method

        #region Event
        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuPrint_Click(object sender, EventArgs e)
        {
            this.chartMain.ShowRibbonPrintPreview();
        }
        #endregion //Event
    }
}
