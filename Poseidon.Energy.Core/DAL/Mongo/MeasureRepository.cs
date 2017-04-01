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
    /// 能源计量数据访问类
    /// </summary>
    internal class MeasureRepository : AbstractDALMongo<Measure>, IMeasureRepository
    {
        #region Constructor
        /// <summary>
        /// 能源计量数据访问类
        /// </summary>
        public MeasureRepository()
        {
            base.Init("energy_measure");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Measure DocToEntity(BsonDocument doc)
        {
            Measure entity = new Measure();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.Year = doc["year"].ToInt32();
            entity.BelongTime = doc["belongTime"].ToString();
            entity.StartTime = doc["startTime"].ToLocalTime();
            entity.EndTime = doc["endTime"].ToLocalTime();
            entity.Included = doc["included"].ToBoolean();
            entity.EnergyType = doc["energyType"].ToInt32();

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
        protected override BsonDocument EntityToDoc(Measure entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "year", entity.Year },
                { "belongTime", entity.BelongTime },
                { "startTime", entity.StartTime },
                { "endTime", entity.EndTime },
                { "included", entity.Included },
                { "energyType", entity.EnergyType },
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
        /// 按年度查找能源计量
        /// </summary>
        /// <param name="year">年度</param>
        /// <param name="energyType">能源类型</param>
        /// <returns></returns>
        public IEnumerable<Measure> FindByYear(int year, int energyType)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("year", year) & builder.Eq("energyType", energyType);

            return base.FindList(filter);
        }
        #endregion //Method
    }
}
