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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
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

            var staff = BusinessFactory<TargetRecordBusiness>.Instance.ImportPopulation(this.currentTarget.PopulationId, select.DepartmentId);
            this.stGrid.DataSource = staff;
        }
        #endregion //Event
    }
}
