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
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 部门总览窗体
    /// </summary>
    public partial class FrmDepartmentOverview : BaseMdiForm
    {
        #region Constructor
        public FrmDepartmentOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化控件
        /// </summary>
        protected override void InitControls()
        {
            LoadDepartment();
        }

        public void LoadGroups()
        {

        }

        /// <summary>
        /// 载入部门
        /// </summary>
        protected void LoadDepartment()
        {
            var data = BusinessFactory<DepartmentBusiness>.Instance.FindAll().ToList();
            this.depGrid.DataSource = data;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 窗体载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDepartmentOverview_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmDepartmentAdd));

            LoadDepartment();
        }
        #endregion //Event
    }
}
