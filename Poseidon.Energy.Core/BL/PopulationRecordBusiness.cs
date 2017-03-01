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
    /// 人数记录业务类
    /// </summary>
    public class PopulationRecordBusiness : AbsctractBusiness<PopulationRecord>
    {
        #region Constructor
        /// <summary>
        /// 人数记录业务类
        /// </summary>
        public PopulationRecordBusiness()
        {
            this.baseDal = RepositoryFactory<IPopulationRecordRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 根据人数统计查找记录
        /// </summary>
        /// <param name="populationId">人数统计ID</param>
        /// <returns></returns>
        public IEnumerable<PopulationRecord> FindByPopulationId(string populationId)
        {
            return this.baseDal.FindListByField("populationId", populationId);
        }

        /// <summary>
        /// 按统计、部门查找记录
        /// </summary>
        /// <param name="populationId">统计ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public PopulationRecord FindByDepartment(string populationId, string departmentId)
        {
            var dal = this.baseDal as IPopulationRecordRepository;
            return dal.FindOne(populationId, departmentId);
        }

        /// <summary>
        /// 更新人数记录
        /// </summary>
        /// <param name="data">人数记录</param>
        public void Update(List<PopulationRecord> data)
        {
            foreach (var item in data)
            {
                if (item.Establishment + item.PersonnelAgency + item.PostDoctor + item.InlandShort + item.LaborDispatch +
                    item.ForeignShort + item.ForeignLong + item.Undergraduate + item.Master + item.ProfessionalMaster + item.Doctor + item.AbroadStudent == 0)
                {
                    if (item.Id != null)
                        this.baseDal.Delete(item);
                }
                else
                {
                    if (item.Id == null)
                        this.baseDal.Create(item);
                    else
                        this.baseDal.Update(item);
                }
            }
        }
        #endregion //Method
    }
}
