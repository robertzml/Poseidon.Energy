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
    /// 指标记录数据访问类
    /// </summary>
    internal class TargetRecordRepository : AbsctractDALMongo<TargetRecord>, ITargetRecordRepository
    {
        #region Constructor
        /// <summary>
        /// 指标记录数据访问类
        /// </summary>
        public TargetRecordRepository()
        {
            this.collectionName = "energy_targetRecord";
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override TargetRecord DocToEntity(BsonDocument doc)
        {
            TargetRecord entity = new TargetRecord();
            entity.Id = doc["_id"].ToString();
            entity.TargetId = doc["targetId"].ToString();
            entity.DepartmentId = doc["departmentId"].ToString();
            entity.Type = doc["type"].ToInt32();
            entity.Finance = doc["finance"].ToString();
            entity.TotalQuantum = doc["totalQuantum"].ToDecimal();
            entity.TotalAmount = doc["totalAmount"].ToDecimal();
            entity.CreateTime = doc["createTime"].ToLocalTime();
            entity.UpdateTime = doc["updateTime"].ToLocalTime();
            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            entity.StaffTarget = new List<StaffTarget>();
            if (doc.Contains("staffTarget"))
            {
                BsonArray array = doc["staffTarget"].AsBsonArray;
                foreach (BsonDocument item in array)
                {
                    StaffTarget st = new StaffTarget();
                    st.Name = item["name"].ToString();
                    st.Code = item["code"].ToString();
                    st.Number = item["number"].ToInt32();
                    st.MonthKilowatt = item["monthKilowatt"].ToDecimal();
                    st.MonthCount = item["monthCount"].ToInt32();
                    st.UnitPrice = item["unitPrice"].ToDecimal();
                    st.YearKilowatt = item["yearKilowatt"].ToDecimal();
                    st.YearAmount = item["yearAmount"].ToDecimal();
                    st.Remark = item["remark"].ToString();

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
        protected override BsonDocument EntityToDoc(TargetRecord entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "targetId", entity.TargetId },
                { "departmentId", entity.DepartmentId },
                { "type", entity.Type },
                { "finance", entity.Finance },
                { "totalQuantum", entity.TotalQuantum },
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
                        { "code", item.Code },
                        { "number", item.Number },
                        { "monthKilowatt", item.MonthKilowatt },
                        { "monthCount", item.MonthCount },
                        { "unitPrice", item.UnitPrice },
                        { "yearKilowatt", item.YearKilowatt },
                        { "yearAmount", item.YearAmount },
                        { "remark", item.Remark }
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
        /// 查找指标记录
        /// </summary>
        /// <param name="targetId">指标计划ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public TargetRecord FindOne(string targetId, string departmentId)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("targetId", targetId) & builder.Eq("departmentId", departmentId);

            return this.FindOne(filter);
        }

        /// <summary>
        /// 检查指标记录是否存在
        /// </summary>
        /// <param name="targetId">指标计划ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public bool Exist(string targetId, string departmentId)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("targetId", targetId) & builder.Eq("departmentId", departmentId);

            long count = this.Count(filter);
            return count != 0;
        }

        /// <summary>
        /// 添加指标记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        public override void Create(TargetRecord entity)
        {
            entity.CreateTime = DateTime.Now;
            entity.UpdateTime = entity.CreateTime;
            entity.Status = 0;

            base.Create(entity);
        }

        /// <summary>
        /// 编辑指标记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override bool Update(TargetRecord entity)
        {
            entity.UpdateTime = DateTime.Now;
            return base.Update(entity);
        }

        /// <summary>
        /// 删除未选择部门指标记录
        /// </summary>
        /// <param name="targetId">计划指标ID</param>
        /// <param name="departmentIds">已选择部门ID</param>
        /// <returns></returns>
        public bool DeleteNotIn(string targetId, List<string> departmentIds)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("targetId", targetId) & builder.Nin("departmentId", departmentIds);

            return base.DeleteMany(filter);
        }
        #endregion //Method
    }
}
