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
    /// 支出账户业务类
    /// </summary>
    public class ExpenseAccountBusiness : AbsctractBusiness<ExpenseAccount>
    {
        #region Constructor
        public ExpenseAccountBusiness()
        {
            this.baseDal = RepositoryFactory<IExpenseAccountRepository>.Instance;
        }
        #endregion //Constructor
    }
}
