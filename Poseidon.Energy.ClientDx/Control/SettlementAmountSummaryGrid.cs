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
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 能源结算金额汇总表格控件
    /// </summary>
    public partial class SettlementAmountSummaryGrid : WinEntityGrid<SettlementAmountSummary>
    {
        #region Constructor
        public SettlementAmountSummaryGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}
