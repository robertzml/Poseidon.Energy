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
    /// 结算用量汇总模型类
    /// </summary>
    public class SettlementQuantumSummary : BaseEntity
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
        /// 年度计划用量
        /// </summary>
        [Display(Name = "年度计划用量")]
        public decimal PlanQuantum { get; set; }

        /// <summary>
        /// 一季度用量
        /// </summary>
        [Display(Name = "一季度用量")]
        public decimal FirstQuarter { get; set; }

        /// <summary>
        /// 二季度用量
        /// </summary>
        [Display(Name = "二季度用量")]
        public decimal SecondQuarter { get; set; }

        /// <summary>
        /// 三季度用量
        /// </summary>
        [Display(Name = "三季度用量")]
        public decimal ThirdQuarter { get; set; }

        /// <summary>
        /// 四季度用量
        /// </summary>
        [Display(Name = "四季度用量")]
        public decimal FourthQuarter { get; set; }

        /// <summary>
        /// 累计用量
        /// </summary>
        [Display(Name = "累计用量")]
        public decimal TotalQuantum { get; set; }

        /// <summary>
        /// 剩余用量
        /// </summary>
        [Display(Name = "剩余用量")]
        public decimal RemainQuantum { get; set; }
        #endregion //Property
    }
}
