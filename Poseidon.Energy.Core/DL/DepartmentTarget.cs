using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 部门用能指标类
    /// </summary>
    public class DepartmentTarget : BusinessEntity
    {
        #region Proprety
        /// <summary>
        /// 计划指标ID
        /// </summary>
        [Display(Name = "计划指标ID")]
        public string PlanIndexId { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [Display(Name = "部门ID")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 人数指标
        /// </summary>
        [Display(Name = "人数指标")]
        public List<StaffTarget> StaffIndex { get; set; }

        /// <summary>
        /// 补贴
        /// </summary>
        [Display(Name = "补贴")]
        public List<Allowance> Allowance { get; set; }
        #endregion //Property
    }

    /// <summary>
    /// 人数指标
    /// </summary>
    public class StaffTarget
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "名称")]
        public string Name { get; set; }
    }

    /// <summary>
    /// 补贴
    /// </summary>
    public class Allowance
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "名称")]
        public string Name { get; set; }
    }
}
