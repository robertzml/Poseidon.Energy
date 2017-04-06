using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DAL.Mongo
{
    using MongoDB.Bson;
    using MongoDB.Driver;
    using Poseidon.Base.Framework;
    using Poseidon.Data;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;

    /// <summary>
    /// 人数统计数据访问类
    /// </summary>
    internal class PopulationRepository : AbstractDALMongo<Population>, IPopulationRepository
    {
        #region Field

        #endregion //Field

        #region Constructor
        /// <summary>
        /// 人数统计数据访问类
        /// </summary>
        public PopulationRepository()
        {
            base.Init("energy_population");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Population DocToEntity(BsonDocument doc)
        {
            Population entity = new Population();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.Year = doc["year"].ToInt32();
            entity.BelongTime = doc["belongTime"].ToString();

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
        protected override BsonDocument EntityToDoc(Population entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "year", entity.Year },
                { "belongTime", entity.BelongTime },
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

        #region Method
        /// <summary>
        /// 添加人数统计
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override Population Create(Population entity)
        {
            entity.Status = 0;
            return base.Create(entity);
        }

        /// <summary>
        /// 编辑人数统计
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override bool Update(Population entity)
        {
            return base.Update(entity);
        }
        #endregion //Method
    }
}
