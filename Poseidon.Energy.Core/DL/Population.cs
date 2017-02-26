using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 人数统计类
    /// </summary>
    public class Population : BusinessEntity
    {
        /// <summary>
        /// 年份
        /// </summary>
        [Display(Name = "年份")]
        public int Year { get; set; }

        /// <summary>
        /// 归属时间
        /// </summary>
        [Display(Name = "归属时间")]
        public string BelongTime { get; set; }
    }
}
