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
    /// 部门数据访问类
    /// </summary>
    internal class DepartmentRepository : AbstractDALMongo<Department>, IDepartmentRepository
    {
        #region Field
        /// <summary>
        /// 模型类型
        /// </summary>
        private readonly string modelType = Utility.ModelTypeCode.Department;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 部门数据访问类
        /// </summary>
        public DepartmentRepository()
        {
            base.Init("core_organization");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Department DocToEntity(BsonDocument doc)
        {
            Department entity = new Department();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.ModelType = doc["modelType"].ToString();
            entity.ShortName = doc["shortName"].ToString();
            entity.FoundYear = doc["foundYear"].ToInt32();
            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            if (doc.Contains("parentId"))
                entity.ParentId = doc["parentId"].ToString();

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(Department entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "modelType", entity.ModelType },
                { "shortName", entity.ShortName },
                { "foundYear", entity.FoundYear },
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            if (entity.ParentId != null)
                doc.Add("parentId", entity.ParentId);

            return doc;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 查找所有对象
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Department> FindAll()
        {
            return base.FindListByField<string>("modelType", this.modelType);
        }

        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="entity">部门对象</param>
        public override void Create(Department entity)
        {
            entity.ModelType = this.modelType;
            entity.Status = 0;
            base.Create(entity);
        }
        #endregion //Method
    }
}