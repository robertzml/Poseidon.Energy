using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.Utility;

    /// <summary>
    /// 电费支出票据类
    /// </summary>
    public class ElectricExpense : BusinessEntity
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
        [Dict("Energy.Expense.FeeType")]
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
        /// 用电量
        /// </summary>
        [Display(Name = "用电量")]
        public decimal TotalQuantity { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// 功率因数奖
        /// </summary>
        [Display(Name = "功率因数奖")]
        public decimal TotalPrize { get; set; }

        /// <summary>
        /// 详细记录
        /// </summary>
        [Display(Name = "详细记录")]
        public List<ElectricExpenseRecord> Records { get; set; }
        #endregion //Property
    }

    /// <summary>
    /// 电费支出详细记录
    /// </summary>
    public class ElectricExpenseRecord : BaseEntity
    {
        #region Property
        /// <summary>
        /// 电表编号
        /// </summary>
        [Display(Name = "电表编号")]
        public string MeterNumber { get; set; }

        /// <summary>
        /// 电表名称
        /// </summary>
        [Display(Name = "电表名称")]
        public string MeterName { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        [Dict("Energy.Expense.FeeType")]
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
        /// 倍率
        /// </summary>
        [Display(Name = "倍率")]
        public decimal Multiple { get; set; }

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
        /// 功率因数奖
        /// </summary>
        [Display(Name = "功率因数奖")]
        public decimal Prize { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }
        #endregion //Property
    }
}
