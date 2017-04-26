using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 能源比较模型
    /// </summary>
    public class EnergyCompare : BaseEntity
    {
        #region Property
        /// <summary>
        /// 选择
        /// </summary>
        [Display(Name = "选择")]
        public bool Include { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [Display(Name = "项目名称")]
        public string ItemName { get; set; }

        /// <summary>
        /// 用量1
        /// </summary>
        [Display(Name = "用量1")]
        public decimal QuantumFirst { get; set; }

        /// <summary>
        /// 金额1
        /// </summary>
        [Display(Name = "金额1")]
        public decimal AmountFirst { get; set; }

        /// <summary>
        /// 用量2
        /// </summary>
        [Display(Name = "用量2")]
        public decimal QuantumSecond { get; set; }

        /// <summary>
        /// 金额2
        /// </summary>
        [Display(Name = "金额2")]
        public decimal AmountSecond { get; set; }
        #endregion //Proeprty
    }
}
