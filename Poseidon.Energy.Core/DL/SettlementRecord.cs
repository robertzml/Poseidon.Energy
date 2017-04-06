using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.Utility;

    /// <summary>
    /// 结算记录类
    /// </summary>
    public class SettlementRecord : BusinessEntity
    {
        #region Property
        /// <summary>
        /// 结算ID
        /// </summary>
        [Display(Name = "结算ID")]
        public string SettlementId { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [Display(Name = "部门ID")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 能源类型
        /// </summary>
        [Display(Name = "能源类型")]
        public int EnergyType { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [Display(Name = "单价")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 期初用电量
        /// </summary>
        [Display(Name = "期初用电量")]
        public decimal BeginQuantum { get; set; }

        /// <summary>
        /// 期初金额
        /// </summary>
        [Display(Name = "期初金额")]
        public decimal BeginAmount { get; set; }

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
        #endregion //Property
    }
}
