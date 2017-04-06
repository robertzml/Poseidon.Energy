using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.IDAL
{
    using Poseidon.Base.Framework;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 经费记录数据访问接口
    /// </summary>
    internal interface IFundRecordRepository : IBaseDAL<FundRecord>
    {
        /// <summary>
        /// 查找经费记录
        /// </summary>
        /// <param name="fundId">统计ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        FundRecord FindOne(string fundId, string departmentId);
    }
}
