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
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 支出账户管理窗体
    /// </summary>
    public partial class FrmExpenseAccount : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前选择账户
        /// </summary>
        private ExpenseAccount currentAccount;
        #endregion //Field

        #region Constructor
        public FrmExpenseAccount()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 账户选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accountTree_AccountSelected(object sender, EventArgs e)
        {
            string id = this.accountTree.GetCurrentSelectAccountId();
            if (id == null)
                this.currentAccount = null;
            else
            {
                this.currentAccount = BusinessFactory<ExpenseAccountBusiness>.Instance.FindById(id);
                this.txtName.Text = this.currentAccount.Name;
            }
        }

        /// <summary>
        /// 添加账户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmExpenseAccountAdd));
        }

        /// <summary>
        /// 编辑账户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.currentAccount == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmExpenseAccountEdit), new object[] { this.currentAccount.Id });
        }

        /// <summary>
        /// 设置水表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetWater_Click(object sender, EventArgs e)
        {
            if (this.currentAccount == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmExpenseWaterMeterSet), new object[] { this.currentAccount.Id });
        }
        #endregion //Event
    }
}
