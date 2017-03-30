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
        /// 归属时间
        /// </summary>
        [Display(Name = "归属时间")]
        public string BelongTime { get; set; }

        public decimal QuantumFirst { get; set; }

        public decimal AmountFirst { get; set; }


        public decimal QuantumSecond { get; set; }


        public decimal AmountSecond { get; set; }
        #endregion //Proeprty
    }
}
