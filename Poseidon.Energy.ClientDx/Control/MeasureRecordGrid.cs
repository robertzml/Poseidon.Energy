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
    using Poseidon.Winform.Base;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;

    /// <summary>
    /// 能源计量表格控件
    /// </summary>
    public partial class MeasureRecordGrid : WinEntityGrid<MeasureRecord>
    {
        #region Field
        /// <summary>
        /// 缓存部门数据
        /// </summary>
        private List<Department> departments;

        /// <summary>
        /// 参考用能记录
        /// </summary>
        private List<MeasureRecord> refRecords;
        #endregion //Field

        #region Constructor
        public MeasureRecordGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置参考用能数据
        /// </summary>
        /// <param name="records"></param>
        public void SetReference(List<MeasureRecord> records)
        {
            this.refRecords = records;
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MeasureRecordGrid_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                this.departments = BusinessFactory<DepartmentBusiness>.Instance.FindAll().ToList();
        }

        /// <summary>
        /// 格式化数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsEntity.Count)
                return;

            if (e.Column.FieldName == "DepartmentId")
            {
                var department = this.departments.Find(r => r.Id == e.Value.ToString());
                e.DisplayText = department.ShortName;
            }
        }

        /// <summary>
        /// 自定义数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsEntity.Count || this.refRecords == null)
                return;

            var record = this.bsEntity[rowIndex] as MeasureRecord;

            if (e.Column.FieldName == "colRefQuantum" && e.IsGetData)
            {
                var refRecord = this.refRecords.Find(r => r.DepartmentId == record.DepartmentId);
                if (refRecord != null)
                    e.Value = refRecord.Quantum;
                else
                    e.Value = 0;
            }
        }
        #endregion //Event

      
    }
}
