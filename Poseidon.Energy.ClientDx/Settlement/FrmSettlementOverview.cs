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
    using Poseidon.Core.Utility;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 能源结算总览窗体
    /// </summary>
    public partial class FrmSettlementOverview : BaseMdiForm
    {
        #region Constructor
        public FrmSettlementOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.settlementTree.SetGroupCode(EnergyConstant.SettlementDepartmentGroupCode);

            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 分组选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settlementTree_GroupSelected(object sender, EventArgs e)
        {
            this.navFrame.SelectedPageIndex = 0;
            var groupId = this.settlementTree.GetCurrentSelectId();
            this.groupSettlementMod.SetGroup(groupId);
        }

        /// <summary>
        /// 部门选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settlementTree_OrganizationSelected(object sender, EventArgs e)
        {
            this.navFrame.SelectedPageIndex = 1;
            var departmentId = this.settlementTree.GetCurrentSelectId();
            this.depSettlementMod.SetDepartment(departmentId);
        }
        #endregion //Event
    }
}
