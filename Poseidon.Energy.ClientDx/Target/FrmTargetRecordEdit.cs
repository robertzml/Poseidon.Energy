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
    /// 编辑计划指标记录窗体
    /// </summary>
    public partial class FrmTargetRecordEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联记录
        /// </summary>
        private TargetRecord currentRecord;
        #endregion //Field

        #region Constructor
        public FrmTargetRecordEdit(string id)
        {
            InitializeComponent();

            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentRecord = BusinessFactory<TargetRecordBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.txtDepartmentName.Text = BusinessFactory<DepartmentBusiness>.Instance.FindById(this.currentRecord.DepartmentId).Name;
            ControlUtil.BindDictToComboBox(this.cmbType, typeof(TargetRecord), "Type");
            this.cmbType.EditValue = this.currentRecord.Type;
            this.txtFinance.Text = this.currentRecord.Finance;
            this.spSchoolTake.Value = this.currentRecord.SchoolTake;
            this.spSelfTake.Value = this.currentRecord.SelfTake;
            this.txtRemark.Text = this.currentRecord.Remark;

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (this.cmbType.EditValue == null)
            {
                errorMessage = "指标类型不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(TargetRecord entity)
        {
            entity.Type = Convert.ToInt32(this.cmbType.EditValue);
            entity.Finance = this.txtFinance.Text;
            entity.SchoolTake = this.spSchoolTake.Value;
            entity.SelfTake = this.spSelfTake.Value;
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

            TargetRecord entity = BusinessFactory<TargetRecordBusiness>.Instance.FindById(this.currentRecord.Id);
            SetEntity(entity);

            try
            {
                var result = BusinessFactory<TargetRecordBusiness>.Instance.Update(entity, this.currentUser);

                if (result)
                {
                    MessageUtil.ShowInfo("保存成功");
                    this.Close();
                }
                else
                    MessageUtil.ShowInfo("保存失败");
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
