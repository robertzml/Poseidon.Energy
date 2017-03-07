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
    /// 年水费表格控件
    /// </summary>
    public partial class WaterYearExpenseGrid : WinEntityGrid<WaterExpense>
    {
        public WaterYearExpenseGrid()
        {
            InitializeComponent();
        }
    }
}
