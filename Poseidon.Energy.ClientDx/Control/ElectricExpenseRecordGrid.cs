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
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 电费支出记录表格控件
    /// </summary>
    public partial class ElectricExpenseRecordGrid : WinEntityGrid<ElectricExpenseRecord>
    {
        #region Constructor
        public ElectricExpenseRecordGrid()
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
        private void ElectricExpenseRecordGrid_Load(object sender, EventArgs e)
        {
            if (!ControlUtil.IsInDesignMode())
            {
                ControlUtil.BindDictToComboBox(this.repoCmbFeeType, typeof(ElectricExpenseRecord), "FeeType");
            }
        }
        #endregion //Event
    }
}
