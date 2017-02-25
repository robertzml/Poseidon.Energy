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
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 经费统计总览窗体
    /// </summary>
    public partial class FrmFundOverview : BaseMdiForm
    {
        #region Constructor
        public FrmFundOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            var funds = BusinessFactory<FundBusiness>.Instance.FindAll().ToList();
            this.bsFund.DataSource = funds;
            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 添加统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmFundAdd));
        }
        #endregion //Event
    }
}
