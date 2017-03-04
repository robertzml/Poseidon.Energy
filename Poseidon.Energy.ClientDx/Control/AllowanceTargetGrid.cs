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


    public partial class AllowanceTargetGrid : WinEntityGrid<AllowanceTarget>
    {
        public AllowanceTargetGrid()
        {
            InitializeComponent();
        }
    }
}
