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
        /// 添加一组空能源结算记录
        /// </summary>
        /// <param name="settlementId">能源结算ID</param>
        /// <param name="departmentIds">部门ID列表</param>
        /// <param name="user">操作用户</param>
        public void CreateMany(string settlementId, List<string> departmentIds, LoginUser user)
        {
            var dal = this.baseDal as ISettlementRecordRepository;

            var records = dal.FindListByField("settlementId", settlementId);
            dal.DeleteNotIn(settlementId, departmentIds);

            DateTime now = DateTime.Now;
            foreach (var item in departmentIds)
            {
                if (records.Any(r => r.DepartmentId == item))
                    continue;

                Create(settlementId, item, EnergyType.Electric, user);
                //SettlementRecord record = new SettlementRecord();
                //record.SettlementId = settlementId;
                //record.DepartmentId = item;
                //record.EnergyType = 1;
                //record.UnitPrice = 0;
                //record.BeginQuantum = 0;
                //record.BeginAmount = 0;
                //record.Quantum = 0;
                //record.Amount = 0;
                //record.Remark = "";
                //record.CreateBy = new UpdateStamp
                //{
                //    UserId = user.Id,
                //    Name = user.Name,
                //    Time = now
                //};
                //record.UpdateBy = new UpdateStamp
                //{
                //    UserId = user.Id,
                //    Name = user.Name,
                //    Time = now
                //};
                //record.Status = 0;

                //dal.Create(record);
            }
        }


        /// <summary>
        /// 添加默认结算记录
        /// </summary>
        /// <param name="settlementId">结算ID</param>
        /// <param name="departmentId">部门ID</param>
        /// <param name="energyType">能源类型</param>
        /// <param name="user">操作用户</param>
        public void Create(string settlementId, string departmentId, EnergyType energyType, LoginUser user)
        {
            var dal = this.baseDal as ISettlementRecordRepository;

            SettlementBusiness settlementBusiness = new SettlementBusiness();
            var settlement = settlementBusiness.FindById(settlementId);

            DateTime now = DateTime.Now;
            SettlementRecord record = new SettlementRecord();
            record.SettlementId = settlementId;
            record.DepartmentId = departmentId;
            record.EnergyType = (int)energyType;
            record.UnitPrice = 0.6m;
            record.Quantum = 0;
            record.Amount = 0;
            record.SchoolTakeAmount = 0;
            record.SelfTakeAmount = 0;
            record.Remark = "";
            record.Status = 0;
            record.CreateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = now
            };
            record.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = now
            };

            if (string.IsNullOrEmpty(settlement.PreviousId)) //first settle
            {
                record.BeginQuantum = 0;
                record.BeginAmount = 0;
            }
            else
            {
                var previous = BusinessFactory<SettlementBusiness>.Instance.FindById(settlement.PreviousId);

            }

            dal.Create(record);
            return;
        }

        /// <summary>
        /// 删除能源结算相关记录
        /// </summary>
        /// <param name="settlementId">能源结算ID</param>
        /// <returns></returns>
        public bool DeleteBySettlement(string settlementId)
        {
            return this.baseDal.DeleteMany("settlementId", settlementId);
        }
        #endregion //Method
    }
}
