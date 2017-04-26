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
    /// 能源结算用量汇总表格控件
    /// </summary>
    public partial class SettlementQuantumSummaryGrid : WinEntityGrid<SettlementQuantumSummary>
    {
        #region Field
        /// <summary>
        /// 是否显示年度
        /// </summary>
        private bool showYear = false;
        #endregion //Field

        #region Constructor
        public SettlementQuantumSummaryGrid()
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

            this.colPlanQuantum.Caption = string.Format("年度计划用量({0})", postfix);
            this.colFirstQuarter.Caption = string.Format("一季度用量({0})", postfix);
            this.colSecondQuarter.Caption = string.Format("二季度用量({0})", postfix);
            this.colThirdQuarter.Caption = string.Format("三季度用量({0})", postfix);
            this.colFourthQuarter.Caption = string.Format("四季度用量({0})", postfix);
            this.colTotalQuantum.Caption = string.Format("累计用量({0})", postfix);
            this.colRemainQuantum.Caption = string.Format("剩余用量({0})", postfix);
        }
        #endregion //Method

        #region Event
        private void SettlementQuantumSummaryGrid_Load(object sender, EventArgs e)
        {
            this.colYear.Visible = showYear;
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否显示年度
        /// </summary>
        [Description("是否显示年度"), Category("界面"), Browsable(true)]
        public bool ShowYear
        {
            get
            {
                return this.showYear;
            }
            set
            {
                this.showYear = value;
            }
        }
        #endregion //Property
    }
}
