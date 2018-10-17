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
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 编辑能源结算窗体
    /// </summary>
    public partial class FrmSettlementEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联结算
        /// </summary>
        private Settlement currentSettlement;
        #endregion //Field

        #region Constructor
        public FrmSettlementEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentSettlement = BusinessFactory<SettlementBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.cmbType.Properties.Items.AddEnum(typeof(SettlementType));
            this.bsTarget.DataSource = BusinessFactory<TargetBusiness>.Instance.FindAll();
            this.bsSettlement.DataSource = BusinessFactory<SettlementBusiness>.Instance.FindByTarget(this.currentSettlement.TargetId).Where(r => r.Id != this.currentSettlement.Id);

            this.txtName.Text = this.currentSettlement.Name;
            this.txtBelongTime.Text = this.currentSettlement.BelongTime;
            this.spYear.Value = this.currentSettlement.Year;
            this.cmbType.EditValue = (SettlementType)this.currentSettlement.Type;
            this.luTarget.EditValue = this.currentSettlement.TargetId;
            this.luPrevious.EditValue = this.currentSettlement.PreviousId == "" ? null : this.currentSettlement.PreviousId;
            this.txtRemark.Text = this.currentSettlement.Remark;

            base.InitForm();
        }

        /// <summary>
        /// 载入上期结算
        /// </summary>
        /// <param name="target"></param>
        private void LoadSettlement(Target target)
        {
            var data = BusinessFactory<SettlementBusiness>.Instance.FindByTarget(target.Id).Where(r => r.Id != this.currentSettlement.Id);
            this.bsSettlement.DataSource = data;
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
            if (string.IsNullOrEmpty(this.txtBelongTime.Text.Trim()))
            {
                errorMessage = "归属时间不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.cmbType.SelectedIndex == -1)
            {
                errorMessage = "请选择结算类型";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.luTarget.EditValue == null)
            {
                errorMessage = "请选择关联指标计划";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Settlement entity)
        {
            entity.Name = this.txtName.Text;
            entity.Year = Convert.ToInt32(this.spYear.Value);
            entity.Type = Convert.ToInt32(this.cmbType.EditValue);
            entity.BelongTime = this.txtBelongTime.Text;
            entity.TargetId = this.luTarget.EditValue.ToString();
            entity.PreviousId = this.luPrevious.EditValue == null ? "" : this.luPrevious.EditValue.ToString();
            entity.Remark = this.txtRemark.Text;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 指标计划选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luTarget_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luTarget.EditValue == null)
            {
                this.luPrevious.EditValue = null;
                return;
            }

            LoadSettlement(this.luTarget.GetSelectedDataRow() as Target);
        }

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

            try
            {
                Settlement entity = BusinessFactory<SettlementBusiness>.Instance.FindById(this.currentSettlement.Id);
                SetEntity(entity);

                var result = BusinessFactory<SettlementBusiness>.Instance.Update(entity, this.currentUser);

                if (result.success)
                {
                    MessageUtil.ShowInfo("保存成功");
                    this.Close();
                }
                else
                {
                    MessageUtil.ShowClaim("保存失败: " + result.errorMessage);
                }
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
