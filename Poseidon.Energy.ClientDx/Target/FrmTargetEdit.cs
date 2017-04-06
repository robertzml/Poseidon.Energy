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
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 编辑计划指标窗体
    /// </summary>
    public partial class FrmTargetEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联计划指标
        /// </summary>
        private Target currentTarget;
        #endregion //Field

        #region Constructor
        public FrmTargetEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentTarget = BusinessFactory<TargetBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.bsPopulation.DataSource = BusinessFactory<PopulationBusiness>.Instance.FindAll().ToList();
            this.bsFund.DataSource = BusinessFactory<FundBusiness>.Instance.FindAll().ToList();

            this.txtName.Text = this.currentTarget.Name;
            this.spYear.Value = Convert.ToInt32(this.currentTarget.Year);
            this.luPopulation.EditValue = this.currentTarget.PopulationId;
            this.luFund.EditValue = this.currentTarget.FundId;
            this.txtRemark.Text = this.currentTarget.Remark;
            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorMessage = "名称不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.luPopulation.EditValue == null)
            {
                errorMessage = "请选择关联人数统计";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.luFund.EditValue == null)
            {
                errorMessage = "请选择关联经费统计";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Target entity)
        {
            entity.Name = this.txtName.Text;
            entity.Year = Convert.ToInt32(this.spYear.Value);
            entity.PopulationId = this.luPopulation.EditValue.ToString();
            entity.FundId = this.luFund.EditValue.ToString();
            entity.Remark = this.txtRemark.Text;
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
            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            Target entity = BusinessFactory<TargetBusiness>.Instance.FindById(this.currentTarget.Id);
            SetEntity(entity);

            try
            {
                BusinessFactory<TargetBusiness>.Instance.Update(entity, this.currentUser);

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
