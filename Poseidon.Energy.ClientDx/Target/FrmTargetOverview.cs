using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 指标计划总览窗体
    /// </summary>
    public partial class FrmTargetOverview : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前关联指标计划
        /// </summary>
        private Target currentTarget;
        #endregion //Field

        #region Constructor
        public FrmTargetOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.groupTreeTarget.SetGroupCode(EnergyConstant.TargetDepartmentGroupCode);
           

            base.InitForm();
        }

        /// <summary>
        /// 载入指标计划
        /// </summary>
        private void LoadTargets()
        {
            //var data = BusinessFactory<TargetBusiness>.Instance.FindAll().ToList();
            //this.bsTarget.DataSource = data;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 选择指标计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbPlanTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.currentTarget = this.lbTarget.SelectedItem as Target;

            this.txtName.Text = currentTarget.Name;
            this.txtYear.Text = currentTarget.Year.ToString();
            this.txtPopulation.Text = BusinessFactory<PopulationBusiness>.Instance.FindById(currentTarget.PopulationId).Name;
            this.txtFund.Text = BusinessFactory<FundBusiness>.Instance.FindById(currentTarget.FundId).Name;
            this.txtCreateTime.Text = currentTarget.CreateBy.Time.ToDateTimeString();
            this.txtUpdateTime.Text = currentTarget.UpdateBy.Time.ToDateTimeString();
        }
        #endregion //Event
    }
}
