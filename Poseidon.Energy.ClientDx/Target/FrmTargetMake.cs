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
    /// 指标制定窗体
    /// </summary>
    public partial class FrmTargetMake : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前指标计划
        /// </summary>
        private Target currentTarget;
        #endregion //Field

        #region Contructor
        public FrmTargetMake()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            var data = BusinessFactory<TargetBusiness>.Instance.FindAll().ToList();
            this.bsTarget.DataSource = data;

            base.InitForm();
        }

        /// <summary>
        /// 载入指标记录
        /// </summary>
        private void LoadRecords()
        {
            var records = BusinessFactory<TargetRecordBusiness>.Instance.FindByTarget(this.currentTarget.Id).ToList();
            this.trGrid.DataSource = records;
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
        /// 设置实体对象
        /// </summary>
        /// <param name="entity"></param>
        private void SetRecordEntity(TargetRecord entity)
        {
            foreach (var item in entity.StaffTarget)
            {
                item.Remark = item.Remark == null ? "" : item.Remark;
            }
            foreach (var item in entity.AllowanceTarget)
            {
                item.Remark = item.Remark == null ? "" : item.Remark;
            }
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
        #endregion //Function

        #region Event
        /// <summary>
        /// 指标计划选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luPlanTarget_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luTarget.EditValue == null)
                return;

            this.currentTarget = this.luTarget.EditValue as Target;
            LoadRecords();
        }

        /// <summary>
        /// 部门选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectDepartment_Click(object sender, EventArgs e)
        {
            if (this.currentTarget == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmTargetSelectDepartment), new object[] { this.currentTarget.Id });
        }

        /// <summary>
        /// 添加指标记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (this.currentTarget == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmTargetRecordAdd), new object[] { this.currentTarget.Id });
            LoadRecords();
        }

        /// <summary>
        /// 指标记录选择
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void trGrid_RowSelected(object arg1, EventArgs arg2)
        {
            var select = this.trGrid.GetCurrentSelect();
            if (select == null)
                return;

            this.stGrid.DataSource = select.StaffTarget;
            this.atGrid.DataSource = select.AllowanceTarget;
        }

        /// <summary>
        /// 导入人数记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportStaff_Click(object sender, EventArgs e)
        {
            var select = this.trGrid.GetCurrentSelect();
            if (select == null)
                return;

            LoadStaffRecord(this.currentTarget.PopulationId, select.DepartmentId);
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
            var select = this.trGrid.GetCurrentSelect();
            if (select == null)
                return;

            SetRecordEntity(select);

            try
            {
                var result = BusinessFactory<TargetRecordBusiness>.Instance.Update(select, this.currentUser);

                if (result)
                {
                    MessageUtil.ShowInfo("保存成功");
                }
                else
                {
                    MessageUtil.ShowInfo("保存失败");
                }
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
            var select = this.trGrid.GetCurrentSelect();
            if (select == null)
                return;

            LoadFundRecord(this.currentTarget.FundId, select.DepartmentId);
        }

        /// <summary>
        /// 增加补贴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAllowance_Click(object sender, EventArgs e)
        {
            FrmAllowanceAdd form = new FrmAllowanceAdd();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var allowance = form.AllowanceTarget;
                this.atGrid.DataSource.Add(allowance);
                this.atGrid.UpdateBindingData();
            }
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
            var select = this.trGrid.GetCurrentSelect();
            if (select == null)
                return;

            SetRecordEntity(select);

            try
            {
                var result = BusinessFactory<TargetRecordBusiness>.Instance.Update(select, this.currentUser);

                if (result)
                {
                    MessageUtil.ShowInfo("保存成功");
                }
                else
                {
                    MessageUtil.ShowInfo("保存失败");
                }
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
