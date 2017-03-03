using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;
    using Poseidon.Core.DL;

    /// <summary>
    /// 支出账户
    /// </summary>
    public class ExpenseAccount : Organization
    {
        /// <summary>
        /// 包含水表
        /// </summary>
        [Display(Name = "包含水表")]
        public List<WaterMeter> WaterMeters { get; set; }
    }
}
