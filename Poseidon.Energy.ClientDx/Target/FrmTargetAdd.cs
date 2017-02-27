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
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 添加计划指标窗体
    /// </summary>
    public partial class FrmTargetAdd : BaseSingleForm
    {
        #region Constructor
        public FrmTargetAdd()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            var popu = BusinessFactory<PopulationBusiness>.Instance.FindAll().ToList();
            this.bsPopulation.DataSource = popu;

            var funds = BusinessFactory<FundBusiness>.Instance.FindAll().ToList();
            this.bsFund.DataSource = funds;

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (this.luPopulation.EditValue == null)
            {
                errorMessage = "请选择关联人数统计";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.luFund.EditValue == null)
            {
                errorMessage = "请选择关联经费统计";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(PlanTarget entity)
        {
            entity.Year = Convert.ToInt32(this.spYear.Value);
            entity.PopulationId = this.luPopulation.EditValue.ToString();
            entity.FundId = this.luFund.EditValue.ToString();
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

            PlanTarget entity = new PlanTarget();
            SetEntity(entity);

            try
            {
                BusinessFactory<PlanTargetBusiness>.Instance.Create(entity);

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
