using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.Utility
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 结算金额汇总模型类
    /// </summary>
    public class SettlementAmountSummary : BaseEntity
    {
        #region Property
        /// <summary>
        /// 部门名称
        /// </summary>
        [Display(Name = "部门名称")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        [Display(Name = "年度")]
        public int Year { get; set; }

        /// <summary>
        /// 能源类型
        /// </summary>
        [Display(Name = "能源类型")]
        public string EnergyType { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [Display(Name = "单价")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 年度计划金额
        /// </summary>
        [Display(Name = "年度计划金额")]
        public decimal PlanAmount { get; set; }

        /// <summary>
        /// 一季度金额
        /// </summary>
        [Display(Name = "一季度金额")]
        public decimal FirstQuarter { get; set; }

        /// <summary>
        /// 二季度金额
        /// </summary>
        [Display(Name = "二季度金额")]
        public decimal SecondQuarter { get; set; }

        /// <summary>
        /// 三季度金额
        /// </summary>
        [Display(Name = "三季度金额")]
        public decimal ThirdQuarter { get; set; }

        /// <summary>
        /// 四季度金额
        /// </summary>
        [Display(Name = "四季度金额")]
        public decimal FourthQuarter { get; set; }

        /// <summary>
        /// 累计金额
        /// </summary>
        [Display(Name = "累计金额")]
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// 剩余金额
        /// </summary>
        [Display(Name = "剩余金额")]
        public decimal RemainAmount { get; set; }

        /// <summary>
        /// 学校承担金额
        /// </summary>
        [Display(Name = "学校承担金额")]
        public decimal SchoolTake { get; set; }

        /// <summary>
        /// 部门承担金额
        /// </summary>
        [Display(Name = "部门承担金额")]
        public decimal SelfTake { get; set; }
        #endregion //Property
    }
}
