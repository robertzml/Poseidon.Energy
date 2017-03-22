using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 指标计划总览窗体
    /// </summary>
    public partial class FrmTargetOverview : BaseMdiForm
    {
        #region Field

        #endregion //Field

        #region Constructor
        public FrmTargetOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.groupTreeTarget.SetGroupCode(EnergyConstant.TargetDepartmentGroupCode);

            base.InitForm();
        }

        /// <summary>
        /// 载入指标计划
        /// </summary>
        private void LoadTargets()
        {
            //var data = BusinessFactory<TargetBusiness>.Instance.FindAll().ToList();
            //this.bsTarget.DataSource = data;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 分组选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupTreeTarget_GroupSelected(object sender, EventArgs e)
        {
            this.navFrame.SelectedPageIndex = 0;
            var groupId = this.groupTreeTarget.GetCurrentSelectId();
            this.groupTargetMod.SetGroup(groupId);
        }

        /// <summary>
        /// 部门选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupTreeTarget_OrganizationSelected(object sender, EventArgs e)
        {
            this.navFrame.SelectedPageIndex = 1;
            var departmentId = this.groupTreeTarget.GetCurrentSelectId();
            this.depTargetMod.SetDepartment(departmentId);
        }
        #endregion //Event
    }
}
