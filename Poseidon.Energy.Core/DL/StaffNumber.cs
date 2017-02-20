using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 人数统计类
    /// </summary>
    public class StaffNumber : BusinessEntity
    {
        /// <summary>
        /// 汇总ID
        /// </summary>
        [Display(Name = "汇总ID")]
        public string PopulationId { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [Display(Name = "部门ID")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 人事代理人数
        /// </summary>
        [Display(Name = "人事代理人数")]
        public int PersonnelAgency { get; set; }

        /// <summary>
        /// 本科生人数
        /// </summary>
        [Display(Name = "本科生人数")]
        public int Undergraduate { get; set; }

        /// <summary>
        /// 硕士生人数
        /// </summary>
        [Display(Name = "硕士生人数")]
        public int Master { get; set; }

        /// <summary>
        /// 专业硕士生人数
        /// </summary>
        [Display(Name = "专业硕士生人数")]
        public int ProfessionalMaster { get; set; }

        /// <summary>
        /// 博士生人数
        /// </summary>
        [Display(Name = "博士生人数")]
        public int Doctor { get; set; }

        /// <summary>
        /// 留学生人数
        /// </summary>
        [Display(Name = "留学生人数")]
        public int AbroadStudent { get; set; }
    }
}
