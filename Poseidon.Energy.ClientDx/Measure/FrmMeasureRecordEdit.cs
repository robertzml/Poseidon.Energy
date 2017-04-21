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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 能耗数据录入窗体
    /// </summary>
    public partial class FrmMeasureRecordEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联能耗计量
        /// </summary>
        private Measure currentMeasure;
        #endregion //Field

        #region Constructor
        public FrmMeasureRecordEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentMeasure = BusinessFactory<MeasureBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            var groups = BusinessFactory<GroupBusiness>.Instance.FindWithChildrenByCode(EnergyConstant.MeasureDepartmentGroupCode).ToList();
            this.measureGroup.DataSource = groups;

            var refMeasures = BusinessFactory<MeasureBusiness>.Instance.FindByEnergyType(this.currentMeasure.EnergyType).Where(r => r.Id != this.currentMeasure.Id);
            this.bsMeasure.DataSource = refMeasures;

            DisplayInfo(this.currentMeasure);

            base.InitForm();
        }

        /// <summary>
        /// 显示能耗计量信息
        /// </summary>
        /// <param name="entity">能耗计量</param>
        private void DisplayInfo(Measure entity)
        {
            this.txtBelongTime.Text = entity.BelongTime;
            this.txtEnergyType.Text = ((EnergyType)entity.EnergyType).DisplayName();
            this.txtStartTime.Text = entity.StartTime.ToDateString();
            this.txtEndTime.Text = entity.EndTime.ToDateString();
        }

        /// <summary>
        /// 载入部门能耗表格
        /// </summary>
        /// <param name="group"></param>
        private void LoadDepartments(Group group)
        {
            var departments = BusinessFactory<DepartmentBusiness>.Instance.FindInGroup(group.Code, true);
            var records = BusinessFactory<MeasureRecordBusiness>.Instance.FindByMeasureId(this.currentMeasure.Id);

            List<MeasureRecord> data = new List<MeasureRecord>();

            foreach (var item in departments)
            {
                var record = records.SingleOrDefault(r => r.DepartmentId == item.Id);
                if (record != null)
                    data.Add(record);
            }

            this.mrGrid.DataSource = data;

            this.txtDepartmentCount.Text = data.Count.ToString();
            this.txtTotalQuantum.Text = data.Sum(r => r.Quantum).ToString();
        }

        /// <summary>
        /// 设置对象
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(List<MeasureRecord> entity)
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
        private void measureGroup_GroupSelected(object arg1, EventArgs arg2)
        {
            var group = this.measureGroup.GetCurrentSelect();

            this.txtGroupName.Text = group.Name;

            LoadDepartments(group);
        }

        /// <summary>
        /// 参考记录选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luRefMeasure_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luRefMeasure.EditValue == null)
                return;

            Measure select = this.luRefMeasure.GetSelectedDataRow() as Measure;
            var refRecords = BusinessFactory<MeasureRecordBusiness>.Instance.FindByMeasureId(select.Id).ToList();

            this.txtRefDepartmentCount.Text = refRecords.Count.ToString();
            this.txtRefTotalQuantum.Text = refRecords.Sum(r => r.Quantum).ToString();
            this.mrGrid.SetReference(refRecords);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.mrGrid.CloseEditor();

            var data = this.mrGrid.DataSource;
            SetEntity(data);

            try
            {
                BusinessFactory<MeasureRecordBusiness>.Instance.Update(data, this.currentUser);

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
