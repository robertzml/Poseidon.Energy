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
    /// 能源计量数据访问接口
    /// </summary>
    internal interface IMeasureRepository : IBaseDAL<Measure>
    {
        /// <summary>
        /// 按年度查找能源计量
        /// </summary>
        /// <param name="year">年度</param>
        /// <param name="energyType">能源类型</param>
        /// <returns></returns>
        IEnumerable<Measure> FindByYear(int year, int energyType);
    }
}
