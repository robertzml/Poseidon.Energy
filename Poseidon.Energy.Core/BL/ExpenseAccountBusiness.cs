using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;

    /// <summary>
    /// 支出账户业务类
    /// </summary>
    public class ExpenseAccountBusiness : AbsctractBusiness<ExpenseAccount>
    {
        #region Constructor
        /// <summary>
        /// 支出账户业务类
        /// </summary>
        public ExpenseAccountBusiness()
        {
            this.baseDal = RepositoryFactory<IExpenseAccountRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置水表
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="meters">水表列表</param>
        public void SetWaterMeters(ExpenseAccount entity, List<WaterMeter> meters)
        {
            entity.WaterMeters = meters;
            this.baseDal.Update(entity);
        }
        #endregion //Method
    }
}
