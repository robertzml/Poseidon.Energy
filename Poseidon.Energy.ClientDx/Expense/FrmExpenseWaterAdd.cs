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
    using Poseidon.Base.System;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 添加水费支出窗体
    /// </summary>
    public partial class FrmExpenseWaterAdd : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联支出账户
        /// </summary>
        private ExpenseAccount currentAccount;
        #endregion //Field

        #region Constructor
        public FrmExpenseWaterAdd(string accountId)
        {
            InitializeComponent();

            InitData(accountId);
        }
        #endregion //Constructor

        #region Field
        private void InitData(string id)
        {
            this.currentAccount = BusinessFactory<ExpenseAccountBusiness>.Instance.FindById(id);
        }
        #endregion //Field
    }
}
