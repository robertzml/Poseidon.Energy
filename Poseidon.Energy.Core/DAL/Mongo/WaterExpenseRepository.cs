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
    /// 水费支出数据访问类
    /// </summary>
    internal class WaterExpenseRepository : AbsctractDALMongo<WaterExpense>, IWaterExpenseRepository
    {
        #region Constructor
        /// <summary>
        /// 水费支出数据访问类
        /// </summary>
        public WaterExpenseRepository()
        {
            this.collectionName = "expense_water";
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override WaterExpense DocToEntity(BsonDocument doc)
        {
            WaterExpense entity = new WaterExpense();
            entity.Id = doc["_id"].ToString();
            entity.AccountId = doc["accountId"].ToString();
            entity.FeeType = doc["feeType"].ToInt32();
            entity.BelongDate = doc["belongDate"].ToLocalTime();
            entity.TicketDate = doc["ticketDate"].ToLocalTime();
            entity.TotalQuantity = doc["totalQuantity"].ToDecimal();
            entity.TotalAmount = doc["totalAmount"].ToDecimal();

            entity.Records = new List<WaterExpenseRecord>();
            if (doc.Contains("records"))
            {
                BsonArray array = doc["records"].AsBsonArray;
                foreach (BsonDocument item in array)
                {
                    WaterExpenseRecord record = new WaterExpenseRecord();
                    record.MeterId = doc["meterId"].ToString();
                    record.MeterName = doc["meterName"].ToString();
                    record.FeeType = doc["feeType"].ToInt32();
                    record.Previous = doc["previous"].ToDecimal();
                    record.Current = doc["current"].ToDecimal();
                    record.Quantity = doc["quantity"].ToDecimal();
                    record.UnitPrice = doc["unitPrice"].ToDecimal();
                    record.Amount = doc["amount"].ToDecimal();
                    record.Remark = doc["remark"].ToString();

                    entity.Records.Add(record);
                }
            }

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
        protected override BsonDocument EntityToDoc(WaterExpense entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "accountId", entity.AccountId },
                { "feeType", entity.FeeType },
                { "belongDate", entity.BelongDate },
                { "ticketDate", entity.TicketDate },
                { "totalQuantity", entity.TotalQuantity },
                { "totalAmount", entity.TotalAmount },
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

            if (entity.Records != null && entity.Records.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.Records)
                {
                    BsonDocument record = new BsonDocument
                    {
                        { "meterId", item.MeterId == null ? "" : item.MeterId },
                        { "meterName", item.MeterName },
                        { "feeType", item.FeeType },
                        { "previous", item.Previous },
                        { "current", item.Current },
                        { "quantity", item.Quantity },
                        { "unitPrice", item.UnitPrice },
                        { "amount", item.Amount },
                        { "remark", item.Remark }
                    };

                    array.Add(record);
                }

                doc.Add("records", array);
            }

            return doc;
        }
        #endregion //Function
    }
}
