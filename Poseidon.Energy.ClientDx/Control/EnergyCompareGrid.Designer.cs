namespace Poseidon.Energy.ClientDx
{
    partial class EnergyCompareGrid
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
            this.colMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantumFirst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountFirst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantumSecond = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountSecond = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiffQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiffAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInclude = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Energy.ClientDx.EnergyCompare);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(659, 414);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInclude,
            this.colMonth,
            this.colQuantumFirst,
            this.colQuantumSecond,
            this.colDiffQuantum,
            this.colIncQuantum,
            this.colAmountFirst,
            this.colAmountSecond,
            this.colDiffAmount,
            this.colIncAmount});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsDetail.EnableMasterViewMode = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowFooter = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            this.dgvEntity.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.dgvEntity_CustomSummaryCalculate);
            // 
            // colMonth
            // 
            this.colMonth.FieldName = "Month";
            this.colMonth.Name = "colMonth";
            this.colMonth.OptionsColumn.AllowEdit = false;
            this.colMonth.Visible = true;
            this.colMonth.VisibleIndex = 1;
            // 
            // colQuantumFirst
            // 
            this.colQuantumFirst.FieldName = "QuantumFirst";
            this.colQuantumFirst.Name = "colQuantumFirst";
            this.colQuantumFirst.OptionsColumn.AllowEdit = false;
            this.colQuantumFirst.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "QuantumFirst", "合计={0:0.##}")});
            this.colQuantumFirst.Visible = true;
            this.colQuantumFirst.VisibleIndex = 2;
            // 
            // colAmountFirst
            // 
            this.colAmountFirst.FieldName = "AmountFirst";
            this.colAmountFirst.Name = "colAmountFirst";
            this.colAmountFirst.OptionsColumn.AllowEdit = false;
            this.colAmountFirst.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "AmountFirst", "合计={0:0.##}")});
            this.colAmountFirst.Visible = true;
            this.colAmountFirst.VisibleIndex = 6;
            // 
            // colQuantumSecond
            // 
            this.colQuantumSecond.FieldName = "QuantumSecond";
            this.colQuantumSecond.Name = "colQuantumSecond";
            this.colQuantumSecond.OptionsColumn.AllowEdit = false;
            this.colQuantumSecond.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "QuantumSecond", "合计={0:0.##}")});
            this.colQuantumSecond.Visible = true;
            this.colQuantumSecond.VisibleIndex = 3;
            // 
            // colAmountSecond
            // 
            this.colAmountSecond.FieldName = "AmountSecond";
            this.colAmountSecond.Name = "colAmountSecond";
            this.colAmountSecond.OptionsColumn.AllowEdit = false;
            this.colAmountSecond.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "AmountSecond", "合计={0:0.##}")});
            this.colAmountSecond.Visible = true;
            this.colAmountSecond.VisibleIndex = 7;
            // 
            // colDiffQuantum
            // 
            this.colDiffQuantum.Caption = "用量增量";
            this.colDiffQuantum.FieldName = "colDiffQuantum";
            this.colDiffQuantum.Name = "colDiffQuantum";
            this.colDiffQuantum.OptionsColumn.AllowEdit = false;
            this.colDiffQuantum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colDiffQuantum", "增量={0:0.##}")});
            this.colDiffQuantum.UnboundExpression = "[QuantumSecond] - [QuantumFirst]";
            this.colDiffQuantum.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDiffQuantum.Visible = true;
            this.colDiffQuantum.VisibleIndex = 4;
            // 
            // colIncQuantum
            // 
            this.colIncQuantum.Caption = "用量涨幅";
            this.colIncQuantum.DisplayFormat.FormatString = "p1";
            this.colIncQuantum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colIncQuantum.FieldName = "colIncQuantum";
            this.colIncQuantum.Name = "colIncQuantum";
            this.colIncQuantum.OptionsColumn.AllowEdit = false;
            this.colIncQuantum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colIncQuantum", "涨幅={0:p1}")});
            this.colIncQuantum.UnboundExpression = "Iif([QuantumFirst] = 0, 1, ([QuantumSecond] - [QuantumFirst]) / [QuantumFirst])";
            this.colIncQuantum.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colIncQuantum.Visible = true;
            this.colIncQuantum.VisibleIndex = 5;
            // 
            // colDiffAmount
            // 
            this.colDiffAmount.Caption = "金额增量";
            this.colDiffAmount.FieldName = "colDiffAmount";
            this.colDiffAmount.Name = "colDiffAmount";
            this.colDiffAmount.OptionsColumn.AllowEdit = false;
            this.colDiffAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colDiffAmount", "增量={0:0.##}")});
            this.colDiffAmount.UnboundExpression = "[AmountSecond] - [AmountFirst]";
            this.colDiffAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDiffAmount.Visible = true;
            this.colDiffAmount.VisibleIndex = 8;
            // 
            // colIncAmount
            // 
            this.colIncAmount.Caption = "金额涨幅";
            this.colIncAmount.DisplayFormat.FormatString = "p1";
            this.colIncAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colIncAmount.FieldName = "colIncAmount";
            this.colIncAmount.Name = "colIncAmount";
            this.colIncAmount.OptionsColumn.AllowEdit = false;
            this.colIncAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colIncAmount", "涨幅={0:0.##}")});
            this.colIncAmount.UnboundExpression = "Iif([AmountFirst] = 0, 1, ([AmountSecond] - [AmountFirst]) / [AmountFirst])";
            this.colIncAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colIncAmount.Visible = true;
            this.colIncAmount.VisibleIndex = 9;
            // 
            // colInclude
            // 
            this.colInclude.Caption = "选择";
            this.colInclude.FieldName = "Include";
            this.colInclude.Name = "colInclude";
            this.colInclude.Visible = true;
            this.colInclude.VisibleIndex = 0;
            // 
            // EnergyCompareGrid
            // 
            this.AllowFilter = false;
            this.AllowGroup = false;
            this.AllowSort = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "EnergyCompareGrid";
            this.ShowFooter = true;
            this.Size = new System.Drawing.Size(659, 414);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantumFirst;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountFirst;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantumSecond;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountSecond;
        private DevExpress.XtraGrid.Columns.GridColumn colDiffQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colIncQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colDiffAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colIncAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colInclude;
    }
}
