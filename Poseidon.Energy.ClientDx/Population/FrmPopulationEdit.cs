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
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 编辑人数统计窗体
    /// </summary>
    public partial class FrmPopulationEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 关联统计
        /// </summary>
        private Population currentPopulation;
        #endregion //Field

        #region Constructor
        public FrmPopulationEdit(string id)
        {
            InitializeComponent();

            InitData(id);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="id"></param>
        private void InitData(string id)
        {
            this.currentPopulation = BusinessFactory<PopulationBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.txtName.Text = this.currentPopulation.Name;
            this.spYear.Value = this.currentPopulation.Year;
            this.txtBelongTime.Text = this.currentPopulation.BelongTime;
            this.txtRemark.Text = this.currentPopulation.Remark;

            base.InitForm();
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Population entity)
        {
            entity.Name = this.txtName.Text;
            entity.Year = Convert.ToInt32(this.spYear.Value);
            entity.BelongTime = this.txtBelongTime.Text;
            entity.Remark = this.txtRemark.Text;
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

            return new Tuple<bool, string>(true, "");
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
                var entity = BusinessFactory<PopulationBusiness>.Instance.FindById(this.currentPopulation.Id);
                SetEntity(entity);

                var result = BusinessFactory<PopulationBusiness>.Instance.Update(entity, this.currentUser);

                if (result.success)
                {
                    MessageUtil.ShowInfo("保存成功");
                    this.Close();
                }
                else
                {
                    MessageUtil.ShowInfo("保存失败: " + result.errorMessage);
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
