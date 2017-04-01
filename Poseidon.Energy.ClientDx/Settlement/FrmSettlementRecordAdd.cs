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
    /// 添加结算记录窗体
    /// </summary>
    public partial class FrmSettlementRecordAdd : BaseSingleForm
    {
        #region Field
        private string settlementId;
        #endregion //Field

        #region Constructor
        public FrmSettlementRecordAdd(string settlementId)
        {
            InitializeComponent();

            this.settlementId = settlementId;
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.bsDepartment.DataSource = BusinessFactory<DepartmentBusiness>.Instance.FindInGroup(EnergyConstant.TargetDepartmentGroupCode, true);
            this.cmbEnergyType.Properties.Items.AddEnum(typeof(EnergyType));

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
            if (this.cmbEnergyType.EditValue == null)
            {
                errorMessage = "能源类型不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(SettlementRecord entity)
        {
            entity.SettlementId = this.settlementId;
            entity.DepartmentId = this.luDepartment.EditValue.ToString();
            entity.EnergyType = Convert.ToInt32(this.cmbEnergyType.EditValue);
            entity.UnitPrice = this.spUnitPrice.Value;
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

            SettlementRecord entity = new SettlementRecord();
            SetEntity(entity);

            try
            {
                BusinessFactory<SettlementRecordBusiness>.Instance.Create(entity, this.currentUser);

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
