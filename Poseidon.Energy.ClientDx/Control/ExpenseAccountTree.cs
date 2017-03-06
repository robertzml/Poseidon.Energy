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
            this.groups = BusinessFactory<GroupBusiness>.Instance.FindByModelType(ModelTypeCode.ExpenseAccount).ToList();

            this.tlData.BeginUnboundLoad();
            foreach (var item in groups.Where(r => r.ParentId == null))
            {
                var node = this.tlData.AppendNode(new object[] { item.Id, item.Name, 1 }, null);
                node.StateImageIndex = 0;
                node.HasChildren = true;

                node.Expanded = true;
            }
            this.tlData.EndUnboundLoad();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 获取当前选中账户ID
        /// </summary>
        /// <returns></returns>
        public string GetCurrentSelectAccountId()
        {
            var node = this.tlData.Selection[0];
            if (node == null)
                return null;

            int type = Convert.ToInt32(node["colType"]);
            if (type == 2)
                return node["colId"].ToString();
            else
                return null;
        }
        #endregion //Method

        #region Delegate
        /// <summary>
        /// 账户选择事件
        /// </summary>
        [Description("账户选择事件")]
        public event EventHandler AccountSelected;
        #endregion //Delegate

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpenseAccountTree_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadRootNode();
            }
        }

        /// <summary>
        /// 载入账户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlData_BeforeExpand(object sender, DevExpress.XtraTreeList.BeforeExpandEventArgs e)
        {
            var id = e.Node["colId"].ToString();
            int type = Convert.ToInt32(e.Node["colType"]);

            if (type == 1)
            {
                this.tlData.BeginUnboundLoad();
                e.Node.Nodes.Clear();

                // load children group
                var children = this.groups.Where(r => r.ParentId == id);
                foreach (var item in children)
                {
                    var node = this.tlData.AppendNode(new object[] { item.Id, item.Name, 1 }, e.Node);
                    node.StateImageIndex = 0;
                    node.HasChildren = true;
                }

                // load contain account
                var group = this.groups.Find(r => r.Id == id);
                var orgs = BusinessFactory<OrganizationBusiness>.Instance.FindWithIds(group.Organizations);
                foreach (var item in orgs)
                {
                    var node = this.tlData.AppendNode(new object[] { item.Id, item.Name, 2 }, e.Node);
                    node.StateImageIndex = 1;
                    node.HasChildren = false;
                }

                this.tlData.EndUnboundLoad();
            }
        }

        /// <summary>
        /// 选中行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlData_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            int type = Convert.ToInt32(e.Node["colType"]);
            if (type == 1)
            {

            }
            else if (type == 2)
            {
                AccountSelected?.Invoke(sender, e);
            }
        }
        #endregion //Event
    }
}
