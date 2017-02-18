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
    /// 部门表格控件
    /// </summary>
    public partial class DepartmentGrid : WinEntityGrid<Department>
    {
        public DepartmentGrid()
        {
            InitializeComponent();
        }
    }
}
