using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;

    /// <summary>
    /// 经费统计业务类
    /// </summary>
    public class FundBusiness : AbsctractBusiness<Fund>
    {
        #region Constructor
        /// <summary>
        /// 人数统计业务类
        /// </summary>
        public FundBusiness()
        {
            this.baseDal = RepositoryFactory<IFundRepository>.Instance;
        }
        #endregion //Constructor
    }
}
