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

        #region Method
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
                int nowYear = DateTime.Now.Year;

                for (int i = nowYear; i >= 2010; i--)
                    this.cmbYear.Properties.Items.Add(i.ToString() + "年");

                this.bsWaterExpense.DataSource = BusinessFactory<WaterExpenseBusiness>.Instance.FindAll();
            }
        }
       
        /// <summary>
        /// 年度选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {            
            int year = Convert.ToInt32(this.cmbYear.SelectedItem.ToString().Substring(0, 4));

            if (this.currentAccount == null)
                return;

            var waterExpenses= BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(this.currentAccount.Id, year).ToList();
            waterChart.SetMainSeries(this.cmbYear.SelectedItem.ToString(), waterExpenses);
        }
        #endregion //Event
    }
}
