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
            var data = BusinessFactory<TargetBusiness>.Instance.FindAll().OrderByDescending(r => r.Year).ToList();
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
            this.trGrid.SelectRow(select);
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
        #endregion //Event
    }
}
