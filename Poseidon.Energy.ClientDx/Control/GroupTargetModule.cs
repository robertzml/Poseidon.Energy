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
    using DevExpress.XtraReports.UI;
    using Poseidon.Base.Framework;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.ClientDx.Report;

    /// <summary>
    /// 分组下指标计划组件
    /// </summary>
    public partial class GroupTargetModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;
        #endregion //Field

        #region Constructor
        public GroupTargetModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入相关指标计划
        /// </summary>
        private void LoadTargets()
        {
            var targets = BusinessFactory<TargetBusiness>.Instance.FindAll().OrderByDescending(r => r.Year);
            this.bsTarget.DataSource = targets;
        }

        /// <summary>
        /// 载入相关指标记录
        /// </summary>
        /// <param name="target">指标计划</param>
        /// <param name="group">相关分组</param>
        private void LoadTargetRecords(Target target, Group group)
        {
            var records = BusinessFactory<TargetRecordBusiness>.Instance.FindByTarget(target.Id);
            var groupItems = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

            records = records.Where(r => groupItems.Select(s => s.OrganizationId).Contains(r.DepartmentId));

            this.recordGrid.DataSource = records.ToList();
        }

        private void DisplayInfo(Target target)
        {

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
            LoadTargets();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 选择指标计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbTargets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbTargets.SelectedItem == null)
            {
                return;
            }

            var target = this.lbTargets.SelectedItem as Target;
            DisplayInfo(target);
            LoadTargetRecords(target, this.currentGroup);
        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.lbTargets.SelectedItem == null)
            {
                return;
            }
            var target = this.lbTargets.SelectedItem as Target;

            var data = this.recordGrid.DataSource;

            RepDepartmentTarget report = new RepDepartmentTarget();
            report.DataSource = data;
            report.Parameters["Year"].Value = target.Year;

            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowRibbonPreview();
        }
        #endregion //Event
    }
}
