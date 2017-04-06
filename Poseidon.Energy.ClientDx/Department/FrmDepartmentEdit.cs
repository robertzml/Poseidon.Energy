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
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 部门编辑窗体
    /// </summary>
    public partial class FrmDepartmentEdit : BaseSingleForm
    {
        #region Field
        private Department currentEntity;
        #endregion //Field

        #region Constructor
        public FrmDepartmentEdit(string id)
        {
            InitializeComponent();

            InitData(id);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="id">部门ID</param>
        private void InitData(string id)
        {
            this.currentEntity = BusinessFactory<DepartmentBusiness>.Instance.FindById(id);
        }

        /// <summary>
        /// 初始化窗体
        /// </summary>
        protected override void InitForm()
        {
            this.bsDepartment.DataSource = BusinessFactory<DepartmentBusiness>.Instance.FindAll();

            this.txtName.Text = this.currentEntity.Name;
            this.txtShortName.Text = this.currentEntity.ShortName;
            this.spFoundYear.Value = this.currentEntity.FoundYear;
            this.tluParentId.EditValue = this.currentEntity.ParentId;
            this.txtRemark.Text = this.currentEntity.Remark;
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

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Department entity)
        {
            entity.Name = this.txtName.Text;
            entity.ShortName = this.txtShortName.Text;
            entity.FoundYear = Convert.ToInt32(this.spFoundYear.Value);
            entity.Remark = this.txtRemark.Text;

            if (this.tluParentId.EditValue != null)
                entity.ParentId = this.tluParentId.EditValue.ToString();
            else
                entity.ParentId = null;
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

            SetEntity(this.currentEntity);

            try
            {
                BusinessFactory<DepartmentBusiness>.Instance.Update(this.currentEntity);

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
