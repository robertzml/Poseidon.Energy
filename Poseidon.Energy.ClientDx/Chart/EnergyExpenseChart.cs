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
    /// 能源支出图表控件
    /// </summary>
    public partial class EnergyExpenseChart : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// X轴只显示月份
        /// </summary>
        private bool showMonthTick = false;
        #endregion //Field

        #region Constructor
        public EnergyExpenseChart()
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
            this.bsEnergyExpense.DataSource = null;
        }

        /// <summary>
        /// 设置数据源
        /// </summary>
        /// <param name="data"></param>
        public void SetDataSource(List<EnergyExpense> data)
        {
            List<EnergyExpense> format = new List<EnergyExpense>();

            if (data.Count == 0)
                return;

            format.AddRange(data);
            var last = data.Max(r => r.BelongDate);
            for (int i = last.Month + 1; i <= 12; i++)
            {
                format.Add(new EnergyExpense
                {
                    BelongDate = new DateTime(last.Year, i, 1),
                    Amount = 0,
                    Quantum = 0
                });
            }

            this.bsEnergyExpense.DataSource = format.OrderBy(r => r.BelongDate).ToList();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnergyExpenseChart_Load(object sender, EventArgs e)
        {
            if (this.showMonthTick)
            {
                XYDiagram diagram = this.chartMain.Diagram as XYDiagram;
                diagram.AxisX.Label.TextPattern = "{A:M月}";
            }
            else
            {
                XYDiagram diagram = this.chartMain.Diagram as XYDiagram;
                diagram.AxisX.Label.TextPattern = "{A:yyyy年M月}";
            }
        }
        #endregion //Event

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
        }

        /// <summary>
        /// X轴显示月份
        /// </summary>
        [Description("X轴显示月份"), Category("界面"), Browsable(true)]
        public bool ShowMonthTick
        {
            get
            {
                return this.showMonthTick;
            }
            set
            {
                this.showMonthTick = value;
            }
        }
        #endregion //Property
    }
}
