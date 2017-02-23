using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 添加人数记录
    /// </summary>
    public partial class FrmStaffNumberAdd : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联人数统计
        /// </summary>
        private Population currentEntity;
        #endregion //Field

        #region Constructor
        public FrmStaffNumberAdd(string populationId)
        {
            InitializeComponent();

            InitData(populationId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string populationId)
        {
            this.currentEntity = BusinessFactory<PopulationBusiness>.Instance.FindById(populationId);
        }
        #endregion //Function
    }
}
