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
    /// 经费记录业务类
    /// </summary>
    public class FundRecordBusiness : AbstractBusiness<FundRecord>
    {
        #region Constructor
        /// <summary>
        /// 人数统计业务类
        /// </summary>
        public FundRecordBusiness()
        {
            this.baseDal = RepositoryFactory<IFundRecordRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 根据经费统计查找记录
        /// </summary>
        /// <param name="fundId">经费统计ID</param>
        /// <returns></returns>
        public IEnumerable<FundRecord> FindByFundId(string fundId)
        {
            return this.baseDal.FindListByField("fundId", fundId);
        }

        /// <summary>
        /// 更新经费记录
        /// </summary>
        /// <param name="data">经费记录</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public void Update(List<FundRecord> data, LoginUser user)
        {
            foreach (var item in data)
            {
                if (item.HorizontalResearch + item.VerticalResearch == 0)
                {
                    if (item.Id != null)
                        this.baseDal.Delete(item);
                }
                else
                {
                    if (item.Id == null)
                    {
                        item.CreateBy = new UpdateStamp
                        {
                            UserId = user.Id,
                            Name = user.Name,
                            Time = DateTime.Now
                        };
                        item.UpdateBy = new UpdateStamp
                        {
                            UserId = user.Id,
                            Name = user.Name,
                            Time = DateTime.Now
                        };
                        this.baseDal.Create(item);
                    }
                    else
                    {
                        item.UpdateBy = new UpdateStamp
                        {
                            UserId = user.Id,
                            Name = user.Name,
                            Time = DateTime.Now
                        };
                        this.baseDal.Update(item);
                    }
                }
            }
        }
        #endregion //Method
    }
}
