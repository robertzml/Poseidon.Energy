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
        #region Constructor
        /// <summary>
        /// 支出账户数据访问类
        /// </summary>
        public ExpenseAccountRepository()
        {
            this.collectionName = "energy_expenseAccount";
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override ExpenseAccount DocToEntity(BsonDocument doc)
        {
            ExpenseAccount entity = new ExpenseAccount();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            entity.WaterMeters = new List<WaterMeter>();


            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(ExpenseAccount entity)
        {
            throw new NotImplementedException();
        }
        #endregion //Function
    }
}
