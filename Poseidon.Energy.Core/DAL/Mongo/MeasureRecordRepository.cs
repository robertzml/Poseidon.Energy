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
    /// 能源计量记录数据访问类
    /// </summary>
    internal class MeasureRecordRepository : AbstractDALMongo<MeasureRecord>, IMeasureRecordRepository
    {
        #region Constructor
        /// <summary>
        /// 能源计量记录数据访问类
        /// </summary>
        public MeasureRecordRepository()
        {
            base.Init("energy_measureRecord");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override MeasureRecord DocToEntity(BsonDocument doc)
        {
            MeasureRecord entity = new MeasureRecord();
            entity.Id = doc["_id"].ToString();
            entity.MeasureId = doc["measureId"].ToString();
            entity.DepartmentId = doc["departmentId"].ToString();
            entity.EnergyType = doc["energyType"].ToInt32();
            entity.Quantum = doc["quantum"].ToDecimal();

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
        protected override BsonDocument EntityToDoc(MeasureRecord entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "measureId", entity.MeasureId },
                { "departmentId", entity.DepartmentId },
                { "energyType", entity.EnergyType },
                { "quantum", entity.Quantum },
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
