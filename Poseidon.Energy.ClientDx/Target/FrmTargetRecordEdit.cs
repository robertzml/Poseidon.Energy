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
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 编辑计划指标记录窗体
    /// </summary>
    public partial class FrmTargetRecordEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联记录
        /// </summary>
        private TargetRecord currentRecord;

        /// <summary>
        /// 当前关联指标计划
        /// </summary>
        private Target currentTarget;
        #endregion //Field

        #region Constructor
        public FrmTargetRecordEdit(string id)
        {
            InitializeComponent();

            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentRecord = BusinessFactory<TargetRecordBusiness>.Instance.FindById(id);
            this.currentTarget = BusinessFactory<TargetBusiness>.Instance.FindById(this.currentRecord.TargetId);
        }

        protected override void InitForm()
        {
            DisplayInfo();
            base.InitForm();
        }

        /// <summary>
        /// 显示指标记录信息
        /// </summary>
        private void DisplayInfo()
        {
            this.bsTarget.DataSource = BusinessFactory<TargetBusiness>.Instance.FindAll().Where(r => r.Id != this.currentRecord.TargetId).ToList();

            this.txtDepartmentName.Text = BusinessFactory<DepartmentBusiness>.Instance.FindById(this.currentRecord.DepartmentId).Name;
            ControlUtil.BindDictToComboBox(this.cmbType, typeof(TargetRecord), "Type");
            this.cmbType.EditValue = this.currentRecord.Type;
            this.txtFinance.Text = this.currentRecord.Finance;
            this.spSchoolTake.Value = this.currentRecord.SchoolTake;
            this.spSelfTake.Value = this.currentRecord.SelfTake;
            this.txtRemark.Text = this.currentRecord.Remark;
            this.txtPlanQuantum.Text = this.currentRecord.PlanQuantum.ToString();
            this.txtPlanAmount.Text = this.currentRecord.PlanAmount.ToString();

            this.stGrid.DataSource = this.currentRecord.StaffTarget;
            this.atGrid.DataSource = this.currentRecord.AllowanceTarget;
        }

        /// <summary>
        /// 更新指标总数
        /// </summary>
        private void UpdateTotalAmount()
        {
            var record = BusinessFactory<TargetRecordBusiness>.Instance.FindById(this.currentRecord.Id);
            this.txtPlanQuantum.Text = record.PlanQuantum.ToString();
            this.txtPlanAmount.Text = record.PlanAmount.ToString();
        }

        /// <summary>
        /// 导入选中部门人数记录
        /// </summary>
        /// <param name="populationId">人数统计ID</param>
        /// <param name="departmentId">部门ID</param>
        private void LoadStaffRecord(string populationId, string departmentId)
        {
            var staff = BusinessFactory<TargetRecordBusiness>.Instance.ImportPopulation(populationId, departmentId);

            foreach (var item in staff)
            {
                if (this.stGrid.DataSource.Any(r => r.Code == item.Code))
                {
                    var s = stGrid.DataSource.Find(r => r.Code == item.Code);
                    s.Number = item.Number;
                }
                else
                    this.stGrid.DataSource.Add(item);
            }

            this.stGrid.UpdateBindingData();
        }

        /// <summary>
        /// 导入选中部门经费记录
        /// </summary>
        /// <param name="fundId">经费统计ID</param>
        /// <param name="departmentId">部门ID</param>
        private void LoadFundRecord(string fundId, string departmentId)
        {
            var fund = BusinessFactory<TargetRecordBusiness>.Instance.ImportFund(fundId, departmentId);

            foreach (var item in fund)
            {
                if (this.atGrid.DataSource.Any(r => r.Code == item.Code))
                {
                    var s = atGrid.DataSource.Find(r => r.Code == item.Code);
                    s.Factor = item.Factor;
                }
                else
                    this.atGrid.DataSource.Add(item);
            }

            this.atGrid.UpdateBindingData();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckStaffTarget()
        {
            string errorMessage = "";

            foreach (var item in this.stGrid.DataSource)
            {
                if (string.IsNullOrEmpty(item.Name))
                {
                    errorMessage = "指标名称不能为空";
                    return new Tuple<bool, string>(false, errorMessage);
                }
                if (string.IsNullOrEmpty(item.Code))
                {
                    errorMessage = "指标代码不能为空";
                    return new Tuple<bool, string>(false, errorMessage);
                }
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckAllowanceTarget()
        {
            string errorMessage = "";

            foreach (var item in this.atGrid.DataSource)
            {
                if (string.IsNullOrEmpty(item.Name))
                {
                    errorMessage = "指标名称不能为空";
                    return new Tuple<bool, string>(false, errorMessage);
                }
                if (string.IsNullOrEmpty(item.Code))
                {
                    errorMessage = "指标代码不能为空";
                    return new Tuple<bool, string>(false, errorMessage);
                }
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (this.cmbType.EditValue == null)
            {
                errorMessage = "指标类型不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(TargetRecord entity)
        {
            entity.Type = Convert.ToInt32(this.cmbType.EditValue);
            entity.Finance = this.txtFinance.Text;
            entity.SchoolTake = this.spSchoolTake.Value;
            entity.SelfTake = this.spSelfTake.Value;
            entity.Remark = this.txtRemark.Text;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 选择参考指标计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luReferenceTarget_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luReferenceTarget.EditValue == null)
                return;

            var tid = this.luReferenceTarget.EditValue.ToString();

            var record = BusinessFactory<TargetRecordBusiness>.Instance.FindByDepartment(tid, this.currentRecord.DepartmentId, this.currentRecord.Type);
            if (record != null)
            {
                this.txtRefTotalQuantum.Text = record.PlanQuantum.ToString();
                this.txtRefTotalAmount.Text = record.PlanAmount.ToString();
                this.refStGrid.DataSource = record.StaffTarget;
                this.refAtGrid.DataSource = record.AllowanceTarget;
            }
        }

        /// <summary>
        /// 导入人数记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportStaff_Click(object sender, EventArgs e)
        {
            LoadStaffRecord(this.currentTarget.PopulationId, this.currentRecord.DepartmentId);
        }

        /// <summary>
        /// 计算人数指标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcStaff_Click(object sender, EventArgs e)
        {
            this.stGrid.CloseEditor();
            this.stGrid.UpdateTotal();
        }

        /// <summary>
        /// 保存人数指标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            this.stGrid.CloseEditor();

            var input = CheckStaffTarget();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                var result = BusinessFactory<TargetRecordBusiness>.Instance.UpdateStaffTarget(this.currentRecord.Id, this.stGrid.DataSource, this.currentUser);

                if (result)
                {
                    UpdateTotalAmount();
                    MessageUtil.ShowInfo("保存成功");
                }
                else
                    MessageUtil.ShowInfo("保存失败");

            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }

        /// <summary>
        /// 导入经费记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportFund_Click(object sender, EventArgs e)
        {
            LoadFundRecord(this.currentTarget.FundId, this.currentRecord.DepartmentId);
        }

        /// <summary>
        /// 计算补贴指标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcAllowance_Click(object sender, EventArgs e)
        {
            this.atGrid.CloseEditor();
            this.atGrid.UpdateTotal();
        }

        /// <summary>
        /// 保存补贴指标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAllowance_Click(object sender, EventArgs e)
        {
            this.atGrid.CloseEditor();

            var input = CheckAllowanceTarget();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                var result = BusinessFactory<TargetRecordBusiness>.Instance.UpdateAllowanceTarget(this.currentRecord.Id, this.atGrid.DataSource, this.currentUser);

                if (result)
                {
                    UpdateTotalAmount();
                    MessageUtil.ShowInfo("保存成功");
                }
                else
                    MessageUtil.ShowInfo("保存失败");
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            TargetRecord entity = BusinessFactory<TargetRecordBusiness>.Instance.FindById(this.currentRecord.Id);
            SetEntity(entity);

            try
            {
                var result = BusinessFactory<TargetRecordBusiness>.Instance.Update(entity, this.currentUser);

                if (result)
                {
                    MessageUtil.ShowInfo("保存成功");
                    this.Close();
                }
                else
                    MessageUtil.ShowInfo("保存失败");
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
