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
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 人数详细记录表格窗体
    /// </summary>
    public partial class PopulationDetailsGrid : WinEntityGrid<PopulationDetail>
    {
        #region Constructor
        public PopulationDetailsGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}
