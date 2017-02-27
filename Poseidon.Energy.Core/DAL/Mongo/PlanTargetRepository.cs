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
    /// 计划指标数据访问类
    /// </summary>
    internal class PlanTargetRepository : AbsctractDALMongo<PlanTarget>, IPlanTargetRepository
    {
        #region Constructor
        /// <summary>
        /// 计划指标数据访问类
        /// </summary>
        public PlanTargetRepository()
        {
            this.collectionName = "energy_planTarget";
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override PlanTarget DocToEntity(BsonDocument doc)
        {
            PlanTarget entity = new PlanTarget();
            entity.Id = doc["_id"].ToString();
            entity.Year = doc["year"].ToInt32();
            entity.PopulationId = doc["populationId"].ToString();
            entity.FundId = doc["fundId"].ToString();
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
        protected override BsonDocument EntityToDoc(PlanTarget entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "year", entity.Year },
                { "populationId", entity.PopulationId },
                { "fundId", entity.FundId },
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
        /// 添加计划指标
        /// </summary>
        /// <param name="entity">实体对象</param>
        public override void Create(PlanTarget entity)
        {
            entity.CreateTime = DateTime.Now;
            entity.UpdateTime = entity.CreateTime;
            entity.Status = 0;
            base.Create(entity);
        }
        #endregion //Method
    }
}
