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
        #region Field
        /// <summary>
        /// 模型类型
        /// </summary>
        private readonly string modelType = Utility.ModelTypeCode.ExpenseAccount;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 支出账户数据访问类
        /// </summary>
        public ExpenseAccountRepository()
        {
            this.collectionName = "core_organization";
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
            entity.ShortName = doc["shortName"].ToString();
            entity.ModelType = doc["modelType"].ToString();
            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            if (doc.Contains("parentId"))
                entity.ParentId = doc["parentId"].ToString();

            entity.EnergyType = new List<int>();
            if (doc.Contains("energyType"))
            {
                BsonArray array = doc["energyType"].AsBsonArray;
                foreach (var item in array)
                {
                    entity.EnergyType.Add(item.ToInt32());
                }
            }

            entity.ElectricMeters = new List<ElectricMeter>();
            if (doc.Contains("electricMeters"))
            {
                BsonArray array = doc["electricMeters"].AsBsonArray;
                foreach (BsonDocument item in array)
                {
                    ElectricMeter meter = new ElectricMeter();
                    meter.Name = item["name"].ToString();
                    meter.Number = item["number"].ToString();
                    meter.SectionNumber = item["sectionNumber"].ToString();
                    meter.AccountName = item["accountName"].ToString();
                    meter.Address = item["address"].ToString();
                    meter.Multiple = item["multiple"].ToDecimal();
                    meter.Remark = item["remark"].ToString();
                    meter.Status = item["status"].ToInt32();

                    entity.ElectricMeters.Add(meter);
                }
            }

            entity.WaterMeters = new List<WaterMeter>();
            if (doc.Contains("waterMeters"))
            {
                BsonArray array = doc["waterMeters"].AsBsonArray;
                foreach (BsonDocument item in array)
                {
                    WaterMeter meter = new WaterMeter();
                    meter.Name = item["name"].ToString();
                    meter.Number = item["number"].ToString();
                    meter.AccountName = item["accountName"].ToString();
                    meter.Address = item["address"].ToString();
                    meter.Remark = item["remark"].ToString();
                    meter.Status = item["status"].ToInt32();

                    entity.WaterMeters.Add(meter);
                }
            }

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(ExpenseAccount entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "shortName", entity.ShortName },
                { "modelType", entity.ModelType },
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            if (entity.ParentId != null)
                doc.Add("parentId", entity.ParentId);

            if (entity.EnergyType != null && entity.EnergyType.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.EnergyType)
                {
                    array.Add(item);
                }

                doc.Add("energyType", array);
            }

            if (entity.ElectricMeters != null && entity.ElectricMeters.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.ElectricMeters)
                {
                    BsonDocument sub = new BsonDocument
                    {
                        { "name", item.Name },
                        { "number", item.Number },
                        { "sectionNumber", item.SectionNumber },
                        { "accountName", item.AccountName },
                        { "address", item.Address },
                        { "multiple", item.Multiple },
                        { "remark", item.Remark },
                        { "status", item.Status }
                    };
                    array.Add(sub);
                }

                doc.Add("electricMeters", array);
            }

            if (entity.WaterMeters != null && entity.WaterMeters.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.WaterMeters)
                {
                    BsonDocument sub = new BsonDocument
                    {
                        { "name", item.Name },
                        { "number", item.Number },
                        { "accountName", item.AccountName },
                        { "address", item.Address },
                        { "remark", item.Remark },
                        { "status", item.Status }
                    };
                    array.Add(sub);
                }

                doc.Add("waterMeters", array);
            }

            return doc;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 查找所有对象
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<ExpenseAccount> FindAll()
        {
            return base.FindListByField("modelType", this.modelType);
        }

        /// <summary>
        /// 添加支出账户
        /// </summary>
        /// <param name="entity">支出账户对象</param>
        public override void Create(ExpenseAccount entity)
        {
            entity.ModelType = this.modelType;
            entity.Status = 0;
            base.Create(entity);
        }
        #endregion //Method
    }
}
