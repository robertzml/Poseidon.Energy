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
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 人数统计总览窗体
    /// </summary>
    public partial class FrmPopulationOverview : BaseMdiForm
    {
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
        private void LoadStaffNumber(string populationId)
        {
            var data = BusinessFactory<PopulationRecordBusiness>.Instance.FindByPopulationId(populationId).ToList(); ;
            this.prGrid.DataSource = data;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 归属时间选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luBelongTime_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luBelongTime.EditValue == null)
                this.prGrid.Clear();
            else
                LoadStaffNumber(this.luBelongTime.EditValue.ToString());
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
        /// 编辑记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditNumber_Click(object sender, EventArgs e)
        {
            if (this.luBelongTime.EditValue == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmPopulationRecordEdit), new object[] { this.luBelongTime.EditValue.ToString() });
        }
        #endregion //Event
    }
}
