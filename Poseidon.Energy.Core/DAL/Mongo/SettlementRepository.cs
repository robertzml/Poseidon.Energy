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
    /// 能源结算数据访问类
    /// </summary>
    internal class SettlementRepository : AbstractDALMongo<Settlement>, ISettlementRepository
    {
        #region Constructor
        /// <summary>
        /// 能源结算数据访问类
        /// </summary>
        public SettlementRepository()
        {
            base.Init("energy_settlement");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Settlement DocToEntity(BsonDocument doc)
        {
            Settlement entity = new Settlement();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.Year = doc["year"].ToInt32();
            entity.Type = doc["type"].ToInt32();
            entity.BelongTime = doc["belongTime"].ToString();
            entity.PreviousId = doc["previousId"].ToString();

            var createBy = doc["createBy"].ToBsonDocument();
            entity.CreateBy = new UpdateStamp
            {
                UserId = createBy["userId"].ToString(),
                Name = createBy["name"].ToString(),
                Time = createBy["time"].ToLocalTime()
            };

            var updateBy = doc["updateBy"].ToBsonDocument();
            entity.UpdateBy = new UpdateStamp
            {
                UserId = updateBy["userId"].ToString(),
                Name = updateBy["name"].ToString(),
                Time = updateBy["time"].ToLocalTime()
            };

            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(Settlement entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "year", entity.Year },
                { "type", entity.Type },
                { "belongTime", entity.BelongTime },
                { "previousId", entity.PreviousId },
                { "createBy", new BsonDocument {
                    { "userId", entity.CreateBy.UserId },
                    { "name", entity.CreateBy.Name },
                    { "time", entity.CreateBy.Time }
                }},
                { "updateBy", new BsonDocument {
                    { "userId", entity.UpdateBy.UserId },
                    { "name", entity.UpdateBy.Name },
                    { "time", entity.UpdateBy.Time }
                }},
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            return doc;
        }
        #endregion //Function
    }
}
