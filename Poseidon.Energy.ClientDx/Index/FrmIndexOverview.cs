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

    public partial class FrmIndexOverview : BaseMdiForm
    {
        #region Constructor
        public FrmIndexOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入部门
        /// </summary>
        private void LoadDepartment()
        {
            var data = BusinessFactory<DepartmentBusiness>.Instance.FindAll().ToList();
            this.depGrid.DataSource = data;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 添加计划指标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmTargetAdd));
        }
        #endregion //Event
    }
}
