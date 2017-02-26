using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;

    /// <summary>
    /// 经费记录业务类
    /// </summary>
    public class FundRecordBusiness : AbsctractBusiness<FundRecord>
    {
        #region Constructor
        /// <summary>
        /// 人数统计业务类
        /// </summary>
        public FundRecordBusiness()
        {
            this.baseDal = RepositoryFactory<IFundRecordRepository>.Instance;
        }
        #endregion //Constructor
    }
}
