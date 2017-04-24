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
    using Poseidon.Core.Utility;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 部门能源计量模块
    /// </summary>
    public partial class DepartmentMeasureModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联部门
        /// </summary>
        private Department currentDepartment;
        #endregion //Field

        #region Constructor
        public DepartmentMeasureModule()
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
            this.subRecordGrid.Init();

            var measures = BusinessFactory<MeasureBusiness>.Instance.FindAll().OrderByDescending(r => r.BelongTime);
            this.bsMeasure.DataSource = measures;
        }

        /// <summary>
        /// 显示能源计量信息
        /// </summary>
        /// <param name="measure">能源计量</param>
        private void DisplayMeasureInfo(Measure measure)
        {
            this.txtName.Text = measure.Name;
            this.txtBelongTime.Text = measure.BelongTime;
            this.txtYear.Text = measure.Year.ToString();
            this.txtEnergyType.Text = ((EnergyType)measure.EnergyType).DisplayName();
            this.chkIncluded.Checked = measure.Included;
            this.txtStartTime.Text = measure.StartTime.ToDateString();
            this.txtEndTime.Text = measure.EndTime.ToDateString();
            this.txtRemark.Text = measure.Remark;
        }

        /// <summary>
        /// 显示能源计量记录信息
        /// </summary>
        /// <param name="measure">能源计量</param>
        /// <param name="department">部门</param>
        private void DisplayRecordInfo(Measure measure, Department department)
        {
            var record = BusinessFactory<MeasureRecordBusiness>.Instance.FindByDepartment(measure.Id, department.Id);
            if (record == null)
            {
                this.txtDepartmentName.Text = "";
                this.txtQuantum.Text = "";
                this.txtRecordRemark.Text = "";
                this.txtCreateUser.Text = "";
                this.txtCreateTime.Text = "";
                this.txtEditUser.Text = "";
                this.txtEditTime.Text = "";
                this.subRecordGrid.DataSource = null;
            }
            else
            {
                this.txtDepartmentName.Text = department.Name;
                this.txtQuantum.Text = record.Quantum.ToString();
                this.txtRecordRemark.Text = record.Remark;
                this.chkRecordIncluded.Checked = record.Included;
                this.txtCreateUser.Text = record.CreateBy.Name;
                this.txtCreateTime.Text = record.CreateBy.Time.ToDateTimeString();
                this.txtEditUser.Text = record.UpdateBy.Name;
                this.txtEditTime.Text = record.UpdateBy.Time.ToDateTimeString();

                List<MeasureRecord> data = new List<MeasureRecord>();
                var children = BusinessFactory<DepartmentBusiness>.Instance.FindChildren(department.Id);
                foreach (var item in children)
                {
                    var subrecord = BusinessFactory<MeasureRecordBusiness>.Instance.FindByDepartment(measure.Id, item.Id);
                    if (subrecord != null)
                        data.Add(subrecord);
                }
                this.subRecordGrid.DataSource = data;
            }
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置关联部门
        /// </summary>
        /// <param name="id">部门ID</param>
        public void SetDepartment(string id)
        {
            this.currentDepartment = BusinessFactory<DepartmentBusiness>.Instance.FindById(id);
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
            DisplayMeasureInfo(measure);
            DisplayRecordInfo(measure, this.currentDepartment);
        }
        #endregion //Event
    }
}
