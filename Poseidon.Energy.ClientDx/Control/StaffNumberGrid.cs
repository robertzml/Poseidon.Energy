using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
    /// 人数记录表格控件
    /// </summary>
    public partial class StaffNumberGrid : WinEntityGrid<StaffNumber>
    {
        public StaffNumberGrid()
        {
            InitializeComponent();
        }
    }
}
