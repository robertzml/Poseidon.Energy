using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.IDAL
{
    using Poseidon.Base.Framework;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 能源计量记录数据访问接口
    /// </summary>
    internal interface IMeasureRecordRepository : IBaseDAL<MeasureRecord>
    {
        /// <summary>
        /// 删除未选择部门能源计量记录
        /// </summary>
        /// <param name="measureId">能源计量ID</param>
        /// <param name="departmentIds">已选择部门ID</param>
        /// <returns></returns>
        bool DeleteNotIn(string measureId, List<string> departmentIds);
    }
}
