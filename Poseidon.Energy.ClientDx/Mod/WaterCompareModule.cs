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
        }

        /// <summary>
        /// 设置图标系列
        /// </summary>
        /// <param name="account">账户</param>
        private void SetSeries(ExpenseAccount account)
        {
            var yeartext = this.ccbYears.EditValue.ToString();

            if (string.IsNullOrEmpty(yeartext))
                return;

            string[] years = yeartext.Split(',');

            for (int i = 0; i < years.Length; i++)
            {
                int year = Convert.ToInt32(years[i].Trim().Substring(0, 4));
                string title = years[i].Trim();
                int type = this.cmbDataType.SelectedIndex;

                var waterExpenses = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(account.Id, year).ToList();

                this.waterChart.AddSeries(title, waterExpenses, type);

            }
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
            waterChart.Clear();

            var yeartext = this.ccbYears.EditValue.ToString();

            if (string.IsNullOrEmpty(yeartext))
                return;

            SetSeries(this.currentAccount);
        }

        /// <summary>
        /// 显示类型选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            waterChart.Clear();
            SetSeries(this.currentAccount);
        }
        #endregion //Event
    }
}
