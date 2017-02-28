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
    /// 指标计划部门选择窗体
    /// </summary>
    public partial class FrmTargetSelectDepartment : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 关联指标计划
        /// </summary>
        private PlanTarget currentEntity;
        #endregion //Field

        #region Constructor
        public FrmTargetSelectDepartment(string planTargetId)
        {
            InitializeComponent();

            InitData(planTargetId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentEntity = BusinessFactory<PlanTargetBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            var departments = BusinessFactory<DepartmentBusiness>.Instance.FindAll().ToList();
            this.bsDepartment.DataSource = departments;

            base.InitForm();
        }

        private void SetSelectDepartment()
        {

        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            this.clbDepartment.CheckAll();
        }
        
        /// <summary>
        /// 反选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            this.clbDepartment.UnCheckAll();
        }
        #endregion //Event
    }
}
