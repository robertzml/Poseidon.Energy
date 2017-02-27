using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 经费统计类
    /// </summary>
    public class Fund : BusinessEntity
    {
        #region Property
        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "名称")]
        public string Name { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        [Display(Name = "年度")]
        public int Year { get; set; }
        #endregion //Property
    }
}
