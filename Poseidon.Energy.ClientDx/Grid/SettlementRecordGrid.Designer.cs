namespace Poseidon.Energy.ClientDx
{
    partial class SettlementRecordGrid
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
            this.colSettlementId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnergyType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeginQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeginAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Energy.Core.DL.SettlementRecord);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(745, 423);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSettlementId,
            this.colDepartmentId,
            this.colEnergyType,
            this.colUnitPrice,
            this.colBeginQuantum,
            this.colBeginAmount,
            this.colRefQuantum,
            this.colQuantum,
            this.colRefAmount,
            this.colAmount,
            this.colEndQuantum,
            this.colEndAmount,
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
            this.dgvEntity.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.dgvEntity_CustomUnboundColumnData);
            this.dgvEntity.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.dgvEntity_CustomColumnDisplayText);
            // 
            // colSettlementId
            // 
            this.colSettlementId.Caption = "结算名称";
            this.colSettlementId.FieldName = "SettlementId";
            this.colSettlementId.Name = "colSettlementId";
            this.colSettlementId.OptionsColumn.AllowEdit = false;
            this.colSettlementId.Visible = true;
            this.colSettlementId.VisibleIndex = 0;
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.Caption = "部门名称";
            this.colDepartmentId.FieldName = "DepartmentId";
            this.colDepartmentId.Name = "colDepartmentId";
            this.colDepartmentId.OptionsColumn.AllowEdit = false;
            this.colDepartmentId.Visible = true;
            this.colDepartmentId.VisibleIndex = 1;
            // 
            // colEnergyType
            // 
            this.colEnergyType.FieldName = "EnergyType";
            this.colEnergyType.Name = "colEnergyType";
            this.colEnergyType.OptionsColumn.AllowEdit = false;
            this.colEnergyType.Visible = true;
            this.colEnergyType.VisibleIndex = 2;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 3;
            // 
            // colBeginQuantum
            // 
            this.colBeginQuantum.FieldName = "BeginQuantum";
            this.colBeginQuantum.Name = "colBeginQuantum";
            this.colBeginQuantum.OptionsColumn.AllowEdit = false;
            this.colBeginQuantum.Visible = true;
            this.colBeginQuantum.VisibleIndex = 4;
            // 
            // colBeginAmount
            // 
            this.colBeginAmount.Caption = "期初金额(元)";
            this.colBeginAmount.FieldName = "BeginAmount";
            this.colBeginAmount.Name = "colBeginAmount";
            this.colBeginAmount.OptionsColumn.AllowEdit = false;
            this.colBeginAmount.Visible = true;
            this.colBeginAmount.VisibleIndex = 5;
            // 
            // colQuantum
            // 
            this.colQuantum.FieldName = "Quantum";
            this.colQuantum.Name = "colQuantum";
            this.colQuantum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantum", "合计={0:0.##}")});
            this.colQuantum.Visible = true;
            this.colQuantum.VisibleIndex = 7;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "金额(元)";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "合计={0:0.##}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 9;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 12;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colRefQuantum
            // 
            this.colRefQuantum.Caption = "参考用电量";
            this.colRefQuantum.FieldName = "colRefQuantum";
            this.colRefQuantum.Name = "colRefQuantum";
            this.colRefQuantum.OptionsColumn.AllowEdit = false;
            this.colRefQuantum.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colRefQuantum.Visible = true;
            this.colRefQuantum.VisibleIndex = 6;
            // 
            // colRefAmount
            // 
            this.colRefAmount.Caption = "参考金额";
            this.colRefAmount.FieldName = "colRefAmount";
            this.colRefAmount.Name = "colRefAmount";
            this.colRefAmount.OptionsColumn.AllowEdit = false;
            this.colRefAmount.UnboundExpression = "Round([UnitPrice] * [colRefQuantum])";
            this.colRefAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colRefAmount.Visible = true;
            this.colRefAmount.VisibleIndex = 8;
            // 
            // colEndAmount
            // 
            this.colEndAmount.Caption = "期末金额(元)";
            this.colEndAmount.FieldName = "colEndAmount";
            this.colEndAmount.Name = "colEndAmount";
            this.colEndAmount.OptionsColumn.AllowEdit = false;
            this.colEndAmount.UnboundExpression = "[BeginAmount] - [Amount]";
            this.colEndAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colEndAmount.Visible = true;
            this.colEndAmount.VisibleIndex = 11;
            // 
            // colEndQuantum
            // 
            this.colEndQuantum.Caption = "期末用电量";
            this.colEndQuantum.FieldName = "colEndQuantum";
            this.colEndQuantum.Name = "colEndQuantum";
            this.colEndQuantum.OptionsColumn.AllowEdit = false;
            this.colEndQuantum.UnboundExpression = "[BeginQuantum] - [Quantum]";
            this.colEndQuantum.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colEndQuantum.Visible = true;
            this.colEndQuantum.VisibleIndex = 10;
            // 
            // SettlementRecordGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SettlementRecordGrid";
            this.Size = new System.Drawing.Size(745, 423);
            this.ExportToExcelCustomCell += new System.Action<DevExpress.Export.CustomizeCellEventArgs>(this.SettlementRecordGrid_ExportToExcelCustomCell);
            this.Load += new System.EventHandler(this.SettlementRecordGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colSettlementId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colEnergyType;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colBeginQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colBeginAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colRefQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colRefAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colEndQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colEndAmount;
    }
}
