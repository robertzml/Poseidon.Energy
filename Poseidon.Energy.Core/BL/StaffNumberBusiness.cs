﻿using System;
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
    public class StaffNumberBusiness : AbsctractBusiness<StaffNumber>
    {
        #region Constructor
        /// <summary>
        /// 人数记录业务类
        /// </summary>
        public StaffNumberBusiness()
        {
            this.baseDal = RepositoryFactory<IStaffNumberRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 根据人数统计查找记录
        /// </summary>
        /// <param name="populationId">人数统计ID</param>
        /// <returns></returns>
        public IEnumerable<StaffNumber> FindByPopulationId(string populationId)
        {
            return this.baseDal.FindListByField("populationId", populationId);
        }

        /// <summary>
        /// 更新人数记录
        /// </summary>
        /// <param name="data">人数记录</param>
        public void Update(List<StaffNumber> data)
        {
            foreach (var item in data)
            {
                if (item.Establishment + item.PersonnelAgency + item.PostDoctor + item.InlandShort + item.LaborDispatch +
                    item.ForeignShort + item.ForeignLong + item.Undergraduate + item.Master + item.ProfessionalMaster + item.Doctor + item.AbroadStudent == 0)
                    continue;
                else
                    this.baseDal.Upsert(item);
            }
        }
        #endregion //Method
    }
}
