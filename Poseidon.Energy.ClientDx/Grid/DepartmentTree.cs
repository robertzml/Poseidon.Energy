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
    using DevExpress.Utils.Drawing;
    using Poseidon.Base.Framework;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 部门树形控件
    /// </summary>
    public partial class DepartmentTree : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 是否能编辑
        /// </summary>
        protected bool editable = false;

        /// <summary>
        /// 是否显示行号
        /// </summary>
        protected bool showLineNumber = true;
        #endregion //Field

        #region Constructor
        public DepartmentTree()
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
        private void DepartmentTree_Load(object sender, EventArgs e)
        {
            if (this.showLineNumber)
                this.tlData.IndicatorWidth = 40;
            else
                this.tlData.IndicatorWidth = 10;

            this.tlData.OptionsView.ShowIndicator = this.showLineNumber;
            this.tlData.OptionsBehavior.Editable = this.editable;
        }

        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlData_CustomDrawNodeIndicator(object sender, DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventArgs e)
        {
            if (this.showLineNumber)
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                IndicatorObjectInfoArgs arg = e.ObjectArgs as IndicatorObjectInfoArgs;
                if (arg.IsRowIndicator)
                {
                    int rowNum = this.tlData.GetVisibleIndexByNode(e.Node) + 1;
                    arg.DisplayText = rowNum.ToString();
                }
            }
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 数据源
        /// </summary>
        [Description("数据源")]
        public List<Department> DataSource
        {
            get
            {
                return this.bsDepartment.DataSource as List<Department>;
            }
            set
            {
                this.tlData.BeginInit();
                this.bsDepartment.DataSource = value;
                this.tlData.EndInit();
            }
        }

        /// <summary>
        /// 是否能编辑
        /// </summary>
        [Category("功能"), Description("是否能编辑"), Browsable(true)]
        public bool Editable
        {
            get
            {
                return this.editable;
            }
            set
            {
                this.editable = value;
            }
        }

        /// <summary>
        /// 是否显示行号
        /// </summary>
        [Category("界面"), Description("是否显示行号"), Browsable(true)]
        public bool ShowLineNumber
        {
            get
            {
                return this.showLineNumber;
            }
            set
            {
                this.showLineNumber = value;
            }
        }
        #endregion //Property
    }
}
