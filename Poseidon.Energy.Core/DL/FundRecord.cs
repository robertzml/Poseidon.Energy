using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 经费记录类
    /// </summary>
    public class FundRecord : BusinessEntity
    {
        #region Property
        /// <summary>
        /// 经费统计ID
        /// </summary>
        [Display(Name = "经费统计ID")]
        public string FundId { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [Display(Name = "部门ID")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 横向科研
        /// </summary>
        [Display(Name = "横向科研")]
        public decimal HorizontalResearch { get; set; }

        /// <summary>
        /// 纵向科研
        /// </summary>
        [Display(Name = "纵向科研")]
        public decimal VerticalResearch { get; set; }
        #endregion //Property
    }
}
