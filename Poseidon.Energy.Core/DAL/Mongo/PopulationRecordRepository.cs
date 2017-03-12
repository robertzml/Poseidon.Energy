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
    /// 人数记录数据访问类
    /// </summary>
    internal class PopulationRecordRepository : AbstractDALMongo<PopulationRecord>, IPopulationRecordRepository
    {
        #region Constructor
        /// <summary>
        /// 人数记录数据访问类
        /// </summary>
        public PopulationRecordRepository()
        {
            base.Init("energy_populationRecord");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override PopulationRecord DocToEntity(BsonDocument doc)
        {
            PopulationRecord entity = new PopulationRecord();
            entity.Id = doc["_id"].ToString();
            entity.PopulationId = doc["populationId"].ToString();
            entity.DepartmentId = doc["departmentId"].ToString();

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

            entity.Details = new List<PopulationDetail>();
            if (doc.Contains("details"))
            {
                BsonArray array = doc["details"].AsBsonArray;
                foreach (BsonDocument item in array)
                {
                    PopulationDetail detail = new PopulationDetail();
                    detail.Name = item["name"].ToString();
                    detail.Code = item["code"].ToString();
                    detail.Number = item["number"].ToInt32();

                    entity.Details.Add(detail);
                }
            }

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(PopulationRecord entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "populationId", entity.PopulationId },
                { "departmentId", entity.DepartmentId },
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

            if (entity.Details != null && entity.Details.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.Details)
                {
                    BsonDocument detDoc = new BsonDocument
                    {
                        { "name", item.Name },
                        { "code", item.Code },
                        { "number", item.Number }
                    };
                    array.Add(detDoc);
                }

                doc.Add("details", array);
            }

            return doc;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 查找人数记录
        /// </summary>
        /// <param name="populationId">统计ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public PopulationRecord FindOne(string populationId, string departmentId)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("populationId", populationId) & builder.Eq("departmentId", departmentId);

            return this.FindOne(filter);
        }

        /// <summary>
        /// 添加人数记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        public override void Create(PopulationRecord entity)
        {
            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑人数记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override bool Update(PopulationRecord entity)
        {
            return base.Update(entity);
        }
        #endregion //Method
    }
}
