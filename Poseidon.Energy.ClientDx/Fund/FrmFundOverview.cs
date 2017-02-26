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
    /// 经费统计总览窗体
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
            LoadFund();

            base.InitForm();
        }

        /// <summary>
        /// 载入经费统计
        /// </summary>
        private void LoadFund()
        {
            var funds = BusinessFactory<FundBusiness>.Instance.FindAll().ToList();
            this.bsFund.DataSource = funds;
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
            this.currentFund = this.lbFund.SelectedItem as Fund;
            this.txtYear.Text = currentFund.Year.ToString();
            this.txtRemark.Text = currentFund.Remark;
            this.txtCreateTime.Text = currentFund.CreateTime.ToDateTimeString();
            this.txtUpdateTime.Text = currentFund.UpdateTime.ToDateTimeString();
        }

        /// <summary>
        /// 添加统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmFundAdd));
            LoadFund();
        }

        /// <summary>
        /// 编辑统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.currentFund == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmFundEdit), new object[] { this.currentFund.Id });
            LoadFund();
        }

        /// <summary>
        /// 删除统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.currentFund == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否确认删除选中经费统计") == DialogResult.Yes)
            {
                try
                {
                    BusinessFactory<FundBusiness>.Instance.Delete(this.currentFund);
                    LoadFund();

                    MessageUtil.ShowInfo("删除成功");
                }
                catch (PoseidonException pe)
                {
                    MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
                }
            }
        }
        #endregion //Event

    }
}
