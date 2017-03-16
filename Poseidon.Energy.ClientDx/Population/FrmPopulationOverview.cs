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
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 人数总览窗体
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
        /// 载入人数统计
        /// </summary>
        private void LoadPopulations()
        {
            var data = BusinessFactory<PopulationBusiness>.Instance.FindAll().ToList();
            this.bsPopulation.DataSource = data;
        }

        /// <summary>
        /// 显示统计信息
        /// </summary>
        private void DisplayPopulationInfo()
        {
            this.txtName.Text = currentPopulation.Name;
            this.txtYear.Text = currentPopulation.Year.ToString();
            this.txtBelongTime.Text = currentPopulation.BelongTime;
            this.txtRemark.Text = currentPopulation.Remark;
            this.txtCreateUser.Text = currentPopulation.CreateBy.Name;
            this.txtCreateTime.Text = currentPopulation.CreateBy.Time.ToDateTimeString();
            this.txtEditUser.Text = currentPopulation.UpdateBy.Name;
            this.txtEditTime.Text = currentPopulation.UpdateBy.Time.ToDateTimeString();

            int teacherNumber = BusinessFactory<PopulationBusiness>.Instance.GetTeacherNumber(this.currentPopulation.Id);
            int studentNumber = BusinessFactory<PopulationBusiness>.Instance.GetStudentNumber(this.currentPopulation.Id);

            this.txtTotalTeacherNumber.Text = teacherNumber.ToString();
            this.txtTotalStudentNumber.Text = studentNumber.ToString();
            this.txtTotalNumber.Text = (teacherNumber + studentNumber).ToString();

            LoadPopulationDetails(this.currentPopulation.Id);
            LoadPopulationRecords(this.currentPopulation.Id);
        }

        /// <summary>
        /// 载入合计人数记录项
        /// </summary>
        /// <param name="populationId">统计ID</param>
        private void LoadPopulationDetails(string populationId)
        {
            var data = BusinessFactory<PopulationRecordBusiness>.Instance.FindSumDetails(populationId).ToList();
            this.popDetailsGrid.DataSource = data;
        }

        /// <summary>
        /// 载入人数记录
        /// </summary>
        /// <param name="populationId">统计ID</param>
        private void LoadPopulationRecords(string populationId)
        {
            var data = BusinessFactory<PopulationRecordBusiness>.Instance.FindByPopulationId(populationId).ToList(); ;
            this.popRecordGrid.DataSource = data;
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
            if (this.lbPopulation.SelectedItem == null)
                return;

            this.currentPopulation = this.lbPopulation.SelectedItem as Population;
            DisplayPopulationInfo();
        }

        /// <summary>
        /// 查看详细记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            if (this.currentPopulation == null)
                return;

            var select = this.popRecordGrid.GetCurrentSelect();
            if (select == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmPopulationRecordView), new object[] { select.Id });
        }
        #endregion //Event
    }
}
