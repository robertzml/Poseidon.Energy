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
        #region Field
        /// <summary>
        /// 是否显示年度
        /// </summary>
        private bool showYear = false;
        #endregion //Field

        #region Constructor
        public SettlementAmountSummaryGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        private void SettlementAmountSummaryGrid_Load(object sender, EventArgs e)
        {
            this.colYear.Visible = showYear;
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否显示年度
        /// </summary>
        [Description("是否显示年度"), Category("界面"), Browsable(true)]
        public bool ShowYear
        {
            get
            {
                return this.showYear;
            }
            set
            {
                this.showYear = value;
            }
        }
        #endregion //Property
    }
}
