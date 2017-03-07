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
    /// 编辑支出账户
    /// </summary>
    public partial class FrmExpenseAccountEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private ExpenseAccount currentAccount;
        #endregion //Field

        #region Constructor
        public FrmExpenseAccountEdit(string id)
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
            this.currentAccount = BusinessFactory<ExpenseAccountBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.bsAccount.DataSource = BusinessFactory<ExpenseAccountBusiness>.Instance.FindAll().ToList();

            this.txtName.Text = this.currentAccount.Name;
            this.txtShortName.Text = this.currentAccount.ShortName;
            this.tluParent.EditValue = this.currentAccount.ParentId;
            this.txtRemark.Text = this.currentAccount.Remark;

            if (this.currentAccount.EnergyType.Contains(1))
                this.chkType1.Checked = true;
            if (this.currentAccount.EnergyType.Contains(2))
                this.chkType2.Checked = true;
            if (this.currentAccount.EnergyType.Contains(3))
                this.chkType3.Checked = true;
            if (this.currentAccount.EnergyType.Contains(4))
                this.chkType4.Checked = true;

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

            SetEntity(this.currentAccount);

            try
            {
                BusinessFactory<ExpenseAccountBusiness>.Instance.Update(this.currentAccount);

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
