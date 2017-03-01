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

        /// <summary>
        /// 添加一组指标记录
        /// </summary>
        /// <param name="targetId">指标计划ID</param>
        /// <param name="ids">部门ID列表</param>
        public void Create(string targetId, List<string> ids)
        {
            var dal = this.baseDal as ITargetRecordRepository;

            foreach (var item in ids)
            {
                bool exist = dal.Exist(targetId, item);
                if (exist)
                    continue;

                TargetRecord dt = new TargetRecord();
                dt.DepartmentId = item;
                dt.TargetId = targetId;
                dt.TotalKilowatt = 0;
                dt.TotalAmount = 0;
                dt.Remark = "";

                dal.Create(dt);
            }
        }
        #endregion //Method
    }
}
