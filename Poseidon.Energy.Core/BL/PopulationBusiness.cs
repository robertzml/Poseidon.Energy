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
    /// 人数统计业务类
    /// </summary>
    public class PopulationBusiness : AbsctractBusiness<Population>
    {
        #region Constructor
        /// <summary>
        /// 人数统计业务类
        /// </summary>
        public PopulationBusiness()
        {
            this.baseDal = RepositoryFactory<IPopulationRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 删除人数统计
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override bool Delete(Population entity)
        {
            // delete the records
            var repo = RepositoryFactory<IPopulationRecordRepository>.Instance;
            repo.DeleteMany<string>("populationId", entity.Id);

            return base.Delete(entity);
        }
        #endregion //Method
    }
}
