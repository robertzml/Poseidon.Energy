using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 人员指标表格控件
    /// </summary>
    public partial class StaffTargetGrid : WinEntityGrid<StaffTarget>
    {
        #region Constructor
        public StaffTargetGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}
