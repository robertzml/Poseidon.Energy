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

    /// <summary>
    /// 人数统计
    /// </summary>
    public partial class FrmPopulation : BaseMdiForm
    {
        #region Constructor
        public FrmPopulation()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmPopulationAdd));
        }
    }
}
