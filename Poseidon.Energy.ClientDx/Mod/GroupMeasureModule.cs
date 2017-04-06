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

    /// <summary>
    /// 分组能耗计量组件
    /// </summary>
    public partial class GroupMeasureModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;
        #endregion //Field

        #region Constructor
        public GroupMeasureModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入能源计量
        /// </summary>
        private void LoadMeasures()
        {
            var measures = BusinessFactory<MeasureBusiness>.Instance.FindAll().OrderByDescending(r => r.StartTime);
            this.bsMeasure.DataSource = measures;
        }

        /// <summary>
        /// 显示能源计量信息
        /// </summary>
        /// <param name="measure">能源计量</param>
        /// <param name="group">分组</param>
        private void DisplayInfo(Measure measure, Group group)
        {
            var measureRecords = BusinessFactory<MeasureRecordBusiness>.Instance.FindByMeasureId(measure.Id);
            var groupItems = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

            var records = measureRecords.Where(r => groupItems.Select(s => s.OrganizationId).Contains(r.DepartmentId)).ToList();
            this.recordGrid.DataSource = records;

            this.txtGroupName.Text = group.Name;
            this.txtDepartmentCount.Text = records.Count.ToString();
            this.txtName.Text = measure.Name;
            this.txtBelongTime.Text = measure.BelongTime;
            this.txtYear.Text = measure.Year.ToString();
            this.txtEnergyType.Text = DictUtility.GetDictValue(measure, "EnergyType", measure.EnergyType);
            this.chkIncluded.Checked = measure.Included;
            this.txtStartTime.Text = measure.StartTime.ToDateString();
            this.txtEndTime.Text = measure.EndTime.ToDateString();
            this.txtRemark.Text = measure.Remark;
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
            LoadMeasures();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 能源计量选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbMeasures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbMeasures.SelectedItem == null)
            {
                return;
            }

            var measure = this.lbMeasures.SelectedItem as Measure;
            DisplayInfo(measure, this.currentGroup);
        }
        #endregion //Event
    }
}
