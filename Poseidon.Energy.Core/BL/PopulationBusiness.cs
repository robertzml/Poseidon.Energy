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
    /// 人数统计业务类
    /// </summary>
    public class PopulationBusiness : AbsctractBusiness<Population>
    {
        #region Constructor
        /// <summary>
        /// 部门业务类
        /// </summary>
        public PopulationBusiness()
        {
            this.baseDal = RepositoryFactory<IPopulationRepository>.Instance;
        }
        #endregion //Constructor
    }
}
