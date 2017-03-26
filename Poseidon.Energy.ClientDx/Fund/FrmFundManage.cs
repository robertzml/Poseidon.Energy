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
    /// 经费统计管理窗体
    /// </summary>
    public partial class FrmFundManage : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前选择统计
        /// </summary>
        private Fund currentFund;
        #endregion //Field

        #region Constructor
        public FrmFundManage()
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
        /// 显示信息
        /// </summary>
        /// <param name="entity">经费统计信息</param>
        private void DisplayInfo(Fund entity)
        {
            this.txtName.Text = entity.Name;
            this.txtYear.Text = entity.Year.ToString();
            this.txtBelongTime.Text = entity.BelongTime;
            this.txtRemark.Text = entity.Remark;
            this.txtCreateUser.Text = entity.CreateBy.Name;
            this.txtCreateTime.Text = entity.CreateBy.Time.ToDateTimeString();
            this.txtEditUser.Text = entity.UpdateBy.Name;
            this.txtEditTime.Text = entity.UpdateBy.Time.ToDateTimeString();

            var records = BusinessFactory<FundRecordBusiness>.Instance.FindByFundId(entity.Id).ToList();
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
            DisplayInfo(this.currentFund);
        }

        /// <summary>
        /// 添加统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmFundAdd));
            LoadFunds();
        }

        /// <summary>
        /// 编辑统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.lbFund.SelectedItem == null || this.currentFund == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmFundEdit), new object[] { this.currentFund.Id });
            LoadFunds();
        }

        /// <summary>
        /// 删除统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lbFund.SelectedItem == null || this.currentFund == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否确认删除选中经费统计") == DialogResult.Yes)
            {
                try
                {
                    BusinessFactory<FundBusiness>.Instance.Delete(this.currentFund);
                    LoadFunds();

                    MessageUtil.ShowInfo("删除成功");
                }
                catch (PoseidonException pe)
                {
                    MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
                }
            }
        }

        /// <summary>
        /// 编辑记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            if (this.lbFund.SelectedItem == null || this.currentFund == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmFundRecordEdit), new object[] { this.currentFund.Id });
            LoadFunds();
        }
        #endregion //Event
    }
}
