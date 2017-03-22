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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 分组下指标计划组件
    /// </summary>
    public partial class GroupTargetModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;
        #endregion //Field

        #region Constructor
        public GroupTargetModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入相关指标计划
        /// </summary>
        private void LoadTargets()
        {
            var targets = BusinessFactory<TargetBusiness>.Instance.FindAll().OrderByDescending(r => r.Year);
            this.bsTarget.DataSource = targets;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置关联分组
        /// </summary>
        /// <param name="id">分组ID</param>
        public void SetGroup(string id)
        {
            this.currentGroup = BusinessFactory<GroupBusiness>.Instance.FindById(id);
            LoadTargets();
        }
        #endregion //Method

        #region Event
        private void lbTargets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion //Event
    }
}
