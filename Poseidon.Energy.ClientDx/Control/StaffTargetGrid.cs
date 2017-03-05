using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 人员指标表格控件
    /// </summary>
    public partial class StaffTargetGrid : WinEntityGrid<StaffTarget>
    {
        #region Constructor
        public StaffTargetGrid()
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
                var st = bsEntity[i] as StaffTarget;

                st.YearKilowatt = Math.Round(st.Number * st.MonthKilowatt * st.MonthCount, 0);
                st.YearAmount = Math.Round(st.YearKilowatt * st.UnitPrice, 0);
            }

            this.bsEntity.ResetBindings(false);
        }
        #endregion //Method
    }
}
