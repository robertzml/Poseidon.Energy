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
    using Poseidon.Energy.ClientDx.Model;

    /// <summary>
    /// 年度用能对比图表
    /// </summary>
    public partial class EnergyYearExpenseChart : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public EnergyYearExpenseChart()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置图表标题
        /// </summary>
        /// <param name="text">标题</param>
        public void SetChartTitle(string text)
        {
            this.chartMain.Titles[0].Text = text;
        }

        /// <summary>
        /// 设置图例标题
        /// </summary>
        /// <param name="index">序号</param>
        /// <param name="text">标题</param>
        public void SetSeriesLengedText(int index, string text)
        {
            this.chartMain.Series[index].LegendText = text;
        }
        #endregion //Method

        #region Property
        /// <summary>
        /// 数据源
        /// </summary>
        [Description("数据源")]
        public List<EnergyExpense> DataSource
        {
            get
            {
                return this.bsEnergyExpense.DataSource as List<EnergyExpense>;
            }
            set
            {
                this.bsEnergyExpense.DataSource = value;
            }
        }
        #endregion //Property
    }
}
