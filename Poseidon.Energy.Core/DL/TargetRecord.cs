using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 指标记录类
    /// </summary>
    public class TargetRecord : BusinessEntity
    {
        #region Proprety
        /// <summary>
        /// 计划指标ID
        /// </summary>
        [Display(Name = "计划指标ID")]
        public string TargetId { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [Display(Name = "部门ID")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 类型, 1:电指标  2:水指标
        /// </summary>
        [Display(Name = "类型")]
        public int Type { get; set; }

        /// <summary>
        /// 经费本
        /// </summary>
        [Display(Name = "经费本")]
        public string Finance { get; set; }

        /// <summary>
        /// 人数指标
        /// </summary>
        [Display(Name = "人数指标")]
        public List<StaffTarget> StaffTarget { get; set; }

        /// <summary>
        /// 补贴
        /// </summary>
        [Display(Name = "补贴")]
        public List<AllowanceTarget> AllowanceTarget { get; set; }

        /// <summary>
        /// 总用电量
        /// </summary>
        [Display(Name = "总用电量")]
        public decimal TotalQuantum { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [Display(Name = "总金额")]
        public decimal TotalAmount { get; set; }
        #endregion //Property
    }
}
