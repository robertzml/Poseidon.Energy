using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Poseidon.Energy.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 人数记录类
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
        /// 在职在编人数
        /// </summary>
        [Display(Name = "在职在编")]
        public int Establishment { get; set; }

        /// <summary>
        /// 人事代理人数
        /// </summary>
        [Display(Name = "人事代理")]
        public int PersonnelAgency { get; set; }

        /// <summary>
        /// 博士后人数
        /// </summary>
        [Display(Name = "博士后")]
        public int PostDoctor { get; set; }

        /// <summary>
        /// 国内短期聘用人数
        /// </summary>
        [Display(Name = "国内短期聘用")]
        public int InlandShort { get; set; }

        /// <summary>
        /// 劳务(人才)派遣人数
        /// </summary>
        [Display(Name = "劳务(人才)派遣")]
        public int LaborDispatch { get; set; }

        /// <summary>
        /// 外籍短期聘用人数
        /// </summary>
        [Display(Name = "外籍短期聘用")]
        public int ForeignShort { get; set; }

        /// <summary>
        /// 外籍长期聘用人数
        /// </summary>
        [Display(Name = "外籍长期聘用")]
        public int ForeignLong { get; set; }

        /// <summary>
        /// 本科生人数
        /// </summary>
        [Display(Name = "本科生")]
        public int Undergraduate { get; set; }

        /// <summary>
        /// 硕士生人数
        /// </summary>
        [Display(Name = "硕士生")]
        public int Master { get; set; }

        /// <summary>
        /// 专业硕士生人数
        /// </summary>
        [Display(Name = "专业硕士生")]
        public int ProfessionalMaster { get; set; }

        /// <summary>
        /// 博士生人数
        /// </summary>
        [Display(Name = "博士生")]
        public int Doctor { get; set; }

        /// <summary>
        /// 留学生人数
        /// </summary>
        [Display(Name = "留学生")]
        public int AbroadStudent { get; set; }
    }
}
