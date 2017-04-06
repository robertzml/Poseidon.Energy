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

    /// <summary>
    /// 人数详细记录表格窗体
    /// </summary>
    public partial class PopulationDetailsGrid : WinEntityGrid<PopulationDetail>
    {
        #region Field
        /// <summary>
        /// 是否显示计入总数列
        /// </summary>
        private bool showInTotal = true;
        #endregion //Field

        #region Constructor
        public PopulationDetailsGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopulationDetailsGrid_Load(object sender, EventArgs e)
        {
            this.colInTotal.Visible = this.showInTotal;
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否显示计入总数列
        /// </summary>
        [Category("界面"), Description("是否显示计入总数列"), Browsable(true)]
        public bool ShowInTotal
        {
            get
            {
                return this.showInTotal;
            }
            set
            {
                this.showInTotal = value;
            }
        }
        #endregion //Property
    }
}
