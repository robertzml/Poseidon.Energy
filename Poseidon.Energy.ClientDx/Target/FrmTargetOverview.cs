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

    /// <summary>
    /// 指标计划总览窗体
    /// </summary>
    public partial class FrmTargetOverview : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前关联指标计划
        /// </summary>
        private PlanTarget currentPlanTarget;
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
            LoadPlanTargets();

            base.InitForm();
        }

        private void LoadPlanTargets()
        {
            var data = BusinessFactory<PlanTargetBusiness>.Instance.FindAll().ToList();
            this.bsPlanTarget.DataSource = data;
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
            this.currentPlanTarget = this.lbPlanTarget.SelectedItem as PlanTarget;

            this.txtName.Text = currentPlanTarget.Name;
            this.txtYear.Text = currentPlanTarget.Year.ToString();
            this.txtPopulation.Text = currentPlanTarget.PopulationId;
            this.txtFund.Text = currentPlanTarget.FundId;
            this.txtCreateTime.Text = currentPlanTarget.CreateTime.ToDateTimeString();
            this.txtUpdateTime.Text = currentPlanTarget.UpdateTime.ToDateTimeString();
        }

        /// <summary>
        /// 添加计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmTargetAdd));

            LoadPlanTargets();
        }


        /// <summary>
        /// 指标设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSet_Click(object sender, EventArgs e)
        {
            if (this.currentPlanTarget == null)
                return;
        }
        #endregion //Event

    }
}
