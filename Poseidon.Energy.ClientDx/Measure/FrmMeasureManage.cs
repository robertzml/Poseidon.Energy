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
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 能源计量管理窗体
    /// </summary>
    public partial class FrmMeasureManage : BaseMdiForm
    {
        #region Constructor
        public FrmMeasureManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        private void lbMeasure_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// 添加计量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        #endregion //Event
    }
}
