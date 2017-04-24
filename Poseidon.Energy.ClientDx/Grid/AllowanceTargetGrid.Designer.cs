namespace Poseidon.Energy.ClientDx
{
    partial class AllowanceTargetGrid
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
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthKilowatt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearKilowatt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Energy.Core.DL.AllowanceTarget);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(523, 336);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colCode,
            this.colCardinal,
            this.colFactor,
            this.colMonthKilowatt,
            this.colMonthCount,
            this.colYearKilowatt,
            this.colUnitPrice,
            this.colYearAmount,
            this.colRemark});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsCustomization.AllowFilter = false;
            this.dgvEntity.OptionsCustomization.AllowGroup = false;
            this.dgvEntity.OptionsCustomization.AllowQuickHideColumns = false;
            this.dgvEntity.OptionsCustomization.AllowSort = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colCode
            // 
            this.colCode.Caption = "代码";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            // 
            // colCardinal
            // 
            this.colCardinal.Caption = "基数";
            this.colCardinal.FieldName = "Cardinal";
            this.colCardinal.Name = "colCardinal";
            this.colCardinal.Visible = true;
            this.colCardinal.VisibleIndex = 2;
            // 
            // colFactor
            // 
            this.colFactor.Caption = "系数";
            this.colFactor.FieldName = "Factor";
            this.colFactor.Name = "colFactor";
            this.colFactor.Visible = true;
            this.colFactor.VisibleIndex = 3;
            // 
            // colMonthKilowatt
            // 
            this.colMonthKilowatt.Caption = "月度数";
            this.colMonthKilowatt.FieldName = "MonthKilowatt";
            this.colMonthKilowatt.Name = "colMonthKilowatt";
            this.colMonthKilowatt.Visible = true;
            this.colMonthKilowatt.VisibleIndex = 4;
            // 
            // colMonthCount
            // 
            this.colMonthCount.Caption = "月数";
            this.colMonthCount.FieldName = "MonthCount";
            this.colMonthCount.Name = "colMonthCount";
            this.colMonthCount.Visible = true;
            this.colMonthCount.VisibleIndex = 5;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "单价";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 7;
            // 
            // colYearKilowatt
            // 
            this.colYearKilowatt.Caption = "年指标度数";
            this.colYearKilowatt.FieldName = "YearKilowatt";
            this.colYearKilowatt.Name = "colYearKilowatt";
            this.colYearKilowatt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "YearKilowatt", "合计={0:0.##}")});
            this.colYearKilowatt.Visible = true;
            this.colYearKilowatt.VisibleIndex = 6;
            // 
            // colYearAmount
            // 
            this.colYearAmount.Caption = "年指标金额";
            this.colYearAmount.FieldName = "YearAmount";
            this.colYearAmount.Name = "colYearAmount";
            this.colYearAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "YearAmount", "合计={0:0.##}")});
            this.colYearAmount.Visible = true;
            this.colYearAmount.VisibleIndex = 8;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 9;
            // 
            // AllowanceTargetGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AllowanceTargetGrid";
            this.Size = new System.Drawing.Size(523, 336);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCardinal;
        private DevExpress.XtraGrid.Columns.GridColumn colFactor;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthKilowatt;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthCount;
        private DevExpress.XtraGrid.Columns.GridColumn colYearKilowatt;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colYearAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
    }
}
