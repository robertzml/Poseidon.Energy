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
    /// 添加支出账户窗体
    /// </summary>
    public partial class FrmExpenseAccountAdd : BaseSingleForm
    {
        #region Constructor
        public FrmExpenseAccountAdd()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            var accounts = BusinessFactory<ExpenseAccountBusiness>.Instance.FindAll().ToList();
            this.bsAccount.DataSource = accounts;

            base.InitForm();
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(ExpenseAccount entity)
        {
            entity.Name = this.txtName.Text;
            entity.ShortName = this.txtShortName.Text;
            entity.Remark = this.txtRemark.Text;

            if (this.tluParent.EditValue != null)
                entity.ParentId = this.tluParent.EditValue.ToString();
            else
                entity.ParentId = null;

            entity.EnergyType = new List<int>();
            if (chkType1.Checked)
                entity.EnergyType.Add(1);
            if (chkType2.Checked)
                entity.EnergyType.Add(2);
            if (chkType3.Checked)
                entity.EnergyType.Add(3);
            if (chkType4.Checked)
                entity.EnergyType.Add(4);
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

            ExpenseAccount entity = new ExpenseAccount();
            SetEntity(entity);

            try
            {
                BusinessFactory<ExpenseAccountBusiness>.Instance.Create(entity);

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
