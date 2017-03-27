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
    /// 能源计量记录类
    /// </summary>
    public class MeasureRecord : BusinessEntity
    {
        #region Property
        /// <summary>
        /// 能源计量ID
        /// </summary>
        [Display(Name = "能源计量ID")]
        public string MeasureId { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [Display(Name = "部门ID")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 用量
        /// </summary>
        [Display(Name = "用量")]
        public decimal Quantum { get; set; }

        /// <summary>
        /// 是否计入合计
        /// </summary>
        [Display(Name = "是否计入合计")]
        public bool Included { get; set; }
        #endregion //Property
    }
}
