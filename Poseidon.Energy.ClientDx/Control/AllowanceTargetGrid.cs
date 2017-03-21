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
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 补贴指标表格控件
    /// </summary>
    public partial class AllowanceTargetGrid : WinEntityGrid<AllowanceTarget>
    {
        #region Constructor
        public AllowanceTargetGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method       
        /// <summary>
        /// 计算总量
        /// </summary>
        public void UpdateTotal()
        {
            for (int i = 0; i < this.bsEntity.Count; i++)
            {
                var at = bsEntity[i] as AllowanceTarget;

                if (at.Code == EnergyConstant.HorizontalResearchCode || at.Code == EnergyConstant.VerticalResearchCode)
                {
                    at.YearAmount = Math.Round(at.Cardinal * at.Factor * at.MonthKilowatt * at.MonthCount, 0);
                    at.YearKilowatt = Math.Round(at.YearAmount / at.UnitPrice, 0);
                }
                else
                {
                    at.YearKilowatt = Math.Round(at.Cardinal * at.Factor * at.MonthKilowatt * at.MonthCount, 0);
                    at.YearAmount = Math.Round(at.YearKilowatt * at.UnitPrice, 0);
                }
            }

            this.bsEntity.ResetBindings(false);
        }
        #endregion //Method
    }
}
