using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DAL.Mongo
{
    using MongoDB.Bson;
    using MongoDB.Driver;
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

            entity.StaffTarget = new List<StaffTarget>();
            if (doc.Contains("staffTarget"))
            {
                BsonArray array = doc["staffTarget"].AsBsonArray;
                foreach (var item in array)
                {
                    StaffTarget st = new StaffTarget();
                    st.Name = doc["name"].ToString();
                    st.Count = doc["count"].ToInt32();
                    st.MonthKilowatt = doc["monthKilowatt"].ToDecimal();
                    st.MonthCount = doc["monthCount"].ToInt32();
                    st.YearKilowatt = doc["yearKilowatt"].ToDecimal();
                    st.YearAmount = doc["yearAmount"].ToDecimal();

                    entity.StaffTarget.Add(st);
                }
            }

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

            if (entity.StaffTarget != null && entity.StaffTarget.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.StaffTarget)
                {
                    BsonDocument stdoc = new BsonDocument
                    {
                        { "name", item.Name },
                        { "count", item.Count },
                        { "monthKilowatt", item.MonthKilowatt },
                        { "monthCount", item.MonthCount },
                        { "yearKilowatt", item.YearKilowatt },
                        { "yearAmount", item.YearAmount }
                    };
                    array.Add(stdoc);
                }

                doc.Add("staffTarget", array);
            }

            return doc;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 查找部门指标
        /// </summary>
        /// <param name="planTargetId">指标计划ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public DepartmentTarget FindOne(string planTargetId, string departmentId)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("planTargetId", planTargetId) & builder.Eq("departmentId", departmentId);

            return this.FindOne(filter);            
        }

        /// <summary>
        /// 检查部门指标是否存在
        /// </summary>
        /// <param name="planTargetId">指标计划ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public bool Exist(string planTargetId, string departmentId)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("planTargetId", planTargetId) & builder.Eq("departmentId", departmentId);

            long count = this.Count(filter);
            return count != 0;
        }

        /// <summary>
        /// 添加部门指标
        /// </summary>
        /// <param name="entity">实体对象</param>
        public override void Create(DepartmentTarget entity)
        {
            entity.CreateTime = DateTime.Now;
            entity.UpdateTime = entity.CreateTime;
            entity.Status = 0;

            base.Create(entity);
        }
        #endregion //Method
    }
}
