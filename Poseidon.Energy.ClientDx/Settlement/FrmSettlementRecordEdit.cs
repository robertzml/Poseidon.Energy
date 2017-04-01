using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 编辑能源结算记录
    /// </summary>
    public partial class FrmSettlementRecordEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联能源结算
        /// </summary>
        private Settlement currentSettlement;
        #endregion //Field

        #region Constructor
        public FrmSettlementRecordEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentSettlement = BusinessFactory<SettlementBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            var groups = BusinessFactory<GroupBusiness>.Instance.FindWithChildrenByCode(EnergyConstant.SettlementDepartmentGroupCode).ToList();
            this.settlementGroup.DataSource = groups;

            this.bsMeasureElectric.DataSource = BusinessFactory<MeasureBusiness>.Instance.FindByYear(this.currentSettlement.Year, EnergyType.Electric);
            this.bsMeasureWater.DataSource = BusinessFactory<MeasureBusiness>.Instance.FindByYear(this.currentSettlement.Year, EnergyType.Water);

            this.electricRecordGrid.SetEnergyType(EnergyType.Electric);
            this.waterRecordGrid.SetEnergyType(EnergyType.Water);

            DisplayInfo(this.currentSettlement);

            base.InitForm();
        }

        /// <summary>
        /// 显示能源结算信息
        /// </summary>
        /// <param name="entity">能源结算</param>
        private void DisplayInfo(Settlement entity)
        {
            this.txtName.Text = entity.Name;
            this.txtBelongTime.Text = entity.BelongTime;
            this.txtType.Text = ((SettlementType)entity.Type).DisplayName();
            this.txtTarget.Text = BusinessFactory<TargetBusiness>.Instance.FindById(entity.TargetId).Name;

            if (string.IsNullOrEmpty(entity.PreviousId))
                this.txtPrevious.Text = "首次结算";
            else
                this.txtPrevious.Text = BusinessFactory<SettlementBusiness>.Instance.FindById(entity.PreviousId).Name;
        }

        /// <summary>
        /// 载入部门结算表格
        /// </summary>
        /// <param name="group"></param>
        private void LoadDepartments(Group group)
        {
            var departments = BusinessFactory<DepartmentBusiness>.Instance.FindInGroup(group.Code, true);

            var electricRecords = BusinessFactory<SettlementRecordBusiness>.Instance.FindBySettlement(this.currentSettlement.Id, EnergyType.Electric);
            var waterRecords = BusinessFactory<SettlementRecordBusiness>.Instance.FindBySettlement(this.currentSettlement.Id, EnergyType.Water);

            List<SettlementRecord> edata = new List<SettlementRecord>();
            List<SettlementRecord> wdata = new List<SettlementRecord>();

            foreach (var item in departments)
            {
                var erecord = electricRecords.SingleOrDefault(r => r.DepartmentId == item.Id);
                if (erecord != null)
                    edata.Add(erecord);

                var wrecord = waterRecords.SingleOrDefault(r => r.DepartmentId == item.Id);
                if (wrecord != null)
                    wdata.Add(wrecord);
            }

            this.electricRecordGrid.DataSource = edata;
            this.waterRecordGrid.DataSource = wdata;
        }

        /// <summary>
        /// 设置对象
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(List<SettlementRecord> entity)
        {
            foreach (var item in entity)
            {
                item.Remark = item.Remark ?? "";
            }
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 分组选择
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void settlementGroup_GroupSelected(object arg1, EventArgs arg2)
        {
            var group = this.settlementGroup.GetCurrentSelect();

            this.txtGroupName.Text = group.Name;

            LoadDepartments(group);
        }

        /// <summary>
        /// 选择参考用电计量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luMeasureElectric_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luMeasureElectric.EditValue == null)
                return;

            var measure = this.luMeasureElectric.GetSelectedDataRow() as Measure;

            var data = BusinessFactory<MeasureRecordBusiness>.Instance.FindByMeasureId(measure.Id).ToList();
            this.electricRecordGrid.SetReferenceMeasure(data);
        }

        /// <summary>
        /// 采用参考用量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUseRefElectricQuantum_Click(object sender, EventArgs e)
        {
            this.electricRecordGrid.UseRefQuantum();
        }

        /// <summary>
        /// 采用参考金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUseRefElectricAmount_Click(object sender, EventArgs e)
        {
            this.electricRecordGrid.UseRefAmount();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                this.electricRecordGrid.CloseEditor();
                var erecrods = this.electricRecordGrid.DataSource;
                SetEntity(erecrods);
                BusinessFactory<SettlementRecordBusiness>.Instance.Update(erecrods, this.currentUser);

                this.waterRecordGrid.CloseEditor();
                var wrecords = this.waterRecordGrid.DataSource;
                SetEntity(wrecords);
                BusinessFactory<SettlementRecordBusiness>.Instance.Update(wrecords, this.currentUser);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
