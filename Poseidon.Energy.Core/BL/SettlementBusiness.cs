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
    /// 能源结算业务类
    /// </summary>
    public class SettlementBusiness : AbstractBusiness<Settlement>
    {
        #region Constructor
        /// <summary>
        /// 能源结算业务类
        /// </summary>
        public SettlementBusiness()
        {
            this.baseDal = RepositoryFactory<ISettlementRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取指标化相关能源结算
        /// </summary>
        /// <param name="targetId">指标计划ID</param>
        /// <returns></returns>
        public IEnumerable<Settlement> FindByTarget(string targetId)
        {
            return this.baseDal.FindListByField("targetId", targetId);
        }

        /// <summary>
        /// 添加能源结算
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public Settlement Create(Settlement entity, LoginUser user)
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
        /// 编辑能源结算
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(Settlement entity, LoginUser user)
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
        /// 删除能源结算
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override bool Delete(Settlement entity)
        {
            // delete the records
            SettlementRecordBusiness recordBusiness = new SettlementRecordBusiness();
            recordBusiness.DeleteBySettlement(entity.Id);

            return base.Delete(entity);
        }
        #endregion //Method
    }
}
