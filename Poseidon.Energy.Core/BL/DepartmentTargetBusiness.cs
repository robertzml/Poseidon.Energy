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
    /// 部门指标业务类
    /// </summary>
    public class DepartmentTargetBusiness : AbsctractBusiness<DepartmentTarget>
    {
        #region Constructor
        /// <summary>
        /// 部门指标业务类
        /// </summary>
        public DepartmentTargetBusiness()
        {
            this.baseDal = RepositoryFactory<IDepartmentTargetRepository>.Instance;
        }
        #endregion //Constructor
    }
}
