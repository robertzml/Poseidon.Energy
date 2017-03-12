using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DAL.Mongo
{
    using MongoDB.Bson;
    using MongoDB.Driver;
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Data;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;

    /// <summary>
    /// 经费统计数据访问类
    /// </summary>
    internal class FundRepository : AbstractDALMongo<Fund>, IFundRepository
    {
        #region Constructor
        /// <summary>
        /// 经费统计数据访问类
        /// </summary>
        public FundRepository()
        {
            base.Init("energy_fund");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Fund DocToEntity(BsonDocument doc)
        {
            Fund entity = new Fund();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.Year = doc["year"].ToInt32();

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
        protected override BsonDocument EntityToDoc(Fund entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "year", entity.Year },
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

        /// <summary>
        /// 检查重复项
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        private bool CheckDuplicate(Fund entity)
        {
            var builder = Builders<BsonDocument>.Filter;
            FilterDefinition<BsonDocument> filter;

            if (entity.Id == null)
                filter = builder.Eq("year", entity.Year);
            else
                filter = builder.Eq("year", entity.Year) & builder.Ne("_id", new ObjectId(entity.Id));

            long count = Count(filter);
            if (count > 0)
                return false;
            else
                return true;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 添加经费统计
        /// </summary>
        /// <param name="entity">实体对象</param>
        public override void Create(Fund entity)
        {
            if (!CheckDuplicate(entity))
                throw new PoseidonException("年度已存在");

            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑经费统计
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override bool Update(Fund entity)
        {
            if (!CheckDuplicate(entity))
                throw new PoseidonException("年度已存在");

            return base.Update(entity);
        }
        #endregion //Method
    }
}
