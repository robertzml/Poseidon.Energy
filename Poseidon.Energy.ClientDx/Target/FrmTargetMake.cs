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
            LoadTargets();

            base.InitForm();
        }

        /// <summary>
        /// 载入指标计划
        /// </summary>
        private void LoadTargets()
        {
            var data = BusinessFactory<TargetBusiness>.Instance.FindAll().ToList();
            this.bsTarget.DataSource = data;
        }

        /// <summary>
        /// 载入指标记录
        /// </summary>
        /// <param name="target">相关计划</param>
        private void LoadRecords(Target target)
        {
            var records = BusinessFactory<TargetRecordBusiness>.Instance.FindByTarget(target.Id).ToList();
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

            this.currentTarget = this.luTarget.GetSelectedDataRow() as Target;
            LoadRecords(this.currentTarget);
        }

        /// <summary>
        /// 添加计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmTargetAdd));
            LoadTargets();
        }

        /// <summary>
        /// 编辑计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.currentTarget == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmTargetEdit), new object[] { this.currentTarget.Id });
            LoadTargets();
        }

        /// <summary>
        /// 删除计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 部门关联选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectDepartment_Click(object sender, EventArgs e)
        {
            if (this.currentTarget == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmTargetSelectDepartment), new object[] { this.currentTarget.Id });
            LoadRecords(this.currentTarget);
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
            LoadRecords(this.currentTarget);
        }

        /// <summary>
        /// 编辑指标记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            if (this.currentTarget == null)
                return;

            var select = this.trGrid.GetCurrentSelect();
            if (select == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmTargetRecordEdit), new object[] { select.Id });
            LoadRecords(this.currentTarget);
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

            this.txtDepartmentName1.Text = this.txtDepartmentName2.Text 
                = BusinessFactory<DepartmentBusiness>.Instance.FindById(select.DepartmentId).Name;
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
            this.stGrid.CloseEditor();

            var select = this.trGrid.GetCurrentSelect();
            if (select == null)
                return;

            var input = CheckStaffTarget();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                var result = BusinessFactory<TargetRecordBusiness>.Instance.UpdateStaffTarget(select.Id, this.stGrid.DataSource, this.currentUser);

                if (result)
                    MessageUtil.ShowInfo("保存成功");
                else
                    MessageUtil.ShowInfo("保存失败");

                LoadRecords(this.currentTarget);
                this.trGrid.SelectRow(select);
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

            var select = this.trGrid.GetCurrentSelect();
            if (select == null)
                return;

            var input = CheckAllowanceTarget();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                var result = BusinessFactory<TargetRecordBusiness>.Instance.UpdateAllowanceTarget(select.Id, this.atGrid.DataSource, this.currentUser);

                if (result)
                    MessageUtil.ShowInfo("保存成功");
                else
                    MessageUtil.ShowInfo("保存失败");

                LoadRecords(this.currentTarget);
                this.trGrid.SelectRow(select);
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
