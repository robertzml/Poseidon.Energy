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
    public class PopulationRecord : BusinessEntity
    {
        /// <summary>
        /// 人数统计ID
        /// </summary>
        [Display(Name = "人数统计ID")]
        public string PopulationId { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [Display(Name = "部门ID")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 人数详情
        /// </summary>
        [Display(Name = "人数详情")]
        public List<PopulationDetail> Details { get; set; }

        ///// <summary>
        ///// 在职在编人数
        ///// </summary>
        //[Display(Name = "在职在编")]
        //public int Establishment { get; set; }

        ///// <summary>
        ///// 人事代理人数
        ///// </summary>
        //[Display(Name = "人事代理")]
        //public int PersonnelAgency { get; set; }

        ///// <summary>
        ///// 博士后人数
        ///// </summary>
        //[Display(Name = "博士后")]
        //public int PostDoctor { get; set; }

        ///// <summary>
        ///// 国内短期聘用人数
        ///// </summary>
        //[Display(Name = "国内短期聘用")]
        //public int InlandShort { get; set; }

        ///// <summary>
        ///// 劳务(人才)派遣人数
        ///// </summary>
        //[Display(Name = "劳务(人才)派遣")]
        //public int LaborDispatch { get; set; }

        ///// <summary>
        ///// 外籍短期聘用人数
        ///// </summary>
        //[Display(Name = "外籍短期聘用")]
        //public int ForeignShort { get; set; }

        ///// <summary>
        ///// 外籍长期聘用人数
        ///// </summary>
        //[Display(Name = "外籍长期聘用")]
        //public int ForeignLong { get; set; }

        ///// <summary>
        ///// 本科生人数
        ///// </summary>
        //[Display(Name = "本科生")]
        //public int Undergraduate { get; set; }

        ///// <summary>
        ///// 硕士生人数
        ///// </summary>
        //[Display(Name = "硕士生")]
        //public int Master { get; set; }

        ///// <summary>
        ///// 专业硕士生人数
        ///// </summary>
        //[Display(Name = "专业硕士生")]
        //public int ProfessionalMaster { get; set; }

        ///// <summary>
        ///// 博士生人数
        ///// </summary>
        //[Display(Name = "博士生")]
        //public int Doctor { get; set; }

        ///// <summary>
        ///// 留学生人数
        ///// </summary>
        //[Display(Name = "留学生")]
        //public int AbroadStudent { get; set; }
    }

    /// <summary>
    /// 人数记录详情
    /// </summary>
    public class PopulationDetail
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "名称")]
        public string Name { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        [Display(Name = "代码")]
        public string Code { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [Display(Name = "数量")]
        public int Number { get; set; }
    }
}
