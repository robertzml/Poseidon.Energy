using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 能源结算业务类
    /// </summary>
    public class SettlementBusiness : AbstractBusiness<Settlement>
    {
        #region Constructor
        /// <summary>
        /// 能源结算业务类
        /// </summary>
        public SettlementBusiness()
        {
            this.baseDal = RepositoryFactory<ISettlementRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取指标化相关能源结算
        /// </summary>
        /// <param name="targetId">指标计划ID</param>
        /// <returns></returns>
        public IEnumerable<Settlement> FindByTarget(string targetId)
        {
            return this.baseDal.FindListByField("targetId", targetId);
        }

        /// <summary>
        /// 按年度获取顺序能源结算
        /// </summary>
        /// <param name="year">年度</param>
        /// <returns></returns>
        public IEnumerable<Settlement> FindByYear(int year)
        {
            var settlements = this.baseDal.FindListByField("year", year);

            List<Settlement> data = new List<Settlement>();
            var first = settlements.Single(r => string.IsNullOrEmpty(r.PreviousId));

            data.Add(first);

            string previousId = first.Id;
            bool flag = true;
            while (flag)
            {
                var item = settlements.SingleOrDefault(r => r.PreviousId == previousId);
                if (item != null)
                {
                    data.Add(item);
                    previousId = item.Id;
                }
                else
                    flag = false;
            }

            return data;
        }

        /// <summary>
        /// 获取能源结算用量汇总
        /// </summary>
        /// <param name="year">年度</param>
        /// <param name="energyType">能源类型</param>
        /// <param name="departments">部门列表</param>
        /// <returns></returns>
        public IEnumerable<SettlementQuantumSummary> GetQuantumSummary(int year, EnergyType energyType, List<Department> departments)
        {
            List<SettlementQuantumSummary> data = new List<SettlementQuantumSummary>();

            SettlementRecordBusiness srBusiness = new SettlementRecordBusiness();

            var settlements = FindByYear(year).ToList();

            foreach (var item in departments)
            {
                SettlementQuantumSummary summary = new SettlementQuantumSummary();
                summary.DepartmentName = item.Name;
                summary.EnergyType = energyType.DisplayName();

                bool flag = false;

                for (int i = 0; i < settlements.Count; i++)
                {
                    var settle = settlements[i];
                    var record = srBusiness.FindByDepartment(settle.Id, item.Id, energyType);
                    if (record == null)
                        continue;

                    switch (i)
                    {
                        case 0:
                            summary.PlanQuantum = record.BeginQuantum;
                            summary.FirstQuarter = record.Quantum;
                            break;
                        case 1:
                            summary.SecondQuarter = record.Quantum;
                            break;
                        case 2:
                            summary.ThirdQuarter = record.Quantum;
                            break;
                        case 3:
                            summary.FourthQuarter = record.Quantum;
                            break;
                    }
                    flag = true;
                }

                summary.TotalQuantum = summary.FirstQuarter + summary.SecondQuarter + summary.ThirdQuarter + summary.FourthQuarter;
                summary.RemainQuantum = summary.PlanQuantum - summary.TotalQuantum;

                if (flag)
                    data.Add(summary);
            }

            return data;
        }

        /// <summary>
        /// 添加能源结算
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public Settlement Create(Settlement entity, LoginUser user)
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
            entity.Status = 0;
            return base.Create(entity);
        }

        /// <summary>
        /// 编辑能源结算
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(Settlement entity, LoginUser user)
        {
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            return base.Update(entity);
        }

        /// <summary>
        /// 删除能源结算
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override bool Delete(Settlement entity)
        {
            // delete the records
            SettlementRecordBusiness recordBusiness = new SettlementRecordBusiness();
            recordBusiness.DeleteBySettlement(entity.Id);

            return base.Delete(entity);
        }
        #endregion //Method
    }
}
