using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.IDAL
{
    using Poseidon.Base.Framework;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 部门数据访问接口
    /// </summary>
    internal interface IDepartmentRepository : IBaseDAL<Department>
    {
        /// <summary>
        /// 根据ID查找部门
        /// </summary>
        /// <param name="departmentIds">部门ID列表</param>
        /// <returns></returns>
        IEnumerable<Department> FindWithIds(List<string> departmentIds);
    }
}
