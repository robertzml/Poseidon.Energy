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
    using Poseidon.Base.System;
    using Poseidon.Data;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;

    /// <summary>
    /// 经费记录数据访问类
    /// </summary>
    public class FundRecordRepository : AbsctractDALMongo<FundRecord>, IFundRecordRepository
    {
        #region Constructor
        /// <summary>
        /// 经费记录数据访问类
        /// </summary>
        public FundRecordRepository()
        {
            this.collectionName = "energy_fundRecord";
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
            entity.CreateTime = doc["createTime"].ToLocalTime();
            entity.UpdateTime = doc["updateTime"].ToLocalTime();
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
                { "createTime", entity.CreateTime },
                { "updateTime", entity.UpdateTime },
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            return doc;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 添加经费记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        public override void Create(FundRecord entity)
        {
            entity.CreateTime = DateTime.Now;
            entity.UpdateTime = entity.CreateTime;
            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑经费记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override bool Update(FundRecord entity)
        {
            entity.UpdateTime = DateTime.Now;
            return base.Update(entity);
        }
        #endregion //Method
    }
}
