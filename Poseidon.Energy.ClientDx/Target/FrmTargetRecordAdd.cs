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
    using Poseidon.Winform.Core.Utility;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 添加指标记录窗体
    /// </summary>
    public partial class FrmTargetRecordAdd : BaseSingleForm
    {
        #region Field
        private string targetId;
        #endregion //Field

        #region Constructor
        public FrmTargetRecordAdd(string targetId)
        {
            InitializeComponent();

            this.targetId = targetId;
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.bsDepartment.DataSource = BusinessFactory<DepartmentBusiness>.Instance.FindInGroup(EnergyConstant.TargetDepartmentGroupCode, true);
            ControlUtil.BindDictToComboBox(this.cmbType, typeof(TargetRecord), "Type");
            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (this.luDepartment.EditValue == null)
            {
                errorMessage = "相关部门不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
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
            entity.TargetId = this.targetId;
            entity.DepartmentId = this.luDepartment.EditValue.ToString();
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

            TargetRecord entity = new TargetRecord();
            SetEntity(entity);

            try
            {
                BusinessFactory<TargetRecordBusiness>.Instance.Create(entity, this.currentUser);

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
