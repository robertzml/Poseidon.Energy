using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 能源结算类
    /// </summary>
    public class Settlement : BusinessEntity
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
        /// 年度结算：1，季度结算：2
        /// </summary>
        [Display(Name = "结算类型")]
        public int Type { get; set; }

        /// <summary>
        /// 归属时间
        /// </summary>
        [Display(Name = "归属时间")]
        public string BelongTime { get; set; }

        /// <summary>
        /// 关联指标计划ID
        /// </summary>
        [Display(Name = "关联指标计划")]
        public string TargetId { get; set; }

        /// <summary>
        /// 上期结算ID
        /// </summary>
        [Display(Name = "上期结算")]
        public string PreviousId { get; set; }
        #endregion //Property
    }
}
