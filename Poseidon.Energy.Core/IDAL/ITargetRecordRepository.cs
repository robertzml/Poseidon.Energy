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
    /// 指标记录数据访问接口
    /// </summary>
    internal interface ITargetRecordRepository : IBaseDAL<TargetRecord>
    {
        /// <summary>
        /// 查找指标记录
        /// </summary>
        /// <param name="targetId">指标计划ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <param name="type">指标类型</param>
        /// <returns></returns>
        TargetRecord FindOne(string targetId, string departmentId, int type);

        /// <summary>
        /// 检查指标记录是否存在
        /// </summary>
        /// <param name="targetId">指标计划ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        bool Exist(string targetId, string departmentId);

        /// <summary>
        /// 删除未选择部门指标记录
        /// </summary>
        /// <param name="targetId">计划指标ID</param>
        /// <param name="departmentIds">已选择部门ID</param>
        /// <returns></returns>
        bool DeleteNotIn(string targetId, List<string> departmentIds);
    }
}
