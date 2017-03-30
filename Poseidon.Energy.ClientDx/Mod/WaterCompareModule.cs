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
    using Poseidon.Base.System;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 用水支出对比组件
    /// </summary>
    public partial class WaterCompareModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 关联支出账户
        /// </summary>
        private ExpenseAccount currentAccount;
        #endregion //Field

        #region Constructor
        public WaterCompareModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化控件
        /// </summary>
        private void InitControls()
        {
            int nowYear = DateTime.Now.Year;

            for (int i = nowYear; i >= 2010; i--)
            {
                this.ccbYears.Properties.Items.Add(i.ToString() + "年");
            }

            this.cmbDataType.SelectedIndex = 0;
            this.energyChart.SetChartTitle("年度用水支出对比");
        }

        /// <summary>
        /// 加载支出数据
        /// </summary>
        /// <param name="account">账户</param>
        private void LoadData(ExpenseAccount account)
        {
            var yeartext = this.ccbYears.EditValue.ToString();

            if (string.IsNullOrEmpty(yeartext))
                return;

            var years = yeartext.Split(',').ToList();

            years.ForEach(r => r.Trim());
            years.Sort();

            for (int i = 0; i < years.Count; i++)
            {
                int year = Convert.ToInt32(years[i].Trim().Substring(0, 4));
                string title = years[i].Trim();
                int type = this.cmbDataType.SelectedIndex;
                bool showLabel = this.chkShowLabel.Checked;

                var waterExpenses = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(account.Id, year).ToList();

                AddSeries(title, waterExpenses, type, showLabel);
            }
        }

        /// <summary>
        /// 添加图表系列
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="data">数据</param>
        /// <param name="type">显示数据类型</param>
        /// <param name="showLabel">是否显示数值标签</param>
        private void AddSeries(string title, List<WaterExpense> data, int type, bool showLabel)
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

            this.energyChart.AddSeries(title, points, unit, showLabel);
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置关联支出账户
        /// </summary>
        /// <param name="account">支出账户</param>
        public void SetAccount(ExpenseAccount account)
        {
            this.currentAccount = account;
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.ccbYears.EditValue = "";
            this.energyChart.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterCompareMod_Load(object sender, EventArgs e)
        {
            if (!ControlUtil.IsInDesignMode())
            {
                InitControls();
            }
        }

        /// <summary>
        /// 年度选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ccbYears_EditValueChanged(object sender, EventArgs e)
        {
            this.energyChart.Clear();

            var yeartext = this.ccbYears.EditValue.ToString();

            if (string.IsNullOrEmpty(yeartext))
                return;

            LoadData(this.currentAccount);
        }

        /// <summary>
        /// 显示类型选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.energyChart.Clear();
            LoadData(this.currentAccount);
        }

        /// <summary>
        /// 是否显示数值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkShowLabel_CheckedChanged(object sender, EventArgs e)
        {
            this.energyChart.SetLabelVisible(this.chkShowLabel.Checked);
        }
        #endregion //Event
    }
}
