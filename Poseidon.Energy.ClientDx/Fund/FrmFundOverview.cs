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
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 经费总览窗体
    /// </summary>
    public partial class FrmFundOverview : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前选择统计
        /// </summary>
        private Fund currentFund;
        #endregion //Field

        #region Constructor
        public FrmFundOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadFunds();

            base.InitForm();
        }

        /// <summary>
        /// 载入经费统计
        /// </summary>
        private void LoadFunds()
        {
            var funds = BusinessFactory<FundBusiness>.Instance.FindAll().OrderByDescending(r => r.Year).ToList();
            this.bsFund.DataSource = funds;
        }

        /// <summary>
        /// 显示经费记录信息
        /// </summary>
        private void DisplayFundInfo()
        {
            this.txtName.Text = currentFund.Name;
            this.txtYear.Text = currentFund.Year.ToString();
            this.txtBelongTime.Text = currentFund.BelongTime;
            this.txtRemark.Text = currentFund.Remark;
            this.txtCreateUser.Text = currentFund.CreateBy.Name;
            this.txtCreateTime.Text = currentFund.CreateBy.Time.ToDateTimeString();
            this.txtEditUser.Text = currentFund.UpdateBy.Name;
            this.txtEditTime.Text = currentFund.UpdateBy.Time.ToDateTimeString();

            LoadFundRecords(this.currentFund.Id);
        }

        /// <summary>
        /// 载入经费记录
        /// </summary>
        /// <param name="fundId">统计ID</param>
        private void LoadFundRecords(string fundId)
        {
            var records = BusinessFactory<FundRecordBusiness>.Instance.FindByFundId(fundId).ToList();
            this.frGrid.DataSource = records;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 选择统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbFund_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbFund.SelectedItem == null)
                return;

            this.currentFund = this.lbFund.SelectedItem as Fund;
            DisplayFundInfo();
        }
        #endregion //Event
    }
}
