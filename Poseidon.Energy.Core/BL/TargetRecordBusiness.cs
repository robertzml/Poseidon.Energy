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
        /// 查找指标记录
        /// </summary>
        /// <param name="targetId">指标计划ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public IEnumerable<TargetRecord> FindByDepartment(string targetId, string departmentId)
        {
            var dal = this.baseDal as ITargetRecordRepository;
            return dal.FindList(targetId, departmentId);
        }

        /// <summary>
        /// 查找指标记录
        /// </summary>
        /// <param name="targetId">指标计划ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <param name="type">指标类型</param>
        /// <returns></returns>
        public TargetRecord FindByDepartment(string targetId, string departmentId, int type)
        {
            var dal = this.baseDal as ITargetRecordRepository;
            return dal.FindOne(targetId, departmentId, type);
        }

        /// <summary>
        /// 查找部门历年指标记录
        /// </summary>
        /// <param name="departmentId">部门ID</param>
        /// <param name="type">指标类型</param>
        /// <returns></returns>
        public IEnumerable<TargetRecord> FindByDepartment(string departmentId, int type)
        {
            var dal = this.baseDal as ITargetRecordRepository;
            return dal.FindList(departmentId, type);
        }

        /// <summary>
        /// 导入人数记录
        /// </summary>
        /// <param name="populationId">人数统计ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public List<StaffTarget> ImportPopulation(string populationId, string departmentId)
        {
            List<StaffTarget> data = new List<StaffTarget>();
            PopulationRecordBusiness prBusienss = new PopulationRecordBusiness();
            var popRecord = prBusienss.FindByDepartment(populationId, departmentId);

            if (popRecord == null)
                return data;

            foreach (var item in popRecord.Details)
            {
                StaffTarget st = new StaffTarget();
                st.Name = item.Name;
                st.Code = item.Code;
                st.Number = item.Number;
                st.UnitPrice = 0.6m;

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
            List<AllowanceTarget> data = new List<AllowanceTarget>();

            var frBusiness = new FundRecordBusiness();
            var fundRecord = frBusiness.FindByDepartment(fundId, departmentId);
            if (fundRecord == null)
                return data;

            if (fundRecord.HorizontalResearch > 0)
            {
                AllowanceTarget at = new AllowanceTarget();
                at.Name = "横向科研";
                at.Code = EnergyConstant.HorizontalResearchCode;
                at.Cardinal = fundRecord.HorizontalResearch;
                at.Factor = 0.0005m;
                at.MonthCount = 1;
                at.MonthKilowatt = 1;
                at.UnitPrice = 0.6m;
                at.YearAmount = Math.Round(at.Factor * at.Cardinal, 0);
                at.YearKilowatt = Math.Round(at.YearAmount / at.UnitPrice, 0);
                at.Remark = "";
                data.Add(at);
            }
            if (fundRecord.VerticalResearch > 0)
            {
                AllowanceTarget at = new AllowanceTarget();
                at.Name = "纵向科研";
                at.Code = EnergyConstant.VerticalResearchCode;
                at.Cardinal = fundRecord.VerticalResearch;
                at.Factor = 0.0025m;
                at.MonthCount = 1;
                at.MonthKilowatt = 1;
                at.UnitPrice = 0.6m;
                at.YearAmount = Math.Round(at.Factor * at.Cardinal, 0);
                at.YearKilowatt = Math.Round(at.YearAmount / at.UnitPrice, 0);
                at.Remark = "";

                data.Add(at);
            }

            return data;
        }

        /// <summary>
        /// 添加指标记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(TargetRecord entity, ILoginUser user)
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
        public void CreateMany(string targetId, List<string> departmentIds, ILoginUser user)
        {
            var dal = this.baseDal as ITargetRecordRepository;

            var records = dal.FindListByField("targetId", targetId);
            dal.DeleteNotIn(targetId, departmentIds, 1);

            DateTime now = DateTime.Now;
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
                    dt.SchoolTake = 0.4M;
                    dt.SelfTake = 0.6M;
                    dt.PlanQuantum = 0;
                    dt.PlanAmount = 0;
                    dt.Remark = "";
                    dt.CreateBy = new UpdateStamp
                    {
                        UserId = user.Id,
                        Name = user.Name,
                        Time = now
                    };
                    dt.UpdateBy = new UpdateStamp
                    {
                        UserId = user.Id,
                        Name = user.Name,
                        Time = now
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
        public (bool success, string errorMessage) Update(TargetRecord entity, ILoginUser user)
        {
            var dal = this.baseDal as ITargetRecordRepository;

            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };

            return dal.Update(entity);
        }

        /// <summary>
        /// 更新记录相关人数指标
        /// </summary>
        /// <param name="id">指标记录ID</param>
        /// <param name="staffTarget">人数指标</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        /// <remarks>
        /// 删除金额度数为0项
        /// </remarks>
        public bool UpdateStaffTarget(string id, List<StaffTarget> staffTarget, ILoginUser user)
        {
            var dal = this.baseDal as ITargetRecordRepository;

            var targetRecord = dal.FindById(id);

            foreach (var item in staffTarget)
            {
                item.Remark = item.Remark ?? "";
            }
            staffTarget.RemoveAll(r => r.YearAmount <= 0 && r.YearKilowatt <= 0);

            targetRecord.StaffTarget = staffTarget;
            targetRecord.PlanQuantum = targetRecord.StaffTarget.Sum(r => r.YearKilowatt) + targetRecord.AllowanceTarget.Sum(r => r.YearKilowatt);
            targetRecord.PlanAmount = targetRecord.StaffTarget.Sum(r => r.YearAmount) + targetRecord.AllowanceTarget.Sum(r => r.YearAmount);
            targetRecord.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };

            return dal.Update(targetRecord).success;
        }

        /// <summary>
        /// 更新记录相关补贴指标
        /// </summary>
        /// <param name="id">指标记录ID</param>
        /// <param name="allowanceTarget">补贴指标</param>
        /// <param name="user">操作用户</param>
        /// <returns>删除金额度数为0项</returns>
        public bool UpdateAllowanceTarget(string id, List<AllowanceTarget> allowanceTarget, ILoginUser user)
        {
            var dal = this.baseDal as ITargetRecordRepository;

            var targetRecord = dal.FindById(id);
            foreach (var item in allowanceTarget)
            {
                item.Remark = item.Remark ?? "";
            }
            allowanceTarget.RemoveAll(r => r.YearAmount <= 0 && r.YearKilowatt <= 0);
            targetRecord.AllowanceTarget = allowanceTarget;
            targetRecord.PlanQuantum = targetRecord.StaffTarget.Sum(r => r.YearKilowatt) + targetRecord.AllowanceTarget.Sum(r => r.YearKilowatt);
            targetRecord.PlanAmount = targetRecord.StaffTarget.Sum(r => r.YearAmount) + targetRecord.AllowanceTarget.Sum(r => r.YearAmount);
            targetRecord.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };

            return dal.Update(targetRecord).success;
        }

        /// <summary>
        /// 删除指标计划相关记录
        /// </summary>
        /// <param name="targetId">指标计划ID</param>
        /// <returns></returns>
        public bool DeleteByTarget(string targetId)
        {
            return this.baseDal.DeleteMany("targetId", targetId).success;
        }
        #endregion //Method
    }
}
