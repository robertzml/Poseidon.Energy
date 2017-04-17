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
    using Poseidon.Core.DL;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 用能结算比较表格
    /// </summary>
    public partial class SettlementCompareGridModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;

        /// <summary>
        /// 当前关联部门
        /// </summary>
        private Department currentDepartment;

        /// <summary>
        /// 能源类型
        /// </summary>
        private EnergyType energyType;

        /// <summary>
        /// 能源比较对象
        /// </summary>
        private List<EnergyCompare> compareData;

        /// <summary>
        /// 显示类型  1:部门  2:分组
        /// </summary>
        private int showType;
        #endregion //Field

        #region Constructor
        public SettlementCompareGridModule()
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
            var settlements = BusinessFactory<SettlementBusiness>.Instance.FindAll();

            this.bsSettlement.DataSource = settlements;
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            this.compareData = new List<EnergyCompare>();

            EnergyCompare item = new EnergyCompare();
            item.Month = this.currentDepartment.Name;
            item.Include = true;
            this.compareData.Add(item);

            this.compareGrid.DataSource = compareData;
            this.compareGrid.SetBelongTimeTitle("部门名称");
        }

        /// <summary>
        /// 载入部门结算数据
        /// </summary>
        /// <param name="settlement">能源结算</param>
        /// <param name="index">系列</param>
        private void LoadDepartmentData(Settlement settlement, int index)
        {
            var record = BusinessFactory<SettlementRecordBusiness>.Instance.FindByDepartment(settlement.Id, this.currentDepartment.Id, this.energyType);
            if (record == null)
                return;

            var data = this.compareData[0];
            if (index == 1)
            {
                data.QuantumFirst = record.Quantum;
                data.AmountFirst = record.Amount;
            }
            else
            {
                data.QuantumSecond = record.Quantum;
                data.AmountSecond = record.Amount;
            }

            if (this.energyType == EnergyType.Electric)
            {
                this.compareGrid.SetTitle(index, settlement.BelongTime + "用电量(度)", settlement.BelongTime + "用电金额(元)");
            }
            else
            {
                this.compareGrid.SetTitle(index, settlement.BelongTime + "用水量(吨)", settlement.BelongTime + "用水金额(元)");
            }
            this.compareGrid.UpdateBindingData();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置部门
        /// </summary>
        /// <param name="department">部门</param>
        /// <param name="energyType">能源类型</param>
        public void SetDepartment(Department department, EnergyType energyType)
        {
            this.currentDepartment = department;
            this.energyType = energyType;
            this.showType = 1;

            InitControls();
            InitData();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 选择1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luFirst_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luFirst.EditValue == null)
                return;

            if (this.showType == 1)
            {
                var settlement = this.luFirst.GetSelectedDataRow() as Settlement;
                LoadDepartmentData(settlement, 1);
            }
        }

        /// <summary>
        /// 选择2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luSecond_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luSecond.EditValue == null)
                return;

            if (this.showType == 1)
            {
                var settlement = this.luSecond.GetSelectedDataRow() as Settlement;
                LoadDepartmentData(settlement, 2);
            }
        }

        /// <summary>
        /// 显示用量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkQuantum_CheckedChanged(object sender, EventArgs e)
        {
            this.compareGrid.ShowQuantum(this.chkQuantum.Checked);
        }

        /// <summary>
        /// 显示金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkAmount_CheckedChanged(object sender, EventArgs e)
        {
            this.compareGrid.ShowAmount(this.chkAmount.Checked);
        }
        #endregion //Event
    }
}
