using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Energy.ClientDx
{
    using DevExpress.Data;
    using DevExpress.XtraGrid;
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Winform.Core.Utility;
    using Poseidon.Energy.Core.BL;
    using Poseidon.Energy.Core.DL;
    using Poseidon.Energy.Core.Utility;

    /// <summary>
    /// 能源结算记录表格控件
    /// </summary>
    public partial class SettlementRecordGrid : WinEntityGrid<SettlementRecord>
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

        /// <summary>
        /// 是否显示参考用能列
        /// </summary>
        private bool showRefColumn = true;
        #endregion //Field

        #region Constructor
        public SettlementRecordGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置能源类型
        /// </summary>
        /// <param name="type">类型</param>
        public void SetEnergyType(EnergyType type)
        {
            if (type == EnergyType.Electric)
            {
                this.colBeginQuantum.Caption = "期初用电量(度)";
                this.colRefQuantum.Caption = "参考用电量(度)";
                this.colQuantum.Caption = "用电量(度)";
                this.colEndQuantum.Caption = "期末用电量(度)";
            }
            else if (type == EnergyType.Water)
            {
                this.colBeginQuantum.Caption = "期初用水量(吨)";
                this.colRefQuantum.Caption = "参考用水量";
                this.colQuantum.Caption = "用水量(吨)";
                this.colEndQuantum.Caption = "期末用水量(吨)";
            }
        }

        /// <summary>
        /// 设置参考用能数据
        /// </summary>
        /// <param name="records">用能数据</param>
        public void SetReferenceMeasure(List<MeasureRecord> records)
        {
            this.refRecords = records;

            //re update the unbound column
            this.dgvEntity.Columns.Remove(this.colRefQuantum);
            this.dgvEntity.Columns.Add(colRefQuantum);
            this.colRefQuantum.Visible = true;
            this.colRefQuantum.VisibleIndex = 5;
        }

        /// <summary>
        /// 采用参考用量
        /// </summary>
        public void UseRefQuantum()
        {
            for (int i = 0; i < this.dgvEntity.RowCount; i++)
            {
                var quantum = Convert.ToDecimal(this.dgvEntity.GetRowCellValue(i, "colRefQuantum"));
                this.dgvEntity.SetRowCellValue(i, "Quantum", quantum);
            }
        }

        /// <summary>
        /// 采用参考金额
        /// </summary>
        public void UseRefAmount()
        {
            for (int i = 0; i < this.dgvEntity.RowCount; i++)
            {
                var amount = Convert.ToDecimal(this.dgvEntity.GetRowCellValue(i, "colRefAmount"));
                this.dgvEntity.SetRowCellValue(i, "Amount", amount);
            }
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettlementRecordGrid_Load(object sender, EventArgs e)
        {
            if (!ControlUtil.IsInDesignMode())
                this.departments = BusinessFactory<DepartmentBusiness>.Instance.FindAll().ToList();

            this.colRefQuantum.Visible = this.showRefColumn;
            this.colRefAmount.Visible = this.showRefColumn;
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
            if (e.Column.FieldName == "EnergyType")
            {
                e.DisplayText = ((EnergyType)e.Value).DisplayName();
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

            var record = this.bsEntity[rowIndex] as SettlementRecord;

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

        #region Property
        /// <summary>
        /// 是否显示参考列
        /// </summary>
        [Category("界面"), Description("是否显示参考列"), Browsable(true)]
        public bool ShowRefColumn
        {
            get
            {
                return this.showRefColumn;
            }
            set
            {
                this.showRefColumn = value;
            }
        }
        #endregion //Property
    }
}
