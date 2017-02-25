using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    /// <summary>
    /// 表具类
    /// </summary>
    public class Ammeter
    {
        /// <summary>
        /// 表名
        /// </summary>
        [Display(Name = "表名")]
        public string Name { get; set; }

        /// <summary>
        /// 客户编号
        /// </summary>
        [Display(Name = "客户编号")]
        public string Number { get; set; }

        /// <summary>
        /// 户名
        /// </summary>
        [Display(Name = "户名")]
        public string AccountName { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [Display(Name = "地址")]
        public string Address { get; set; }
    }
}
