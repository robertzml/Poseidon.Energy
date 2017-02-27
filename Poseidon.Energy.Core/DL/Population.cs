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
        #region Property
        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "名称")]
        public string Name { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        [Display(Name = "年度")]
        public int Year { get; set; }

        /// <summary>
        /// 归属时间
        /// </summary>
        [Display(Name = "归属时间")]
        public string BelongTime { get; set; }
        #endregion //Property
    }
}
