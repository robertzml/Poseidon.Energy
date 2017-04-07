using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Energy.ClientDx.Utility
{
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 报表相关工具类
    /// </summary>
    public static class ReportUtil
    {
        #region Method
        /// <summary>
        /// 能源结算记录转报表模型
        /// </summary>
        /// <param name="departmentName">部门名称</param>
        /// <param name="settlement">能源结算</param>
        /// <param name="entity">能源结算记录</param>
        /// <param name="targetRecord">指标记录</param>
        /// <returns></returns>
        public static SettlementReportModel SettlementReportTranslate(string departmentName, Settlement settlement, SettlementRecord entity, TargetRecord targetRecord)
        {
            SettlementReportModel model = new SettlementReportModel();
            model.DepartmentName = departmentName;
            model.Term = settlement.BelongTime;
        
            if (entity.EnergyType == (int)EnergyType.Electric)
            {
                model.EnergyType = "电";
                model.Unit = "度";
                model.UnitPrice = string.Format("{0} 元/度", entity.UnitPrice);
            }
            else if (entity.EnergyType == (int)EnergyType.Water)
            {
                model.EnergyType = "水";
                model.Unit = "吨";
                model.UnitPrice = string.Format("{0} 元/吨", entity.UnitPrice);
            }

            if (targetRecord == null)
            {
                model.PlanQuantum = 0;
                model.PlanAmount = 0;
            }
            else
            {
                model.PlanQuantum = targetRecord.PlanQuantum;
                model.PlanAmount = targetRecord.PlanAmount;
            }

            model.LastQuantum = model.PlanQuantum - entity.BeginQuantum;
            model.LastAmount = model.PlanAmount - entity.BeginAmount;

            model.Quantum = entity.Quantum;
            model.Amount = entity.Amount;

            model.EndQuantum = entity.BeginQuantum - entity.Quantum;
            model.EndAmount = entity.BeginAmount - entity.Amount;

            return model;
        }
        #endregion //Method
    }
}
