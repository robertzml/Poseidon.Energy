using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.DAL.Mongo
{
    using MongoDB.Bson;
    using MongoDB.Driver;
    using Poseidon.Base.Framework;
    using Poseidon.Data;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;

    /// <summary>
    /// 能源结算记录数据访问类
    /// </summary>
    internal class SettlementRecordRepository : AbstractDALMongo<SettlementRecord>, ISettlementRecordRepository
    {
        #region Constructor
        /// <summary>
        /// 能源结算记录数据访问类
        /// </summary>
        public SettlementRecordRepository()
        {
            base.Init("energy_settlementRecord");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override SettlementRecord DocToEntity(BsonDocument doc)
        {
            SettlementRecord entity = new SettlementRecord();
            entity.Id = doc["_id"].ToString();
            entity.SettlementId = doc["settlementId"].ToString();
            entity.DepartmentId = doc["departmentId"].ToString();
            entity.EnergyType = doc["energyType"].ToInt32();
            entity.UnitPrice = doc["unitPrice"].ToDecimal();
            entity.BeginQuantum = doc["beginQuantum"].ToDecimal();
            entity.BeginAmount = doc["beginAmount"].ToDecimal();
            entity.Quantum = doc["quantum"].ToDecimal();
            entity.Amount = doc["amount"].ToDecimal();

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
        protected override BsonDocument EntityToDoc(SettlementRecord entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "settlementId", entity.SettlementId },
                { "departmentId", entity.DepartmentId },
                { "energyType", entity.EnergyType },
                { "unitPrice", entity.UnitPrice },
                { "beginQuantum", entity.BeginQuantum },
                { "beginAmount", entity.BeginAmount },
                { "quantum", entity.Quantum },
                { "amount", entity.Amount },
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
        /// 查找单条记录
        /// </summary>
        /// <param name="settlementId">能源结算ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <param name="energyType">能源类型</param>
        /// <returns></returns>
        public SettlementRecord FindOne(string settlementId, string departmentId, int energyType)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("settlementId", settlementId) & builder.Eq("departmentId", departmentId) & builder.Eq("energyType", energyType);

            return base.FindOne(filter);
        }

        /// <summary>
        /// 查找多条记录
        /// </summary>
        /// <param name="settlementId">能源结算ID</param>
        /// <param name="energyType">能源类型</param>
        /// <returns></returns>
        public IEnumerable<SettlementRecord> FindList(string settlementId, int energyType)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("settlementId", settlementId) & builder.Eq("energyType", energyType);

            return base.FindList(filter);
        }

        /// <summary>
        /// 删除未选择部门能源结算记录
        /// </summary>
        /// <param name="settlementId">能源结算ID</param>
        /// <param name="departmentIds">已选择部门ID</param>
        /// <param name="energyType">能源类型</param>
        /// <returns></returns>
        public bool DeleteNotIn(string settlementId, List<string> departmentIds, int energyType)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("settlementId", settlementId) & builder.Eq("energyType", energyType) & builder.Nin("departmentId", departmentIds);

            return base.DeleteMany(filter).success;
        }
        #endregion //Method
    }
}
