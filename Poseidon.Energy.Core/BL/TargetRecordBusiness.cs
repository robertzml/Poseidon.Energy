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
        /// 导入人数记录
        /// </summary>
        /// <param name="populationId">人数统计ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public List<StaffTarget> ImportPopulation(string populationId, string departmentId)
        {
            var dal = RepositoryFactory<IPopulationRecordRepository>.Instance;
            var popRecord = dal.FindOne(populationId, departmentId);

            List<StaffTarget> data = new List<StaffTarget>();
            foreach (var item in popRecord.Details)
            {
                StaffTarget st = new StaffTarget();
                st.Name = item.Name;
                st.Code = item.Code;
                st.Number = item.Number;

                data.Add(st);
            }

            return data;
        }

        /// <summary>
        /// 导入经费记录
        /// </summary>
        /// <param name="fundId">经费统计ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public List<AllowanceTarget> ImportFund(string fundId, string departmentId)
        {
            var dal = RepositoryFactory<IFundRecordRepository>.Instance;
            var fundRecord = dal.FindOne(fundId, departmentId);

            List<AllowanceTarget> data = new List<AllowanceTarget>();
            if (fundRecord.HorizontalResearch > 0)
            {
                AllowanceTarget at = new AllowanceTarget();
                at.Name = "横向科研";
                at.Code = "HorizontalResearch";
                at.Factor = fundRecord.HorizontalResearch;
                at.YearAmount = at.Factor * 0.0005m;

                data.Add(at);
            }
            if (fundRecord.VerticalResearch > 0)
            {
                AllowanceTarget at = new AllowanceTarget();
                at.Name = "纵向科研";
                at.Code = "VerticalResearch";
                at.Factor = fundRecord.VerticalResearch;
                at.YearAmount = at.Factor * 0.0025m;

                data.Add(at);
            }

            return data;
        }

        /// <summary>
        /// 添加一组指标记录
        /// </summary>
        /// <param name="targetId">指标计划ID</param>
        /// <param name="ids">部门ID列表</param>
        /// <remarks>
        /// 增加新记录，删除未选择部门记录，增加记录为电指标
        /// </remarks>
        public void CreateMany(string targetId, List<string> departmentIds)
        {
            var dal = this.baseDal as ITargetRecordRepository;

            var records = dal.FindListByField("targetId", targetId);
            dal.DeleteNotIn(targetId, departmentIds);

            foreach (var item in departmentIds)
            {
                if (records.Any(r => r.DepartmentId == item))
                    continue;
                else
                {
                    TargetRecord dt = new TargetRecord();
                    dt.TargetId = targetId;
                    dt.DepartmentId = item;
                    dt.Type = 1;
                    dt.Finance = "";
                    dt.TotalQuantum = 0;
                    dt.TotalAmount = 0;
                    dt.Remark = "";

                    dal.Create(dt);
                }
            }
        }

        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override bool Update(TargetRecord entity)
        {
            var dal = this.baseDal as ITargetRecordRepository;

            entity.TotalQuantum = entity.StaffTarget.Sum(r => r.YearKilowatt);
            entity.TotalAmount = entity.StaffTarget.Sum(r => r.YearAmount);

            return dal.Update(entity);
        }
        #endregion //Method
    }
}
