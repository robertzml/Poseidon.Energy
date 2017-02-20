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
    /// 人数统计数据访问类
    /// </summary>
    internal class PopulationRepository : AbsctractDALMongo<Population>, IPopulationRepository
    {
        #region Field
       
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 部门数据访问类
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
            entity.Year = doc["year"].ToInt32();
            entity.BelongTime = doc["belongTime"].ToString();
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
                { "year", entity.Year },
                { "belongTime", entity.BelongTime },
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            return doc;
        }
        #endregion //Function
    }
}
