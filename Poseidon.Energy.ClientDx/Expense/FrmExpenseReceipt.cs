using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 支出单据窗体
    /// </summary>
    public partial class FrmExpenseReceipt : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前选择账户
        /// </summary>
        private ExpenseAccount currentAccount;
        #endregion //Field

        #region Constructor
        public FrmExpenseReceipt()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化选项卡
        /// </summary>
        private void InitTabPage()
        {
            //this.txtName.Text = this.currentAccount.Name;
            //this.txtShortName.Text = this.currentAccount.ShortName;
            //this.txtRemark.Text = this.currentAccount.Remark;

            //if (this.currentAccount.EnergyType.Contains(1))
            //    this.chkType1.Checked = true;
            if (this.currentAccount.EnergyType.Contains(2))
            {
                //this.chkType2.Checked = true;
                LoadWater();
            }
            //if (this.currentAccount.EnergyType.Contains(3))
            //    this.chkType3.Checked = true;
            //if (this.currentAccount.EnergyType.Contains(4))
            //    this.chkType4.Checked = true;
        }

        /// <summary>
        /// 载入水费相关数据
        /// </summary>
        private void LoadWater()
        {
            this.tabPageWater.PageVisible = true;
            this.waterReceipt.SetAccount(this.currentAccount);
        }
        #endregion //Function

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
                InitTabPage();
            }
        }
        #endregion //Event
    }
}
