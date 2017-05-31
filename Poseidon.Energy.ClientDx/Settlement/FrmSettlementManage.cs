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
    using Poseidon.Common;
    using Poseidon.Core.Utility;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 能源结算管理窗体
    /// </summary>
    public partial class FrmSettlementManage : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前选择结算
        /// </summary>
        private Settlement currentSettlement;
        #endregion //Field

        #region Constructor
        public FrmSettlementManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadSettlements();
            base.InitForm();
        }

        /// <summary>
        /// 载入结算记录
        /// </summary>
        private void LoadSettlements()
        {
            var data = BusinessFactory<SettlementBusiness>.Instance.FindAll();
            this.bsSettlement.DataSource = data;
        }

        /// <summary>
        /// 显示信息
        /// </summary>
        /// <param name="entity">能源结算信息</param>
        private void DisplayInfo(Settlement entity)
        {
            this.txtName.Text = entity.Name;
            this.txtYear.Text = entity.Year.ToString();
            this.txtBelongTime.Text = entity.BelongTime;
            this.txtType.Text = ((SettlementType)entity.Type).DisplayName();
            this.txtCreateUser.Text = entity.CreateBy.Name;
            this.txtCreateTime.Text = entity.CreateBy.Time.ToDateTimeString();
            this.txtEditUser.Text = entity.UpdateBy.Name;
            this.txtEditTime.Text = entity.UpdateBy.Time.ToDateTimeString();
            this.txtRemark.Text = entity.Remark;

            var target = BusinessFactory<TargetBusiness>.Instance.FindById(entity.TargetId);
            this.txtTargetName.Text = target.Name;

            if (string.IsNullOrEmpty(entity.PreviousId))
                this.txtPrevious.Text = "首次结算";
            else
            {
                var previous = BusinessFactory<SettlementBusiness>.Instance.FindById(entity.PreviousId);
                this.txtPrevious.Text = previous.Name;
            }

            this.electricRecordGrid.DataSource = BusinessFactory<SettlementRecordBusiness>.Instance.FindBySettlement(entity.Id, EnergyType.Electric).ToList();
            this.electricRecordGrid.SetEnergyType(EnergyType.Electric);

            this.waterRecordGrid.DataSource = BusinessFactory<SettlementRecordBusiness>.Instance.FindBySettlement(entity.Id, EnergyType.Water).ToList();
            this.waterRecordGrid.SetEnergyType(EnergyType.Water);
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 选择能源结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbSettlements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbSettlements.SelectedItem == null)
                return;

            this.currentSettlement = this.lbSettlements.SelectedItem as Settlement;
            if (this.currentSettlement == null)
                return;

            DisplayInfo(this.currentSettlement);
        }

        /// <summary>
        /// 添加结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmSettlementAdd));
            LoadSettlements();
        }

        /// <summary>
        /// 编辑结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.lbSettlements.SelectedItem == null || this.currentSettlement == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmSettlementEdit), new object[] { this.currentSettlement.Id });
            LoadSettlements();
        }

        /// <summary>
        /// 删除结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lbSettlements.SelectedItem == null || this.currentSettlement == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否确认删除选中能源结算") == DialogResult.Yes)
            {
                try
                {
                    BusinessFactory<SettlementBusiness>.Instance.Delete(this.currentSettlement);
                    LoadSettlements();

                    MessageUtil.ShowInfo("删除成功");
                }
                catch (PoseidonException pe)
                {
                    MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
                }
            }
        }

        /// <summary>
        /// 选择部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (this.lbSettlements.SelectedItem == null || this.currentSettlement == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmSettlementSetDepartment), new object[] { this.currentSettlement.Id });
            LoadSettlements();
        }

        /// <summary>
        /// 添加结算记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (this.lbSettlements.SelectedItem == null || this.currentSettlement == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmSettlementRecordAdd), new object[] { this.currentSettlement.Id });
            LoadSettlements();
        }

        /// <summary>
        /// 登记结算数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecordEdit_Click(object sender, EventArgs e)
        {
            if (this.lbSettlements.SelectedItem == null || this.currentSettlement == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmSettlementRecordEdit), new object[] { this.currentSettlement.Id });
            LoadSettlements();
        }

        /// <summary>
        /// 编辑部门结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDepartmentEdit_Click(object sender, EventArgs e)
        {
            if (this.lbSettlements.SelectedItem == null || this.currentSettlement == null)
                return;

            if (tabRecord.SelectedTabPage == tabPageElectric)
            {
                var record = electricRecordGrid.GetCurrentSelect();
                if (record != null)
                {
                    ChildFormManage.ShowDialogForm(typeof(FrmSettlementDepartmentEdit), new object[] { record.DepartmentId, this.currentSettlement.Year, EnergyType.Electric });
                    LoadSettlements();
                }
            }
            else if (tabRecord.SelectedTabPage == tabPageWater)
            {
                var record = waterRecordGrid.GetCurrentSelect();
                if (record != null)
                {
                    ChildFormManage.ShowDialogForm(typeof(FrmSettlementDepartmentEdit), new object[] { record.DepartmentId, this.currentSettlement.Year, EnergyType.Water });
                    LoadSettlements();
                }
            }
        }
        #endregion //Event
    }
}
