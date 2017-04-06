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
    /// 编辑能源计量窗体
    /// </summary>
    public partial class FrmMeasureEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 相关关联计量
        /// </summary>
        private Measure currentMeasure;
        #endregion //Field

        #region Constructor
        public FrmMeasureEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentMeasure = BusinessFactory<MeasureBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.txtName.Text = this.currentMeasure.Name;
            this.txtBelongTime.Text = this.currentMeasure.BelongTime;
            this.spYear.Value = this.currentMeasure.Year;
            ControlUtil.BindDictToComboBox(this.cmbEnergyType, typeof(Measure), "EnergyType", this.currentMeasure.EnergyType);
            this.dpStartTime.DateTime = this.currentMeasure.StartTime;
            this.dpEndTime.DateTime = this.currentMeasure.EndTime;
            this.chkIncluded.Checked = this.currentMeasure.Included;
            this.txtRemark.Text = this.currentMeasure.Remark;

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
            if (string.IsNullOrEmpty(this.txtBelongTime.Text.Trim()))
            {
                errorMessage = "归属时间不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.cmbEnergyType.SelectedIndex == -1)
            {
                errorMessage = "请选择能源类型";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpStartTime.DateTime > this.dpEndTime.DateTime)
            {
                errorMessage = "起始时间不能大于结束时间";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Measure entity)
        {
            entity.Name = this.txtName.Text;
            entity.Year = Convert.ToInt32(this.spYear.Value);
            entity.BelongTime = this.txtBelongTime.Text;
            entity.EnergyType = Convert.ToInt32(this.cmbEnergyType.EditValue);
            entity.StartTime = this.dpStartTime.DateTime.Date;
            entity.EndTime = this.dpEndTime.DateTime.Date;
            entity.Included = this.chkIncluded.Checked;
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

            try
            {
                var entity = BusinessFactory<MeasureBusiness>.Instance.FindById(this.currentMeasure.Id);
                SetEntity(entity);

                BusinessFactory<MeasureBusiness>.Instance.Update(entity, this.currentUser);

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
