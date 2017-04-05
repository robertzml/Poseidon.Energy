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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 分组能源结算组件
    /// </summary>
    public partial class GroupSettlementModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public GroupSettlementModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}
