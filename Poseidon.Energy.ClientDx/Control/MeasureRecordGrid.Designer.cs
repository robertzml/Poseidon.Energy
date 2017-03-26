namespace Poseidon.Energy.ClientDx
{
    partial class MeasureRecordGrid
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.colMeasureId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncrease = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Energy.Core.DL.MeasureRecord);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMeasureId,
            this.colDepartmentId,
            this.colRefQuantum,
            this.colQuantum,
            this.colIncrease,
            this.colRemark,
            this.colStatus});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsDetail.EnableMasterViewMode = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            this.dgvEntity.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.dgvEntity_CustomSummaryCalculate);
            this.dgvEntity.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.dgvEntity_CustomUnboundColumnData);
            this.dgvEntity.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.dgvEntity_CustomColumnDisplayText);
            // 
            // colMeasureId
            // 
            this.colMeasureId.FieldName = "MeasureId";
            this.colMeasureId.Name = "colMeasureId";
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.Caption = "部门名称";
            this.colDepartmentId.FieldName = "DepartmentId";
            this.colDepartmentId.Name = "colDepartmentId";
            this.colDepartmentId.OptionsColumn.AllowEdit = false;
            this.colDepartmentId.Visible = true;
            this.colDepartmentId.VisibleIndex = 0;
            // 
            // colQuantum
            // 
            this.colQuantum.Caption = "用量(度/吨)";
            this.colQuantum.FieldName = "Quantum";
            this.colQuantum.Name = "colQuantum";
            this.colQuantum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantum", "合计={0:0.##}")});
            this.colQuantum.Visible = true;
            this.colQuantum.VisibleIndex = 2;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 4;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colRefQuantum
            // 
            this.colRefQuantum.Caption = "参考用量(度/吨)";
            this.colRefQuantum.FieldName = "colRefQuantum";
            this.colRefQuantum.Name = "colRefQuantum";
            this.colRefQuantum.OptionsColumn.AllowEdit = false;
            this.colRefQuantum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colRefQuantum", "合计={0:0.##}")});
            this.colRefQuantum.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colRefQuantum.Visible = true;
            this.colRefQuantum.VisibleIndex = 1;
            // 
            // colIncrease
            // 
            this.colIncrease.Caption = "涨幅";
            this.colIncrease.DisplayFormat.FormatString = "p1";
            this.colIncrease.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colIncrease.FieldName = "colIncrease";
            this.colIncrease.Name = "colIncrease";
            this.colIncrease.OptionsColumn.AllowEdit = false;
            this.colIncrease.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colIncrease", "{0:p1}")});
            this.colIncrease.UnboundExpression = "Iif([colRefQuantum] = 0, 1, ([Quantum] - [colRefQuantum]) / [colRefQuantum])";
            this.colIncrease.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colIncrease.Visible = true;
            this.colIncrease.VisibleIndex = 3;
            // 
            // MeasureRecordGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MeasureRecordGrid";
            this.ShowFooter = true;
            this.Load += new System.EventHandler(this.MeasureRecordGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colMeasureId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colRefQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colIncrease;
    }
}
