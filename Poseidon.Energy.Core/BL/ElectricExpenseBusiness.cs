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
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 电费支出单据业务类
    /// </summary>
    public class ElectricExpenseBusiness : AbsctractBusiness<ElectricExpense>
    {
        #region Constructor
        /// <summary>
        /// 电费支出单据业务类
        /// </summary>
        public ElectricExpenseBusiness()
        {
            this.baseDal = RepositoryFactory<IElectricExpenseRepository>.Instance;
        }
        #endregion //Constructor
    }
}
