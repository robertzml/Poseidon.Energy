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
    /// 部门指标数据访问类
    /// </summary>
    internal class DepartmentTargetRepository : AbsctractDALMongo<DepartmentTarget>, IDepartmentTargetRepository
    {
        #region Constructor
        /// <summary>
        /// 部门指标数据访问类
        /// </summary>
        public DepartmentTargetRepository()
        {
            this.collectionName = "energy_departmentTarget";
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override DepartmentTarget DocToEntity(BsonDocument doc)
        {
            DepartmentTarget entity = new DepartmentTarget();
            entity.Id = doc["_id"].ToString();
            entity.PlanTargetId = doc["planTargetId"].ToString();
            entity.DepartmentId = doc["departmentId"].ToString();
            entity.TotalKilowatt = doc["totalKilowatt"].ToDecimal();
            entity.TotalAmount = doc["totalAmount"].ToDecimal();
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
        protected override BsonDocument EntityToDoc(DepartmentTarget entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "planTargetId", entity.PlanTargetId },
                { "departmentId", entity.DepartmentId },
                { "totalKilowatt", entity.TotalKilowatt },
                { "totalAmount", entity.TotalAmount },
                { "createTime", entity.CreateTime },
                { "updateTime", entity.UpdateTime },
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            return doc;
        }
        #endregion //Function
    }
}
