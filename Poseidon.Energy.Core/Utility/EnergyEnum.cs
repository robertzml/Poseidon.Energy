using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.Utility
{
    /// <summary>
    /// 能源类型
    /// </summary>
    public enum EnergyType
    {
        /// <summary>
        /// 电
        /// </summary>
        [Display(Name = "电")]
        Electric = 1,

        /// <summary>
        /// 水
        /// </summary>
        [Display(Name = "水")]
        Water = 2
    }

    /// <summary>
    /// 结算类型
    /// </summary>
    public enum SettlementType
    {
        /// <summary>
        /// 年度
        /// </summary>
        [Display(Name = "年度")]
        Annual = 1,

        /// <summary>
        /// 季度
        /// </summary>
        [Display(Name = "季度")]
        Quarter = 2,

        /// <summary>
        /// 月度
        /// </summary>
        [Display(Name = "月度")]
        Monthly = 3
    }
}
