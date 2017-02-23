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
            var data = BusinessFactory<PopulationBusiness>.Instance.FindAll().ToList();
            this.bsPopulation.DataSource = data;

            base.InitForm();
        }

        private void LoadStaffNumber(string populationId)
        {

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

        }

        /// <summary>
        /// 添加统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmPopulationAdd));
        }

        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            if (this.luBelongTime.EditValue == null)
                return;


        }
        #endregion //Event


    }
}
