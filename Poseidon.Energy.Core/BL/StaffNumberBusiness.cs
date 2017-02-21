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
    /// 人数记录业务类
    /// </summary>
    public class StaffNumberBusiness : AbsctractBusiness<StaffNumber>
    {
        #region Constructor
        /// <summary>
        /// 人数记录业务类
        /// </summary>
        public StaffNumberBusiness()
        {
            this.baseDal = RepositoryFactory<IStaffNumberRepository>.Instance;
        }
        #endregion //Constructor
    }
}
