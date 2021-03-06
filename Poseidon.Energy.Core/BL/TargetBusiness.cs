﻿using System;
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
    /// 计划指标业务类
    /// </summary>
    public class TargetBusiness : AbstractBusiness<Target>
    {
        #region Constructor
        /// <summary>
        /// 计划指标业务类
        /// </summary>
        public TargetBusiness()
        {
            this.baseDal = RepositoryFactory<ITargetRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 按年度查找指标计划
        /// </summary>
        /// <param name="year">年度</param>
        /// <returns></returns>
        public Target FindByYear(int year)
        {
            return this.baseDal.FindOneByField("year", year);
        }

        /// <summary>
        /// 添加计划指标
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Target entity, ILoginUser user)
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
            base.Create(entity);
        }

        /// <summary>
        /// 编辑计划指标
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public (bool success, string errorMessage) Update(Target entity, ILoginUser user)
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
        /// 删除计划指标
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override (bool success, string errorMessage) Delete(Target entity)
        {
            // delete the records
            TargetRecordBusiness recordBusiness = new TargetRecordBusiness();
            recordBusiness.DeleteByTarget(entity.Id);

            return base.Delete(entity);
        }
        #endregion //Method
    }
}
