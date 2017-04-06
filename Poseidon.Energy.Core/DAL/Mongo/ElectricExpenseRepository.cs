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
    /// 电费支出票据数据访问类
    /// </summary>
    internal class ElectricExpenseRepository : AbstractDALMongo<ElectricExpense>, IElectricExpenseRepository
    {
        #region Constructor
        /// <summary>
        /// 电费支出票据数据访问类
        /// </summary>
        public ElectricExpenseRepository()
        {
            base.Init("energy_electricExpense");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override ElectricExpense DocToEntity(BsonDocument doc)
        {
            ElectricExpense entity = new ElectricExpense();
            entity.Id = doc["_id"].ToString();
            entity.AccountId = doc["accountId"].ToString();
            entity.FeeType = doc["feeType"].ToInt32();
            entity.BelongDate = doc["belongDate"].ToLocalTime();
            entity.TicketDate = doc["ticketDate"].ToLocalTime();
            entity.TotalQuantity = doc["totalQuantity"].ToDecimal();
            entity.TotalAmount = doc["totalAmount"].ToDecimal();
            entity.TotalPrize = doc["totalPrize"].ToDecimal();

            entity.Records = new List<ElectricExpenseRecord>();
            if (doc.Contains("records"))
            {
                BsonArray array = doc["records"].AsBsonArray;
                foreach (BsonDocument item in array)
                {
                    ElectricExpenseRecord record = new ElectricExpenseRecord();
                    record.MeterNumber = item["meterNumber"].ToString();
                    record.MeterName = item["meterName"].ToString();
                    record.FeeType = item["feeType"].ToInt32();
                    record.Previous = item["previous"].ToDecimal();
                    record.Current = item["current"].ToDecimal();
                    record.Multiple = item["multiple"].ToDecimal();
                    record.Quantity = item["quantity"].ToDecimal();
                    record.UnitPrice = item["unitPrice"].ToDecimal();
                    record.Amount = item["amount"].ToDecimal();
                    record.Prize = item["prize"].ToDecimal();
                    record.Remark = item["remark"].ToString();

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
        protected override BsonDocument EntityToDoc(ElectricExpense entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "accountId", entity.AccountId },
                { "feeType", entity.FeeType },
                { "belongDate", entity.BelongDate },
                { "ticketDate", entity.TicketDate },
                { "totalQuantity", entity.TotalQuantity },
                { "totalAmount", entity.TotalAmount },
                { "totalPrize", entity.TotalPrize },
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
                        { "meterNumber", item.MeterNumber },
                        { "meterName", item.MeterName },
                        { "feeType", item.FeeType },
                        { "previous", item.Previous },
                        { "current", item.Current },
                        { "multiple", item.Multiple },
                        { "quantity", item.Quantity },
                        { "unitPrice", item.UnitPrice },
                        { "amount", item.Amount },
                        { "prize", item.Prize },
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
