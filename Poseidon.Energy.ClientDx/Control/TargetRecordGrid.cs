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
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    
    /// <summary>
    /// 指标记录表格控件
    /// </summary>
    public partial class TargetRecordGrid : WinEntityGrid<TargetRecord>
    {
        #region Constructor
        public TargetRecordGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}
