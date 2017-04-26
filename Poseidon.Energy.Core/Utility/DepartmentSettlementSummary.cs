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
    /// 部门结算汇总类
    /// </summary>
    public class DepartmentSettlementSummary : BaseEntity
    {
        #region Property
        /// <summary>
        /// 部门ID
        /// </summary>
        [Display(Name = "部门ID")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [Display(Name = "部门名称")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 能源类型
        /// </summary>
        [Display(Name = "能源类型")]
        public string EnergyType { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        [Display(Name = "年度")]
        public int Year { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [Display(Name = "单价")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 计划用量
        /// </summary>
        [Display(Name = "计划用量")]
        public decimal PlanQuantum { get; set; }

        /// <summary>
        /// 结算用量
        /// </summary>
        [Display(Name = "结算用量")]
        public decimal SettleQuantum { get; set; }

        /// <summary>
        /// 剩余用量
        /// </summary>
        [Display(Name = "剩余用量")]
        public decimal RemainQuantum { get; set; }

        /// <summary>
        /// 计划金额
        /// </summary>
        [Display(Name = "计划金额")]
        public decimal PlanAmount { get; set; }

        /// <summary>
        /// 结算金额
        /// </summary>
        [Display(Name = "结算金额")]
        public decimal SettleAmount { get; set; }

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
