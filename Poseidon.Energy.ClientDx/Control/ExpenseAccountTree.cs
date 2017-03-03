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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 支出账户树形控件
    /// </summary>
    public partial class ExpenseAccountTree : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 相关分组
        /// </summary>
        private List<Group> groups;
        #endregion //Field

        #region Constructor
        public ExpenseAccountTree()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入根节点
        /// </summary>
        private void LoadRootNode()
        {
            this.groups =  BusinessFactory<GroupBusiness>.Instance.FindByModelType(ModelTypeCode.ExpenseAccount).ToList();

            this.tlData.BeginUnboundLoad();
            foreach(var item in groups.Where(r => r.ParentId == null))
            {
                this.tlData.AppendNode(new object[] { item.Id, item.Name }, null);
            }
            this.tlData.EndUnboundLoad();
        }
        #endregion //Function

        #region Event
        private void ExpenseAccountTree_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadRootNode();
            }
        }
        #endregion //Event
    }
}
