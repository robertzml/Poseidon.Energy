using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.IDAL
{
    using Poseidon.Base.Framework;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 支出账户数据访问接口
    /// </summary>
    internal interface IExpenseAccountRepository : IBaseDAL<ExpenseAccount>
    {
    }
}
