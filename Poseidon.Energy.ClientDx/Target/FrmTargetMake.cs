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
        private PlanTarget currentPlanTarget;
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
            var data = BusinessFactory<PlanTargetBusiness>.Instance.FindAll().ToList();
            this.bsPlanTarget.DataSource = data;

            base.InitForm();
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
            this.currentPlanTarget = this.luPlanTarget.EditValue as PlanTarget;
        }

        /// <summary>
        /// 部门选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectDepartment_Click(object sender, EventArgs e)
        {
            if (this.currentPlanTarget == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmTargetSelectDepartment), new object[] { this.currentPlanTarget.Id });
        }
        #endregion //Event

    }
}
