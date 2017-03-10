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
        #region Property
        /// <summary>
        /// 简称
        /// </summary>
        [Display(Name = "简称")]
        public string ShortName { get; set; }

        /// <summary>
        /// 能源类型
        /// </summary>
        [Display(Name = "能源类型")]
        public List<int> EnergyType { get; set; }

        /// <summary>
        /// 包含电表
        /// </summary>
        [Display(Name = "包含电表")]
        public List<ElectricMeter> ElectricMeters { get; set; }

        /// <summary>
        /// 包含水表
        /// </summary>
        [Display(Name = "包含水表")]
        public List<WaterMeter> WaterMeters { get; set; }
        #endregion //Property
    }
}
