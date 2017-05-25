using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 人数记录类
    /// </summary>
    public class PopulationRecord : BusinessEntity
    {
        /// <summary>
        /// 人数统计ID
        /// </summary>
        [Display(Name = "人数统计ID")]
        public string PopulationId { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [Display(Name = "部门ID")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 人数详情
        /// </summary>
        [Display(Name = "人数详情")]
        public List<PopulationDetail> Details { get; set; }
    }

    /// <summary>
    /// 人数记录详情
    /// </summary>
    public class PopulationDetail : BaseEntity
    {
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
        /// 数量
        /// </summary>
        [Display(Name = "数量")]
        public int Number { get; set; }

        /// <summary>
        /// 是否计入总数
        /// </summary>
        [Display(Name = "是否计入总数")]
        public bool InTotal { get; set; }
    }
}
