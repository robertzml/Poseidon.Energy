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

    /// <summary>
    /// 用能趋势图
    /// </summary>
    public partial class EnergyTrendChart : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public EnergyTrendChart()
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
        /// 设置用量柱状图
        /// </summary>
        /// <param name="points">数据点</param>
        /// <param name="caption">图例</param>
        public void SetBar(List<SeriesPoint> points, string caption)
        {
            this.chartMain.Series[0].Points.Clear();
            this.chartMain.Series[0].Points.AddRange(points.ToArray());
            this.chartMain.Series[0].Name = caption;
            this.chartMain.Series[0].LegendText = caption;
        }

        /// <summary>
        /// 设置金额折线图
        /// </summary>
        /// <param name="points">数据点</param>
        /// <param name="caption">图例</param>
        public void SetLine(List<SeriesPoint> points, string caption)
        {
            this.chartMain.Series[1].Points.Clear();
            this.chartMain.Series[1].Points.AddRange(points.ToArray());
            this.chartMain.Series[1].Name = caption;
            this.chartMain.Series[1].LegendText = caption;
        }

        /// <summary>
        /// 是否显示折线图
        /// </summary>
        /// <param name="visible"></param>
        public void ShowLine(bool visible)
        {
            this.chartMain.Series[1].Visible = visible;
            XYDiagram diagram = this.chartMain.Diagram as XYDiagram;
            diagram.SecondaryAxesY[0].Visibility = visible ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        }
        #endregion //Method
    }
}
