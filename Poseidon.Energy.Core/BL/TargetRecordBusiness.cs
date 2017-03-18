using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Core.Utility;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 指标记录业务类
    /// </summary>
    public class TargetRecordBusiness : AbstractBusiness<TargetRecord>
    {
        #region Constructor
        /// <summary>
        /// 指标记录业务类
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
                at.Code = EnergyConstant.HorizontalResearchCode;
                at.Factor = fundRecord.HorizontalResearch;
                at.MonthCount = 1;
                at.MonthKilowatt = 1;
                at.YearAmount = Math.Round(at.Factor * 0.0005m, 0);

                data.Add(at);
            }
            if (fundRecord.VerticalResearch > 0)
            {
                AllowanceTarget at = new AllowanceTarget();
                at.Name = "纵向科研";
                at.Code = EnergyConstant.VerticalResearchCode;
                at.Factor = fundRecord.VerticalResearch;
                at.MonthCount = 1;
                at.MonthKilowatt = 1;
                at.YearAmount = Math.Round(at.Factor * 0.0025m, 0);

                data.Add(at);
            }

            return data;
        }

        /// <summary>
        /// 添加指标记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(TargetRecord entity, LoginUser user)
        {
            entity.CreateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            base.Create(entity);
        }

        /// <summary>
        /// 添加一组指标记录
        /// </summary>
        /// <param name="targetId">指标计划ID</param>
        /// <param name="ids">部门ID列表</param>
        /// <param name="user">操作用户</param>
        /// <remarks>
        /// 增加新记录，删除未选择部门记录，增加记录为电指标
        /// </remarks>
        public void CreateMany(string targetId, List<string> departmentIds, LoginUser user)
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
                    // 创建默认指标
                    TargetRecord dt = new TargetRecord();
                    dt.TargetId = targetId;
                    dt.DepartmentId = item;
                    dt.Type = 1;
                    dt.Finance = "";
                    dt.SchoolTake = 0.6M;
                    dt.SelfTake = 0.4M;
                    dt.PlanQuantum = 0;
                    dt.PlanAmount = 0;
                    dt.Remark = "";
                    dt.CreateBy = new UpdateStamp
                    {
                        UserId = user.Id,
                        Name = user.Name,
                        Time = DateTime.Now
                    };
                    dt.UpdateBy = new UpdateStamp
                    {
                        UserId = user.Id,
                        Name = user.Name,
                        Time = DateTime.Now
                    };
                    dt.Status = 0;

                    dal.Create(dt);
                }
            }
        }

        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(TargetRecord entity, LoginUser user)
        {
            var dal = this.baseDal as ITargetRecordRepository;

            entity.PlanQuantum = entity.StaffTarget.Sum(r => r.YearKilowatt) + entity.AllowanceTarget.Sum(r => r.YearKilowatt);
            entity.PlanAmount = entity.StaffTarget.Sum(r => r.YearAmount) + entity.AllowanceTarget.Sum(r => r.YearAmount);
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };

            return dal.Update(entity);
        }
        #endregion //Method
    }
}
