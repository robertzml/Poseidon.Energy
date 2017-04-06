using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.IDAL
{
    using Poseidon.Base.Framework;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 人数记录数据访问接口
    /// </summary>
    internal interface IPopulationRecordRepository : IBaseDAL<PopulationRecord>
    {
        /// <summary>
        /// 查找人数记录
        /// </summary>
        /// <param name="populationId">统计ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        PopulationRecord FindOne(string populationId, string departmentId);
    }
}
