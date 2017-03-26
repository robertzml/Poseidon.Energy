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
    using Poseidon.Base.System;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 选择能源计量部门
    /// </summary>
    public partial class FrmMeasureSetDepartment : BaseSingleForm
    {
        #region Field
        private Measure currentMeasure;
        #endregion //Field

        #region Constructor
        public FrmMeasureSetDepartment(string measureId)
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}
