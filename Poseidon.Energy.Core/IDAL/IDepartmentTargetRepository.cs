using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.IDAL
{
    using Poseidon.Base.Framework;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 部门指标数据访问接口
    /// </summary>
    internal interface IDepartmentTargetRepository : IBaseDAL<DepartmentTarget>
    {
        /// <summary>
        /// 查找部门指标
        /// </summary>
        /// <param name="planTargetId">指标计划ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        DepartmentTarget FindOne(string planTargetId, string departmentId);

        /// <summary>
        /// 检查部门指标是否存在
        /// </summary>
        /// <param name="planTargetId">指标计划ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        bool Exist(string planTargetId, string departmentId);
    }
}
