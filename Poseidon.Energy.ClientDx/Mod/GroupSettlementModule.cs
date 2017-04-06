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
            var settlements = BusinessFactory<SettlementBusiness>.Instance.FindAll();

            this.lbYears.Items.Clear();
            var years = settlements.GroupBy(r => r.Year).Select(s => s.Key).OrderByDescending(t => t);

            foreach (var year in years)
            {
                this.lbYears.Items.Add(year.ToString() + "年");
            }

            this.bsSettlement.DataSource = settlements;
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

            var elecAmount = BusinessFactory<SettlementBusiness>.Instance.GetAmountSummary(year, EnergyType.Electric, departments).ToList();
            this.elecASGrid.DataSource = elecAmount;

            var waterAmount = BusinessFactory<SettlementBusiness>.Instance.GetAmountSummary(year, EnergyType.Water, departments).ToList();
            this.watASGrid.DataSource = waterAmount;

            this.txtTotalElectricQuantum.Text = string.Format("{0}度", elecQuantum.Sum(r => r.TotalQuantum));
            this.txtTotalElectricAmount.Text = string.Format("{0}元", elecAmount.Sum(r => r.TotalAmount));
            this.txtTotalWaterQuantum.Text = string.Format("{0}吨", waterQuantum.Sum(r => r.TotalQuantum));
            this.txtTotalWaterAmount.Text = string.Format("{0}元", waterAmount.Sum(r => r.TotalAmount));
        }

        /// <summary>
        /// 显示能源结算信息
        /// </summary>
        /// <param name="entity">能源结算</param>
        /// <param name="group">分组</param>
        public void DisplaySettlmentInfo(Settlement entity, Group group)
        {
            this.txtGroupName2.Text = group.Name;
            this.txtName.Text = entity.Name;
            this.txtYear2.Text = entity.Year.ToString();
            this.txtBelongTime.Text = entity.BelongTime;
            this.txtSettlementType.Text = ((SettlementType)entity.Type).DisplayName();
            this.txtCreateUser.Text = entity.CreateBy.Name;
            this.txtCreateTime.Text = entity.CreateBy.Time.ToDateTimeString();
            this.txtEditUser.Text = entity.UpdateBy.Name;
            this.txtEditTime.Text = entity.UpdateBy.Time.ToDateTimeString();
            this.txtRemark.Text = entity.Remark;

            var target = BusinessFactory<TargetBusiness>.Instance.FindById(entity.TargetId);
            this.txtTargetName.Text = target.Name;

            if (string.IsNullOrEmpty(entity.PreviousId))
                this.txtPrevious.Text = "首次结算";
            else
            {
                var previous = BusinessFactory<SettlementBusiness>.Instance.FindById(entity.PreviousId);
                this.txtPrevious.Text = previous.Name;
            }

            this.electricSRGrid.DataSource = BusinessFactory<SettlementRecordBusiness>.Instance.FindBySettlement(entity.Id, EnergyType.Electric).ToList();
            this.waterSRGrid.DataSource = BusinessFactory<SettlementRecordBusiness>.Instance.FindBySettlement(entity.Id, EnergyType.Water).ToList();
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

        /// <summary>
        /// 选择结算记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbSettlements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbSettlements.SelectedItem == null)
            {
                return;
            }

            var settlement = this.lbSettlements.SelectedItem as Settlement;
            DisplaySettlmentInfo(settlement, this.currentGroup);
        }
        #endregion //Event
    }
}
