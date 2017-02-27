using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 计划指标类
    /// </summary>
    /// <remarks>
    /// 能源指标总类
    /// </remarks>
    public class PlanTarget : BusinessEntity
    {
        #region Property
        /// <summary>
        /// 年度
        /// </summary>
        [Display(Name = "年度")]
        public int Year { get; set; }

        /// <summary>
        /// 关联人数统计ID
        /// </summary>
        [Display(Name = "关联人数统计ID")]
        public string PopulationId { get; set; }

        /// <summary>
        /// 关联经费统计ID
        /// </summary>
        [Display(Name = "关联经费统计ID")]
        public string FundId { get; set; }
        #endregion //Property
    }
}
