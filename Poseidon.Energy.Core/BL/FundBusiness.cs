﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;

    /// <summary>
    /// 经费统计业务类
    /// </summary>
    public class FundBusiness : AbstractBusiness<Fund>
    {
        #region Constructor
        /// <summary>
        /// 人数统计业务类
        /// </summary>
        public FundBusiness()
        {
            this.baseDal = RepositoryFactory<IFundRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 添加经费统计
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Fund entity, ILoginUser user)
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

            this.baseDal.Create(entity);
        }

        /// <summary>
        /// 编辑经费统计
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public (bool success, string errorMessage) Update(Fund entity, ILoginUser user)
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
        /// 删除经费统计
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override (bool success, string errorMessage) Delete(Fund entity)
        {
            // delete the records
            FundRecordBusiness recordBusiness = new FundRecordBusiness();
            recordBusiness.DeleteByFund(entity.Id);

            return base.Delete(entity);
        }
        #endregion //Method
    }
}
