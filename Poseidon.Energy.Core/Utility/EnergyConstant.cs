using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.Utility
{
    /// <summary>
    /// 常量类
    /// </summary>
    public static class EnergyConstant
    {
        #region Field
        /// <summary>
        /// 指标化部门分组代码
        /// </summary>
        public static readonly string TargetDepartmentGroupCode = "TargetDepartment";

        /// <summary>
        /// 经费统计单位分组代码
        /// </summary>
        public static readonly string FundDepartmentGroupCode = "FundDepartment";

        /// <summary>
        /// 人数统计单位分组代码
        /// </summary>
        public static readonly string PopulationDepartmentGroupCode = "PopulationDepartment";

        /// <summary>
        /// 能源计量单位分组代码
        /// </summary>
        public static readonly string MeasureDepartmentGroupCode = "MeasureDepartment";

        /// <summary>
        /// 支出账户分组代码
        /// </summary>
        public static readonly string ExpenseAccountGroupCode = "ExpenseAccount";
        
        /// <summary>
        /// 教工人数字典代码
        /// </summary>
        public static readonly string TeacherDictCode = "Energy.Target.TeacherType";

        /// <summary>
        /// 学生人数字典代码
        /// </summary>
        public static readonly string StudentDictCode = "Energy.Target.StudentType";

        /// <summary>
        /// 横向科研补贴代码
        /// </summary>
        public static readonly string HorizontalResearchCode = "HorizontalResearch";

        /// <summary>
        /// 纵向科研补贴代码
        /// </summary>
        public static readonly string VerticalResearchCode = "VerticalResearch";
        #endregion //Field
    }
}
