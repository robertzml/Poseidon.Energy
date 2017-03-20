using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 能源计量总类
    /// </summary>
    public class Measure : BusinessEntity
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

        /// <summary>
        /// 归属时间
        /// </summary>
        [Display(Name = "归属时间")]
        public string BelongTime { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [Display(Name = "起始时间")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 截至时间
        /// </summary>
        [Display(Name = "截至时间")]
        public DateTime EndTime { get; set; }
        #endregion //Property
    }
}