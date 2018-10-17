using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.IDAL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 能源结算记录数据访问类
    /// </summary>
    public class SettlementRecordBusiness : AbstractBusiness<SettlementRecord>
    {
        #region Constructor
        /// <summary>
        /// 能源结算记录数据访问类
        /// </summary>
        public SettlementRecordBusiness()
        {
            this.baseDal = RepositoryFactory<ISettlementRecordRepository>.Instance;
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 获取记录期初数据
        /// </summary>
        /// <param name="settlement">能源结算</param>
        /// <param name="record">能源结算记录</param>
        /// <returns>期初用量，期初金额</returns>
        private Tuple<decimal, decimal> GetBeginData(Settlement settlement, SettlementRecord record)
        {
            TargetRecordBusiness trBusiness = new TargetRecordBusiness();
            var targetRecord = trBusiness.FindByDepartment(settlement.TargetId, record.DepartmentId, record.EnergyType);

            decimal beginQuantum = 0;
            decimal beginAmount = 0;

            if (string.IsNullOrEmpty(settlement.PreviousId))
            {
                if (targetRecord != null)
                {
                    beginQuantum = targetRecord.PlanQuantum;
                    beginAmount = targetRecord.PlanAmount;
                }
                else
                {
                    beginQuantum = 0;
                    beginAmount = 0;
                }
            }
            else
            {
                SettlementBusiness settlementBusiness = new SettlementBusiness();
                var previous = settlementBusiness.FindById(settlement.PreviousId);

                var dal = this.baseDal as ISettlementRecordRepository;
                var previousRecord = dal.FindOne(previous.Id, record.DepartmentId, record.EnergyType);

                beginQuantum = previousRecord.BeginQuantum - previousRecord.Quantum;
                beginAmount = previousRecord.BeginAmount - previousRecord.Amount;
            }

            return new Tuple<decimal, decimal>(beginQuantum, beginAmount);
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 根据结算查找记录
        /// </summary>
        /// <param name="settlementId">结算ID</param>
        /// <returns></returns>
        public IEnumerable<SettlementRecord> FindBySettlement(string settlementId)
        {
            return this.baseDal.FindListByField("settlementId", settlementId);
        }

        /// <summary>
        /// 根据结算查找记录
        /// </summary>
        /// <param name="settlementId">结算ID</param>
        /// <param name="energyType">能源类型</param>
        /// <returns></returns>
        public IEnumerable<SettlementRecord> FindBySettlement(string settlementId, EnergyType energyType)
        {
            var dal = this.baseDal as ISettlementRecordRepository;
            return dal.FindList(settlementId, (int)energyType);
        }

        /// <summary>
        /// 查找部门年度结算记录
        /// </summary>
        /// <param name="departmentId">部门ID</param>
        /// <param name="year">年度</param>
        /// <param name="energyType">能源类型</param>
        /// <returns></returns>
        public IEnumerable<SettlementRecord> FindByDepartment(string departmentId, int year, EnergyType energyType)
        {
            SettlementBusiness settleBusiness = new SettlementBusiness();
            var settles = settleBusiness.FindByYear(year);

            List<SettlementRecord> data = new List<SettlementRecord>();
            foreach (var settle in settles)
            {
                var record = FindByDepartment(settle.Id, departmentId, energyType);
                data.Add(record);
            }

            return data;
        }

        /// <summary>
        /// 根据部门查找记录
        /// </summary>
        /// <param name="settlementId">结算ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <param name="energyType">能源类型</param>
        /// <returns></returns>
        public SettlementRecord FindByDepartment(string settlementId, string departmentId, EnergyType energyType)
        {
            var dal = this.baseDal as ISettlementRecordRepository;
            return dal.FindOne(settlementId, departmentId, (int)energyType);
        }

        /// <summary>
        /// 添加一组空用电能源结算记录
        /// </summary>
        /// <param name="settlementId">能源结算ID</param>
        /// <param name="departmentIds">部门ID列表</param>
        /// <param name="user">操作用户</param>
        public void CreateMany(string settlementId, List<string> departmentIds, ILoginUser user)
        {
            var dal = this.baseDal as ISettlementRecordRepository;

            var records = dal.FindListByField("settlementId", settlementId);
            dal.DeleteNotIn(settlementId, departmentIds, (int)EnergyType.Electric);

            DateTime now = DateTime.Now;
            foreach (var item in departmentIds)
            {
                if (records.Any(r => r.DepartmentId == item && r.EnergyType == (int)EnergyType.Electric))
                    continue;

                SettlementRecord record = new SettlementRecord();
                record.SettlementId = settlementId;
                record.DepartmentId = item;
                record.EnergyType = (int)EnergyType.Electric;
                record.UnitPrice = 0.6m;
                record.Remark = "";

                Create(record, user);
            }
        }

        /// <summary>
        /// 添加默认结算记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(SettlementRecord entity, ILoginUser user)
        {
            var dal = this.baseDal as ISettlementRecordRepository;

            SettlementBusiness settlementBusiness = new SettlementBusiness();
            var settlement = settlementBusiness.FindById(entity.SettlementId);

            TargetRecordBusiness trBusiness = new TargetRecordBusiness();
            var targetRecord = trBusiness.FindByDepartment(settlement.TargetId, entity.DepartmentId, entity.EnergyType);

            DateTime now = DateTime.Now;

            entity.Quantum = 0;
            entity.Amount = 0;
            entity.Status = 0;
            entity.CreateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = now
            };
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = now
            };

            var begin = GetBeginData(settlement, entity);
            entity.BeginQuantum = begin.Item1;
            entity.BeginAmount = begin.Item2;

            dal.Create(entity);
            return;
        }

        /// <summary>
        /// 批量编辑记录
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="user"></param>
        public void Update(List<SettlementRecord> entity, ILoginUser user)
        {
            foreach (var item in entity)
            {
                if (item.Id == null)
                    continue;

                item.UpdateBy = new UpdateStamp
                {
                    UserId = user.Id,
                    Name = user.Name,
                    Time = DateTime.Now
                };
                this.baseDal.Update(item);
            }
        }

        /// <summary>
        /// 删除能源结算相关记录
        /// </summary>
        /// <param name="settlementId">能源结算ID</param>
        /// <returns></returns>
        public bool DeleteBySettlement(string settlementId)
        {
            return this.baseDal.DeleteMany("settlementId", settlementId).success;
        }
        #endregion //Method
    }
}
