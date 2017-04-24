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
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 能源计量总览
    /// </summary>
    public partial class FrmMeasureOverview : BaseMdiForm
    {
        #region Constructor
        public FrmMeasureOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.measureTree.SetGroupCode(EnergyConstant.MeasureDepartmentGroupCode);
            
            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 分组选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void measureTree_GroupSelected(object sender, EventArgs e)
        {
            this.navFrame.SelectedPageIndex = 0;
            var groupId = this.measureTree.GetCurrentSelectId();
            this.groupMeasureMod.SetGroup(groupId);
        }

        /// <summary>
        /// 部门选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void measureTree_OrganizationSelected(object sender, EventArgs e)
        {
            this.navFrame.SelectedPageIndex = 1;
            var departmentId = this.measureTree.GetCurrentSelectId();
            this.depMeasureMod.SetDepartment(departmentId);
        }
        #endregion //Event
    }
}
