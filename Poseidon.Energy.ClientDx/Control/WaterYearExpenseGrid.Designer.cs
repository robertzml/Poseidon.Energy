namespace Poseidon.Energy.ClientDx
{
    partial class WaterYearExpenseGrid
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
            this.colBelongDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Energy.Core.DL.WaterExpense);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBelongDate,
            this.colTotalQuantity,
            this.colTotalAmount});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsDetail.EnableMasterViewMode = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            // 
            // colBelongDate
            // 
            this.colBelongDate.Caption = "月份";
            this.colBelongDate.DisplayFormat.FormatString = "yyyy年MM月";
            this.colBelongDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBelongDate.FieldName = "BelongDate";
            this.colBelongDate.Name = "colBelongDate";
            this.colBelongDate.Visible = true;
            this.colBelongDate.VisibleIndex = 0;
            // 
            // colTotalQuantity
            // 
            this.colTotalQuantity.Caption = "用水量(吨)";
            this.colTotalQuantity.FieldName = "TotalQuantity";
            this.colTotalQuantity.Name = "colTotalQuantity";
            this.colTotalQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQuantity", "合计={0:0.##}")});
            this.colTotalQuantity.Visible = true;
            this.colTotalQuantity.VisibleIndex = 1;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Caption = "金额(元)";
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "合计={0:0.##}")});
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 2;
            // 
            // WaterYearExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "WaterYearExpense";
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn colBelongDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
    }
}
