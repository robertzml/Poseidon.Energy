using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.DAL.Mongo
{
    using MongoDB.Bson;
    using Poseidon.Base.Framework;
    using Poseidon.Data;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;

    /// <summary>
    /// 支出账户数据访问类
    /// </summary>
    internal class ExpenseAccountRepository : AbsctractDALMongo<ExpenseAccount>, IExpenseAccountRepository
    {
        #region Function
        protected override ExpenseAccount DocToEntity(BsonDocument doc)
        {
            throw new NotImplementedException();
        }

        protected override BsonDocument EntityToDoc(ExpenseAccount entity)
        {
            throw new NotImplementedException();
        }
        #endregion //Function
    }
}
