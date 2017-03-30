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
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 用水支出比较表格控件
    /// </summary>
    public partial class WaterCompareGridModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 起始年份
        /// </summary>
        private int startYear = 2012;

        /// <summary>
        /// 关联账户
        /// </summary>
        private ExpenseAccount currentAccount;

        /// <summary>
        /// 能源比较对象
        /// </summary>
        private List<EnergyCompare> compareData;
        #endregion //Field

        #region Constructor
        public WaterCompareGridModule()
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

            for (int i = nowYear; i >= startYear; i--)
            {
                this.cmbFirst.Properties.Items.Add(i.ToString() + "年");
                this.cmbSecond.Properties.Items.Add(i.ToString() + "年");
            }
        }

        /// <summary>
        /// 初始化比较数据
        /// </summary>
        private void InitCompareData()
        {
            this.compareData = new List<EnergyCompare>();
            for (int i = 1; i <= 12; i++)
            {
                EnergyCompare ec = new EnergyCompare();
                ec.Include = true;
                ec.Month = i.ToString() + "月";

                this.compareData.Add(ec);
            }

            this.energyGrid.DataSource = this.compareData;
        }

        /// <summary>
        /// 设置比较数据
        /// </summary>
        /// <param name="year"></param>
        /// <param name="index"></param>
        private void SetCompare(int year, int index)
        {
            var waterExpenses = BusinessFactory<WaterExpenseBusiness>.Instance.FindYearByAccount(this.currentAccount.Id, year).ToList();

            if (index == 1)
            {
                this.compareData.ForEach(r => r.QuantumFirst = 0);
                this.compareData.ForEach(r => r.AmountFirst = 0);
            }
            else
            {
                this.compareData.ForEach(r => r.QuantumSecond = 0);
                this.compareData.ForEach(r => r.AmountSecond = 0);
            }

            foreach (var item in waterExpenses)
            {
                var find = this.compareData.Find(r => r.Month == string.Format("{0}月", item.BelongDate.Month));

                if (index == 1)
                {
                    find.QuantumFirst = item.TotalQuantity;
                    find.AmountFirst = item.TotalAmount;
                }
                else if (index == 2)
                {
                    find.QuantumSecond = item.TotalQuantity;
                    find.AmountSecond = item.TotalAmount;
                }
            }

            this.energyGrid.SetTitle(index, year.ToString() + "年用水量(吨)", year.ToString() + "年用水金额(元)");
            this.energyGrid.UpdateBindingData();
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
        private void WaterCompareGridModule_Load(object sender, EventArgs e)
        {
            if (!ControlUtil.IsInDesignMode())
            {
                InitControls();
                InitCompareData();
            }
        }

        /// <summary>
        /// 选择数据1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbFirst.SelectedIndex == -1)
                return;

            int year = Convert.ToInt32(this.cmbFirst.SelectedItem.ToString().Substring(0, 4));
            SetCompare(year, 1);
        }

        /// <summary>
        /// 选择数据2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbSecond.SelectedIndex == -1)
                return;

            int year = Convert.ToInt32(this.cmbSecond.SelectedItem.ToString().Substring(0, 4));
            SetCompare(year, 2);
        }

        /// <summary>
        /// 显示用量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkQuantum_CheckedChanged(object sender, EventArgs e)
        {
            this.energyGrid.ShowQuantum(this.chkQuantum.Checked);
        }

        /// <summary>
        /// 显示金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkAmount_CheckedChanged(object sender, EventArgs e)
        {
            this.energyGrid.ShowAmount(this.chkAmount.Checked);
        }
        #endregion //Event
    }
}
