using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 支出账户
    /// </summary>
    public class ExpenseAccount : ObjectEntity
    {
        /// <summary>
        /// 包含表具
        /// </summary>
        [Display(Name = "包含表具")]
        public List<Ammeter> Ammeters { get; set; }
    }
}
