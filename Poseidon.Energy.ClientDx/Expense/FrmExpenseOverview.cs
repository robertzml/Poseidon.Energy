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
    /// 支出总览窗体
    /// </summary>
    public partial class FrmExpenseOverview : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前选择账户
        /// </summary>
        private ExpenseAccount currentAccount;
        #endregion //Field

        #region Constructor
        public FrmExpenseOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 账户选择
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
            }
        }

        /// <summary>
        /// 登记水费
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddWater_Click(object sender, EventArgs e)
        {
            if (this.currentAccount == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmExpenseWaterAdd), new object[] { this.currentAccount.Id });
        }
        #endregion //Event
    }
}
