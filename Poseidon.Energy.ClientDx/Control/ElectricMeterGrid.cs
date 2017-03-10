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
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 电表表格控件
    /// </summary>
    public partial class ElectricMeterGrid : WinEntityGrid<ElectricMeter>
    {
        #region Field
        /// <summary>
        /// 是否显示导航
        /// </summary>
        private bool showNavigator;
        #endregion //Field

        #region Constructor
        public ElectricMeterGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        private void ElectricMeterGrid_Load(object sender, EventArgs e)
        {
            this.dataNavigator1.Visible = this.showNavigator;
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否显示导航条
        /// </summary>
        [Category("界面"), Description("是否显示导航条"), Browsable(true)]
        public bool ShowNavigator
        {
            get
            {
                return this.showNavigator;
            }
            set
            {
                this.showNavigator = value;
            }
        }
        #endregion //Property
    }
}
