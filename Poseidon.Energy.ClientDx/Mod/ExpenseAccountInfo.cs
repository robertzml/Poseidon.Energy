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
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 支出账户信息控件
    /// </summary>
    public partial class ExpenseAccountInfo : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public ExpenseAccountInfo()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置关联账户
        /// </summary>
        /// <param name="account">账户对象</param>
        public void SetAccount(ExpenseAccount account)
        {
            this.txtName.Text = account.Name;
            this.txtShortName.Text = account.ShortName;
            this.txtRemark.Text = account.Remark;

            this.chkType1.Checked = this.chkType2.Checked = this.chkType3.Checked = this.chkType4.Checked = false;

            if (account.EnergyType.Contains(1))
                this.chkType1.Checked = true;
            if (account.EnergyType.Contains(2))
                this.chkType2.Checked = true;
            if (account.EnergyType.Contains(3))
                this.chkType3.Checked = true;
            if (account.EnergyType.Contains(4))
                this.chkType4.Checked = true;
        }
        #endregion //Method
    }
}
