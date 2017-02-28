using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;

    /// <summary>
    /// 部门指标业务类
    /// </summary>
    public class DepartmentTargetBusiness : AbsctractBusiness<DepartmentTarget>
    {
        #region Constructor
        /// <summary>
        /// 部门指标业务类
        /// </summary>
        public DepartmentTargetBusiness()
        {
            this.baseDal = RepositoryFactory<IDepartmentTargetRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 查找指标计划包含部门
        /// </summary>
        /// <param name="planTargetId">指标计划ID</param>
        /// <returns></returns>
        public IEnumerable<DepartmentTarget> FindByPlanTarget(string planTargetId)
        {
            return this.baseDal.FindListByField("planTargetId", planTargetId);
        }

        /// <summary>
        /// 添加一组部门指标
        /// </summary>
        /// <param name="planTargetId">指标计划ID</param>
        /// <param name="ids">部门ID列表</param>
        public void Create(string planTargetId, List<string> ids)
        {
            var dal = this.baseDal as IDepartmentTargetRepository;

            foreach (var item in ids)
            {
                bool exist = dal.Exist(planTargetId, item);
                if (exist)
                    continue;

                DepartmentTarget dt = new DepartmentTarget();
                dt.DepartmentId = item;
                dt.PlanTargetId = planTargetId;
                dt.TotalKilowatt = 0;
                dt.TotalAmount = 0;
                dt.Remark = "";

                dal.Create(dt);
            }
        }
        #endregion //Method
    }
}
