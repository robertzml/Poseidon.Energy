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
    /// 结算记录数据访问接口
    /// </summary>
    internal interface ISettlementRecordRepository : IBaseDAL<SettlementRecord>
    {
        /// <summary>
        /// 查找单条记录
        /// </summary>
        /// <param name="settlementId">能源结算ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        SettlementRecord FindOne(string settlementId, string departmentId);

        /// <summary>
        /// 删除未选择部门能源结算记录
        /// </summary>
        /// <param name="settlementId">能源结算ID</param>
        /// <param name="departmentIds">已选择部门ID</param>
        /// <returns></returns>
        bool DeleteNotIn(string settlementId, List<string> departmentIds);
    }
}
