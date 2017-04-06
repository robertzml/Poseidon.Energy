using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 人员指标类
    /// </summary>
    public class StaffTarget : BaseEntity
    {
        #region Property
        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "名称")]
        public string Name { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        [Display(Name = "代码")]
        public string Code { get; set; }

        /// <summary>
        /// 人数
        /// </summary>
        [Display(Name = "人数")]
        public int Number { get; set; }

        /// <summary>
        /// 月度数
        /// </summary>
        [Display(Name = "月度数")]
        public decimal MonthKilowatt { get; set; }

        /// <summary>
        /// 月数
        /// </summary>
        [Display(Name = "月数")]
        public int MonthCount { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [Display(Name = "单价")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 年指标度数
        /// </summary>
        [Display(Name = "年指标度数")]
        public decimal YearKilowatt { get; set; }

        /// <summary>
        /// 年指标金额
        /// </summary>
        [Display(Name = "年指标金额")]
        public decimal YearAmount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }
        #endregion //Property
    }
}
