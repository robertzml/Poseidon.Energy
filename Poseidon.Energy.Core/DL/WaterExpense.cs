using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 水费支出类
    /// </summary>
    public class WaterExpense : BusinessEntity
    {
        #region Property
        /// <summary>
        /// 账户ID
        /// </summary>
        [Display(Name = "账户ID")]
        public string AccountId { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        [Display(Name = "费用类型")]
        public int FeeType { get; set; }

        /// <summary>
        /// 归属日期
        /// </summary>
        [Display(Name = "归属日期")]
        public DateTime BelongDate { get; set; }

        /// <summary>
        /// 票据日期
        /// </summary>
        [Display(Name = "票据日期")]
        public DateTime TicketDate { get; set; }

        /// <summary>
        /// 用水量
        /// </summary>
        [Display(Name = "用水量")]
        public decimal TotalQuantity { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// 详细记录
        /// </summary>
        [Display(Name = "详细记录")]
        public List<WaterExpenseRecord> Records { get; set; }
        #endregion //Property
    }

    /// <summary>
    /// 水费支出详细记录
    /// </summary>
    public class WaterExpenseRecord : BaseEntity
    {
        #region Property
        /// <summary>
        /// 水表编号
        /// </summary>
        [Display(Name = "水表编号")]
        public string MeterNumber { get; set; }

        /// <summary>
        /// 水表名称
        /// </summary>
        [Display(Name = "水表名称")]
        public string MeterName { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        [Display(Name = "费用类型")]
        public int FeeType { get; set; }

        /// <summary>
        /// 上期数
        /// </summary>
        [Display(Name = "上期数")]
        public decimal Previous { get; set; }

        /// <summary>
        /// 本期数
        /// </summary>
        [Display(Name = "本期数")]
        public decimal Current { get; set; }

        /// <summary>
        /// 用量
        /// </summary>
        [Display(Name = "用量")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [Display(Name = "单价")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        public decimal Amount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }
        #endregion //Property
    }
}
