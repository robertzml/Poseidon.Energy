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
        public WaterExpenseRecordGrid()
        {
            InitializeComponent();
        }
    }
}
