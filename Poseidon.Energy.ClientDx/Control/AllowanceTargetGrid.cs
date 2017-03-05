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
                var st = bsEntity[i] as AllowanceTarget;

                if (st.Code == EnergyConstant.HorizontalResearchCode || st.Code == EnergyConstant.VerticalResearchCode)
                    st.YearKilowatt = Math.Round(st.YearAmount / st.UnitPrice, 0);
                else
                {
                    st.YearKilowatt = Math.Round(st.Factor * st.MonthKilowatt * st.MonthCount, 0);
                    st.YearAmount = Math.Round(st.YearKilowatt * st.UnitPrice, 0);
                }
            }

            this.bsEntity.ResetBindings(false);
        }
        #endregion //Method
    }
}
