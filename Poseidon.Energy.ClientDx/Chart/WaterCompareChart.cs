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
        #region Constructor
        public WaterCompareChart()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        private void SetSeries(int index, string legendText, List<SeriesPoint> points)
        {
            this.chartMain.Series[index].LegendText = legendText;
            this.chartMain.Series[index].Points.Clear();            
            this.chartMain.Series[index].Points.AddRange(points.ToArray());
            this.chartMain.Update();
        }
        #endregion //Function

        #region Method
        public void SetMainSeries(string legendText,List<WaterExpense> data)
        {
            List<WaterExpense> format = new List<WaterExpense>();

            if (data.Count == 0)
                return;

            format.AddRange(data);
            var last = data.Max(r => r.BelongDate);
            for (int i = last.Month + 1; i <= 12; i++)
            {
                format.Add(new WaterExpense
                {
                    BelongDate = new DateTime(last.Year, i, 1),
                    TotalAmount = 0,
                    TotalQuantity = 0
                });
            }

            List<SeriesPoint> points = new List<SeriesPoint>();
            for(int i = 0; i < format.Count; i++)
            {
                SeriesPoint point = new SeriesPoint(format[i].BelongDate);
                point.Values = new double[] { Convert.ToDouble(format[i].TotalQuantity) };
                points.Add(point);
            }

            SetSeries(0, legendText, points);
        }
        #endregion //Method
    }
}
