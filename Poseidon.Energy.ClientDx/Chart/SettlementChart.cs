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
    /// 用能结算图表
    /// </summary>
    public partial class SettlementChart : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public SettlementChart()
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
        /// 设置指标柱状图
        /// </summary>
        /// <param name="points">数据点</param>
        /// <param name="caption">图例</param>
        public void SetTarget(List<SeriesPoint> points, string caption)
        {
            this.chartMain.Series[0].Points.Clear();
            this.chartMain.Series[0].Points.AddRange(points.ToArray());
            this.chartMain.Series[0].Name = caption;
            this.chartMain.Series[0].LegendText = caption;
        }

        /// <summary>
        /// 设置实际柱状图
        /// </summary>
        /// <param name="points">数据点</param>
        /// <param name="caption">图例</param>
        public void SetReal(List<SeriesPoint> points, string caption)
        {
            this.chartMain.Series[1].Points.Clear();
            this.chartMain.Series[1].Points.AddRange(points.ToArray());
            this.chartMain.Series[1].Name = caption;
            this.chartMain.Series[1].LegendText = caption;
        }

        /// <summary>
        /// 设置偏离度折线图
        /// </summary>
        /// <param name="points">数据点</param>
        /// <param name="caption">图例</param>
        public void SetLine(List<SeriesPoint> points, string caption)
        {
            this.chartMain.Series[2].Points.Clear();
            this.chartMain.Series[2].Points.AddRange(points.ToArray());
            this.chartMain.Series[2].Name = caption;
            this.chartMain.Series[2].LegendText = caption;
        }
        #endregion //Method
    }
}
