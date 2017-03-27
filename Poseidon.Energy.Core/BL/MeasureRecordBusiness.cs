using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;

    /// <summary>
    /// 能源计量记录业务类
    /// </summary>
    public class MeasureRecordBusiness : AbstractBusiness<MeasureRecord>
    {
        #region Constructor
        /// <summary>
        /// 能源计量记录业务类
        /// </summary>
        public MeasureRecordBusiness()
        {
            this.baseDal = RepositoryFactory<IMeasureRecordRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 根据能源计量查找记录
        /// </summary>
        /// <param name="measureId">能源计量ID</param>
        /// <returns></returns>
        public IEnumerable<MeasureRecord> FindByMeasureId(string measureId)
        {
            return this.baseDal.FindListByField("measureId", measureId);
        }

        /// <summary>
        /// 添加能源计量记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public MeasureRecord Create(MeasureRecord entity, LoginUser user)
        {
            entity.CreateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            entity.Status = 0;
            return base.Create(entity);
        }

        /// <summary>
        /// 添加一组能源计量记录
        /// </summary>
        /// <param name="measureId">能源计量ID</param>
        /// <param name="departmentIds">部门ID列表</param>
        /// <param name="user">操作用户</param>
        public void CreateMany(string measureId, List<string> departmentIds, LoginUser user)
        {
            var dal = this.baseDal as IMeasureRecordRepository;

            var records = dal.FindListByField("measureId", measureId);
            dal.DeleteNotIn(measureId, departmentIds);

            DateTime now = DateTime.Now;
            foreach (var item in departmentIds)
            {
                if (records.Any(r => r.DepartmentId == item))
                    continue;

                MeasureRecord record = new MeasureRecord();
                record.MeasureId = measureId;
                record.DepartmentId = item;
                record.Quantum = 0;
                record.Remark = "";
                record.CreateBy = new UpdateStamp
                {
                    UserId = user.Id,
                    Name = user.Name,
                    Time = now
                };
                record.UpdateBy = new UpdateStamp
                {
                    UserId = user.Id,
                    Name = user.Name,
                    Time = now
                };
                record.Status = 0;

                dal.Create(record);
            }
        }

        /// <summary>
        /// 编辑能源计量记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(MeasureRecord entity, LoginUser user)
        {
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            return base.Update(entity);
        }

        /// <summary>
        /// 批量编辑能源计量记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public void Update(List<MeasureRecord> entity, LoginUser user)
        {
            foreach (var item in entity)
            {
                if (item.Id == null)
                    continue;

                item.UpdateBy = new UpdateStamp
                {
                    UserId = user.Id,
                    Name = user.Name,
                    Time = DateTime.Now
                };
                this.baseDal.Update(item);
            }
        }
        #endregion //Method
    }
}
