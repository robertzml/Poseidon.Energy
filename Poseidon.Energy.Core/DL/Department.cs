using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Core.DL;

    /// <summary>
    /// 部门类
    /// </summary>
    public class Department : Organization
    {
        /// <summary>
        /// 模型类型
        /// </summary>
        [Display(Name = "模型类型")]
        public string ModelType { get; set; }

        /// <summary>
        /// 简称
        /// </summary>
        [Display(Name = "简称")]
        public string ShortName { get; set; }

        /// <summary>
        /// 建立年份
        /// </summary>
        [Display(Name = "建立年份")]
        public int FoundYear { get; set; }
    }
}
