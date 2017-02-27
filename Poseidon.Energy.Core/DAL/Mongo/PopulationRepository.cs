using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DAL.Mongo
{
    using MongoDB.Bson;
    using Poseidon.Base.Framework;
    using Poseidon.Data;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;

    /// <summary>
    /// 人数统计数据访问类
    /// </summary>
    internal class PopulationRepository : AbsctractDALMongo<Population>, IPopulationRepository
    {
        #region Field

        #endregion //Field

        #region Constructor
        /// <summary>
        /// 人数统计数据访问类
        /// </summary>
        public PopulationRepository()
        {
            this.collectionName = "energy_population";
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Population DocToEntity(BsonDocument doc)
        {
            Population entity = new Population();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.Year = doc["year"].ToInt32();
            entity.BelongTime = doc["belongTime"].ToString();
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
        protected override BsonDocument EntityToDoc(Population entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "year", entity.Year },
                { "belongTime", entity.BelongTime },
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
        /// 添加人数统计
        /// </summary>
        /// <param name="entity">实体对象</param>
        public override void Create(Population entity)
        {
            entity.CreateTime = DateTime.Now;
            entity.UpdateTime = entity.CreateTime;
            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑人数统计
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override bool Update(Population entity)
        {
            entity.UpdateTime = DateTime.Now;
            return base.Update(entity);
        }
        #endregion //Method
    }
}
