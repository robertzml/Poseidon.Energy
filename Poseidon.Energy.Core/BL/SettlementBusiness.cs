using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;

    /// <summary>
    /// 能源结算业务类
    /// </summary>
    public class SettlementBusiness : AbstractBusiness<Settlement>
    {
        #region Constructor
        /// <summary>
        /// 能源结算业务类
        /// </summary>
        public SettlementBusiness()
        {
            this.baseDal = RepositoryFactory<ISettlementRepository>.Instance;
        }
        #endregion //Constructor
    }
}
