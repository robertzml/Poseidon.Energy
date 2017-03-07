using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
    /// 水表表格控件
    /// </summary>
    public partial class WaterMeterGrid : WinEntityGrid<WaterMeter>
    {
        #region Field
        /// <summary>
        /// 是否显示导航
        /// </summary>
        private bool showNavigator;
        #endregion //Field

        #region Constructor
        public WaterMeterGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        private void WaterMeterGrid_Load(object sender, EventArgs e)
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
