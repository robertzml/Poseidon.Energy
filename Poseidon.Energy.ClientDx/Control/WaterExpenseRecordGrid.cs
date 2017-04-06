using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 水费支出记录表格控件
    /// </summary>
    public partial class WaterExpenseRecordGrid : WinEntityGrid<WaterExpenseRecord>
    {
        #region Constructor
        public WaterExpenseRecordGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterExpenseRecordGrid_Load(object sender, EventArgs e)
        {
            if (!ControlUtil.IsInDesignMode())
            {
                ControlUtil.BindDictToComboBox(this.repoCmbFeeType, typeof(WaterExpenseRecord), "FeeType");
            }
        }
        #endregion //Event
    }
}
