﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    /// 经费记录数据访问类
    /// </summary>
    internal class FundRecordRepository : AbstractDALMongo<FundRecord>, IFundRecordRepository
    {
        #region Constructor
        /// <summary>
        /// 经费记录数据访问类
        /// </summary>
        public FundRecordRepository()
        {
            base.Init("energy_fundRecord");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override FundRecord DocToEntity(BsonDocument doc)
        {
            FundRecord entity = new FundRecord();
            entity.Id = doc["_id"].ToString();
            entity.FundId = doc["fundId"].ToString();
            entity.DepartmentId = doc["departmentId"].ToString();
            entity.HorizontalResearch = doc["horizontalResearch"].ToDecimal();
            entity.VerticalResearch = doc["verticalResearch"].ToDecimal();

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
        protected override BsonDocument EntityToDoc(FundRecord entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "fundId", entity.FundId },
                { "departmentId", entity.DepartmentId },
                { "horizontalResearch", entity.HorizontalResearch },
                { "verticalResearch", entity.VerticalResearch },
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
        /// 查找经费记录
        /// </summary>
        /// <param name="fundId">统计ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public FundRecord FindOne(string fundId, string departmentId)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("fundId", fundId) & builder.Eq("departmentId", departmentId);

            return this.FindOne(filter);
        }

        /// <summary>
        /// 添加经费记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override FundRecord Create(FundRecord entity)
        {
            entity.Status = 0;
            return base.Create(entity);
        }

        /// <summary>
        /// 编辑经费记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override (bool success, string errorMessage) Update(FundRecord entity)
        {
            return base.Update(entity);
        }
        #endregion //Method
    }
}
