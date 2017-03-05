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
    /// 添加补贴指标窗体
    /// </summary>
    public partial class FrmAllowanceAdd : BaseSingleForm
    {
        #region Field
        private AllowanceTarget allowanceTarget;
        #endregion //Field

        #region Constructor
        public FrmAllowanceAdd()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 更新数据
        /// </summary>
        private void UpdateTotal()
        {
            decimal factor = this.spFactor.Value;
            decimal monthKilowatt = this.spMonthKilowatt.Value;
            int monthCount = Convert.ToInt32(this.spMonthCount.Value);
            decimal unitPrice = this.spUnitPrice.Value;

            decimal yearKilowatt = factor * monthKilowatt * monthCount;
            decimal yearAmount = yearKilowatt * unitPrice;

            this.spYearKilowatt.Value = yearKilowatt;
            this.spYearAmount.Value = yearAmount;
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
            if (this.txtCode.Text.Trim() == null)
            {
                errorMessage = "代码不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(AllowanceTarget entity)
        {
            entity.Name = this.txtName.Text;
            entity.Code = this.txtCode.Text;
            entity.Factor = this.spFactor.Value;
            entity.MonthKilowatt = this.spMonthKilowatt.Value;
            entity.MonthCount = Convert.ToInt32(this.spMonthCount.Value);
            entity.UnitPrice = this.spUnitPrice.Value;
            entity.YearKilowatt = this.spYearKilowatt.Value;
            entity.YearAmount = this.spYearAmount.Value;
        }
        #endregion //Function

        #region Event
        private void spUnitPrice_EditValueChanged(object sender, EventArgs e)
        {
            UpdateTotal();
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

            this.allowanceTarget = new AllowanceTarget();
            SetEntity(allowanceTarget);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 新增补贴指标
        /// </summary>
        public AllowanceTarget AllowanceTarget
        {
            get
            {
                return this.allowanceTarget;
            }
        }
        #endregion //Property
    }
}
