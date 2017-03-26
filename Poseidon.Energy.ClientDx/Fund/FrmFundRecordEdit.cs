using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 编辑经费记录窗体
    /// </summary>
    public partial class FrmFundRecordEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联经费统计
        /// </summary>
        private Fund currentFund;
        #endregion //Field

        #region Constructor
        public FrmFundRecordEdit(string fundId)
        {
            InitializeComponent();

            InitData(fundId);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="fundId"></param>
        private void InitData(string fundId)
        {
            this.currentFund = BusinessFactory<FundBusiness>.Instance.FindById(fundId);
        }

        protected override void InitForm()
        {
            this.txtName.Text = this.currentFund.Name;
            this.txtYear.Text = this.currentFund.Year.ToString();
            this.txtRemark.Text = this.currentFund.Remark;

            var record = LoadFundRecords();
            this.frGrid.DataSource = record;

            base.InitForm();
        }

        /// <summary>
        /// 载入经费记录
        /// </summary>
        /// <returns></returns>
        private List<FundRecord> LoadFundRecords()
        {
            var records = BusinessFactory<FundRecordBusiness>.Instance.FindByFundId(this.currentFund.Id);
            var departments = BusinessFactory<DepartmentBusiness>.Instance.FindInGroup(EnergyConstant.FundDepartmentGroupCode, true);

            List<FundRecord> data = new List<FundRecord>();
            data.AddRange(records);

            foreach (var item in departments)
            {
                if (!records.Any(r => r.DepartmentId == item.Id))
                {
                    FundRecord fr = new FundRecord();
                    fr.FundId = this.currentFund.Id;
                    fr.DepartmentId = item.Id;

                    data.Add(fr);
                }
            }

            return data;
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(List<FundRecord> entity)
        {
            foreach (var item in entity)
            {
                item.Remark = item.Remark ?? "";
            }
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.frGrid.CloseEditor();

            var data = this.frGrid.DataSource;
            SetEntity(data);

            try
            {
                BusinessFactory<FundRecordBusiness>.Instance.Update(data, this.currentUser);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
