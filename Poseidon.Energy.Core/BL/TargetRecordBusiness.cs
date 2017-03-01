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
    /// 指标记录业务类
    /// </summary>
    public class TargetRecordBusiness : AbsctractBusiness<TargetRecord>
    {
        #region Constructor
        /// <summary>
        /// 部门指标业务类
        /// </summary>
        public TargetRecordBusiness()
        {
            this.baseDal = RepositoryFactory<ITargetRecordRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 查找指标记录
        /// </summary>
        /// <param name="targetId">指标计划ID</param>
        /// <returns></returns>
        public IEnumerable<TargetRecord> FindByTarget(string targetId)
        {
            return this.baseDal.FindListByField("targetId", targetId);
        }

        public List<StaffTarget> ImportPopulation(string populationId, string departmentId)
        {
            var dal = RepositoryFactory<IPopulationRecordRepository>.Instance;
            var popRecord = dal.FindOne(populationId, departmentId);

            List<StaffTarget> data = new List<StaffTarget>();

            StaffTarget st = new StaffTarget();
            st.Name = "在编";
            st.Code = "establishment";
            st.Count = 10;

            data.Add(st);

            return data;
        }

        /// <summary>
        /// 添加一组指标记录
        /// </summary>
        /// <param name="targetId">指标计划ID</param>
        /// <param name="ids">部门ID列表</param>
        /// <remarks>
        /// 增加新记录，删除未选择部门记录
        /// </remarks>
        public void Set(string targetId, List<string> ids)
        {
            var dal = this.baseDal as ITargetRecordRepository;

            var records = dal.FindListByField("targetId", targetId);
            dal.DeleteNotIn(targetId, ids);

            foreach (var item in ids)
            {
                if (records.Any(r => r.DepartmentId == item))
                    continue;
                else
                {
                    TargetRecord dt = new TargetRecord();
                    dt.DepartmentId = item;
                    dt.TargetId = targetId;
                    dt.TotalKilowatt = 0;
                    dt.TotalAmount = 0;
                    dt.Remark = "";

                    dal.Create(dt);
                }
            }
        }
        #endregion //Method
    }
}
