using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 编辑能源结算记录
    /// </summary>
    public partial class FrmSettlementRecordEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联能源结算
        /// </summary>
        private Settlement currentSettlement;
        #endregion //Field

        #region Constructor
        public FrmSettlementRecordEdit(string id)
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentSettlement = BusinessFactory<SettlementBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            var groups = BusinessFactory<GroupBusiness>.Instance.FindWithChildrenByCode(EnergyConstant.SettlementDepartmentGroupCode).ToList();
            this.settlementGroup.DataSource = groups;

            base.InitForm();
        }
        #endregion //Function
    }
}
