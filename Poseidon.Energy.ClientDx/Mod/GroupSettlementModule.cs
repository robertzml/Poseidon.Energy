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
    using Poseidon.Common;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 分组能源结算组件
    /// </summary>
    public partial class GroupSettlementModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;
        #endregion //Field

        #region Constructor
        public GroupSettlementModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化控件
        /// </summary>
        private void InitControls()
        {
            this.lbYears.Items.Clear();
            var years = BusinessFactory<SettlementBusiness>.Instance.FindAll().GroupBy(r => r.Year).Select(s => s.Key).OrderByDescending(t => t);

            foreach (var year in years)
            {
                this.lbYears.Items.Add(year.ToString() + "年");
            }
        }

        /// <summary>
        /// 载入汇总数据
        /// </summary>
        /// <param name="year">年度</param>
        /// <param name="group">分组</param>
        private void LoadSummaryData(int year, Group group)
        {
            this.txtGroupName.Text = group.Name;
            this.txtYear.Text = year.ToString();

            var departments = BusinessFactory<DepartmentBusiness>.Instance.FindInGroup(group.Code, true).ToList();

            var elecQuantum = BusinessFactory<SettlementBusiness>.Instance.GetQuantumSummary(year, EnergyType.Electric, departments).ToList();
            this.electricQSGrid.DataSource = elecQuantum;

            var waterQuantum = BusinessFactory<SettlementBusiness>.Instance.GetQuantumSummary(year, EnergyType.Water, departments).ToList();
            this.waterQSGrid.DataSource = waterQuantum;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置关联分组
        /// </summary>
        /// <param name="id">分组ID</param>
        public void SetGroup(string id)
        {
            this.currentGroup = BusinessFactory<GroupBusiness>.Instance.FindById(id);
            InitControls();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 选择年度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbYears.SelectedIndex == -1)
                return;

            string text = this.lbYears.SelectedItem.ToString();
            int year = Convert.ToInt32(text.Substring(0, 4));
            LoadSummaryData(year, this.currentGroup);
        }
        #endregion //Event
    }
}
