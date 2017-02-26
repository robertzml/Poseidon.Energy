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
    /// 人数记录数据访问类
    /// </summary>
    internal class PopulationRecordRepository : AbsctractDALMongo<PopulationRecord>, IPopulationRecordRepository
    {
        #region Constructor
        /// <summary>
        /// 人数记录数据访问类
        /// </summary>
        public PopulationRecordRepository()
        {
            this.collectionName = "energy_populationRecord";
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override PopulationRecord DocToEntity(BsonDocument doc)
        {
            PopulationRecord entity = new PopulationRecord();
            entity.Id = doc["_id"].ToString();
            entity.PopulationId = doc["populationId"].ToString();
            entity.DepartmentId = doc["departmentId"].ToString();
            entity.Establishment = doc["establishment"].ToInt32();
            entity.PersonnelAgency = doc["personnelAgency"].ToInt32();
            entity.PostDoctor = doc["postDoctor"].ToInt32();
            entity.InlandShort = doc["inlandShort"].ToInt32();
            entity.LaborDispatch = doc["laborDispatch"].ToInt32();
            entity.ForeignShort = doc["foreignShort"].ToInt32();
            entity.ForeignLong = doc["foreignLong"].ToInt32();
            entity.Undergraduate = doc["undergraduate"].ToInt32();
            entity.Master = doc["master"].ToInt32();
            entity.ProfessionalMaster = doc["professionalMaster"].ToInt32();
            entity.Doctor = doc["doctor"].ToInt32();
            entity.AbroadStudent = doc["abroadStudent"].ToInt32();
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
        protected override BsonDocument EntityToDoc(PopulationRecord entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "populationId", entity.PopulationId },
                { "departmentId", entity.DepartmentId },
                { "establishment", entity.Establishment },
                { "personnelAgency", entity.PersonnelAgency },
                { "postDoctor", entity.PostDoctor },
                { "inlandShort", entity.InlandShort },
                { "laborDispatch", entity.LaborDispatch },
                { "foreignShort", entity.ForeignShort },
                { "foreignLong", entity.ForeignLong },
                { "undergraduate", entity.Undergraduate },
                { "master", entity.Master },
                { "professionalMaster", entity.ProfessionalMaster },
                { "doctor", entity.Doctor },
                { "abroadStudent", entity.AbroadStudent },
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
        /// 添加人数记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        public override void Create(PopulationRecord entity)
        {
            entity.CreateTime = DateTime.Now;
            entity.UpdateTime = entity.CreateTime;
            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑人数记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override bool Update(PopulationRecord entity)
        {
            entity.UpdateTime = DateTime.Now;
            return base.Update(entity);
        }
        #endregion //Method
    }
}
