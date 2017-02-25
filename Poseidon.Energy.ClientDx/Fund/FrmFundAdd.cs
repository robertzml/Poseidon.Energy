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
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 添加经费统计窗体
    /// </summary>
    public partial class FrmFundAdd : BaseSingleForm
    {
        #region Constructor
        public FrmFundAdd()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        private void SetEntity(Fund entity)
        {
            entity.Year = Convert.ToInt32(this.spYear.Value);
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
            Fund entity = new Fund();
            SetEntity(entity);

            try
            {
                BusinessFactory<FundBusiness>.Instance.Create(entity);

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
