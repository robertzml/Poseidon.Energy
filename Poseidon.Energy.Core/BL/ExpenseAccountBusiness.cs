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
        /// 设置电表
        /// </summary>
        /// <param name="id">账户ID</param>
        /// <param name="meters">电表列表</param>
        public void SetElectricMeters(string id, List<ElectricMeter> meters)
        {
            var entity = this.baseDal.FindById(id);
            entity.ElectricMeters = meters;
            this.baseDal.Update(entity);
        }

        /// <summary>
        /// 设置水表
        /// </summary>
        /// <param name="id">账户ID</param>
        /// <param name="meters">水表列表</param>
        public void SetWaterMeters(string id, List<WaterMeter> meters)
        {
            var entity = this.baseDal.FindById(id);
            entity.WaterMeters = meters;
            this.baseDal.Update(entity);
        }
        #endregion //Method
    }
}
