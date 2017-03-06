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
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 人数统计总览窗体
    /// </summary>
    public partial class FrmPopulationOverview : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前关联统计
        /// </summary>
        private Population currentPopulation;
        #endregion //Field

        #region Constructor
        public FrmPopulationOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadPopulations();

            base.InitForm();
        }

        /// <summary>
        /// 载入人口统计
        /// </summary>
        private void LoadPopulations()
        {
            var data = BusinessFactory<PopulationBusiness>.Instance.FindAll().ToList();
            this.bsPopulation.DataSource = data;
        }

        /// <summary>
        /// 载入人数记录
        /// </summary>
        /// <param name="populationId">统计ID</param>
        private void LoadPopulationRecords(string populationId)
        {
            var data = BusinessFactory<PopulationRecordBusiness>.Instance.FindByPopulationId(populationId).ToList(); ;
            this.prGrid.DataSource = data;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 选择统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbPopulation_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentPopulation = this.lbPopulation.SelectedItem as Population;
            this.txtName.Text = currentPopulation.Name;
            this.txtYear.Text = currentPopulation.Year.ToString();
            this.txtBelongTime.Text = currentPopulation.BelongTime;
            this.txtRemark.Text = currentPopulation.Remark;
            this.txtCreateTime.Text = currentPopulation.CreateBy.Time.ToDateTimeString();
            this.txtUpdateTime.Text = currentPopulation.UpdateBy.Time.ToDateTimeString();

            LoadPopulationRecords(this.currentPopulation.Id);
        }

        /// <summary>
        /// 添加统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmPopulationAdd));
            LoadPopulations();
        }

        /// <summary>
        /// 编辑统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.currentPopulation == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmPopulationEdit), new object[] { this.currentPopulation.Id });
            LoadPopulations();
        }

        /// <summary>
        /// 删除统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.currentPopulation == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否确认删除选中人数统计") == DialogResult.Yes)
            {
                try
                {
                    BusinessFactory<PopulationBusiness>.Instance.Delete(this.currentPopulation);
                    LoadPopulations();

                    MessageUtil.ShowInfo("删除成功");
                }
                catch (PoseidonException pe)
                {
                    MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
                }
            }
        }

        /// <summary>
        /// 编辑记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditNumber_Click(object sender, EventArgs e)
        {
            if (this.currentPopulation == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmPopulationRecordEdit), new object[] { this.currentPopulation.Id });
            LoadPopulations();
        }
        #endregion //Event
    }
}
