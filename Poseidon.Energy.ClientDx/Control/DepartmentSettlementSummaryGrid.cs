using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 部门结算汇总表格控件
    /// </summary>
    public partial class DepartmentSettlementSummaryGrid : WinEntityGrid<DepartmentSettlementSummary>
    {
        #region Constructor
        public DepartmentSettlementSummaryGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置能源类型
        /// </summary>
        /// <param name="type"></param>
        public void SetEnergyType(EnergyType type)
        {
            string postfix = ""; ;
            switch (type)
            {
                case EnergyType.Electric:
                    postfix = "度";
                    break;
                case EnergyType.Water:
                    postfix = "吨";
                    break;
            }

            this.colUnitPrice.Caption = string.Format("单价(元/{0})", postfix);
            this.colPlanQuantum.Caption = string.Format("计划用量({0})", postfix);
            this.colSettleQuantum.Caption = string.Format("结算用量(度)", postfix);
            this.colRemainQuantum.Caption = string.Format("剩余用量{0}", postfix);
        }
        #endregion //Method
    }
}
