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
    /// 能源结算记录数据访问类
    /// </summary>
    public class SettlementRecordBusiness : AbstractBusiness<SettlementRecord>
    {
        #region Constructor
        /// <summary>
        /// 能源结算记录数据访问类
        /// </summary>
        public SettlementRecordBusiness()
        {
            this.baseDal = RepositoryFactory<ISettlementRecordRepository>.Instance;
        }
        #endregion //Constructor
    }
}
