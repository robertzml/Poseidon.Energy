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
    using Poseidon.Winform.Base;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmDepartmentAdd));
        }
    }
}
