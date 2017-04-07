using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.ClientDx
{
    /// <summary>
    /// 结算报表模型
    /// </summary>
    public class SettlementReportModel
    {
        #region Property
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
        /// 能源类型
        /// </summary>
        [Display(Name = "能源类型")]
        public string Unit { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [Display(Name = "单价")]
        public string UnitPrice { get; set; }

        /// <summary>
        /// 时间段
        /// </summary>
        [Display(Name = "时间段")]
        public string Term { get; set; }

        /// <summary>
        /// 年度计划用电量
        /// </summary>
        [Display(Name = "年度计划用电量")]
        public decimal PlanQuantum { get; set; }

        /// <summary>
        /// 年度计划金额
        /// </summary>
        [Display(Name = "年度计划金额")]
        public decimal PlanAmount { get; set; }

        /// <summary>
        /// 上期累计用电量
        /// </summary>
        [Display(Name = "上期累计用电量")]
        public decimal LastQuantum { get; set; }

        /// <summary>
        /// 上期累计金额
        /// </summary>
        [Display(Name = "上期累计金额")]
        public decimal LastAmount { get; set; }

        /// <summary>
        /// 用电量
        /// </summary>
        [Display(Name = "用电量")]
        public decimal Quantum { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        public decimal Amount { get; set; }

        /// <summary>
        /// 剩余用电量
        /// </summary>
        [Display(Name = "剩余用电量")]
        public decimal EndQuantum { get; set; }

        /// <summary>
        /// 剩余金额
        /// </summary>
        [Display(Name = "剩余金额")]
        public decimal EndAmount { get; set; }
        #endregion //Property
    }
}
