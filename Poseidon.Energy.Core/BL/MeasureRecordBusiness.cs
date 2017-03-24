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
            return base.Create(entity);
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
        #endregion //Method
    }
}
