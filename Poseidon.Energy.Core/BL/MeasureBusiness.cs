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
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 能源计量业务类
    /// </summary>
    public class MeasureBusiness : AbstractBusiness<Measure>
    {
        #region Constructor
        /// <summary>
        /// 能源计量业务类
        /// </summary>
        public MeasureBusiness()
        {
            this.baseDal = RepositoryFactory<IMeasureRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 按能源类型获取用能计量
        /// </summary>
        /// <param name="energyType">能源类型</param>
        /// <returns></returns>
        public IEnumerable<Measure> FindByEnergyType(int energyType)
        {
            return this.baseDal.FindListByField("energyType", energyType);
        }

        /// <summary>
        /// 按年度查找能源计量
        /// </summary>
        /// <param name="year">年度</param>
        /// <param name="energyType">能源类型</param>
        /// <returns></returns>
        public IEnumerable<Measure> FindByYear(int year, EnergyType energyType)
        {
            var dal = this.baseDal as IMeasureRepository;
            return dal.FindByYear(year, (int)energyType);
        }

        /// <summary>
        /// 添加能源计量
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public Measure Create(Measure entity, ILoginUser user)
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
        /// 编辑能源计量
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(Measure entity, ILoginUser user)
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
        /// 删除能源计量
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override bool Delete(Measure entity)
        {
            // delete the records
            MeasureRecordBusiness recordBusiness = new MeasureRecordBusiness();
            recordBusiness.DeleteByMeasure(entity.Id);

            return base.Delete(entity);
        }
        #endregion //Method
    }
}
