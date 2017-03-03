namespace Poseidon.Energy.ClientDx
{
    partial class StaffTargetGrid
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
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthKilowatt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearKilowatt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Energy.Core.DL.StaffTarget);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(462, 303);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colCode,
            this.colNumber,
            this.colMonthKilowatt,
            this.colMonthCount,
            this.colYearKilowatt,
            this.colUnitPrice,
            this.colYearAmount,
            this.colRemark});
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsCustomization.AllowColumnMoving = false;
            this.dgvEntity.OptionsCustomization.AllowFilter = false;
            this.dgvEntity.OptionsCustomization.AllowGroup = false;
            this.dgvEntity.OptionsCustomization.AllowQuickHideColumns = false;
            this.dgvEntity.OptionsCustomization.AllowSort = false;
            this.dgvEntity.OptionsMenu.EnableColumnMenu = false;
            this.dgvEntity.OptionsMenu.EnableGroupPanelMenu = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.AllowEdit = false;
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            // 
            // colNumber
            // 
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 2;
            // 
            // colMonthKilowatt
            // 
            this.colMonthKilowatt.FieldName = "MonthKilowatt";
            this.colMonthKilowatt.Name = "colMonthKilowatt";
            this.colMonthKilowatt.Visible = true;
            this.colMonthKilowatt.VisibleIndex = 3;
            // 
            // colMonthCount
            // 
            this.colMonthCount.FieldName = "MonthCount";
            this.colMonthCount.Name = "colMonthCount";
            this.colMonthCount.Visible = true;
            this.colMonthCount.VisibleIndex = 4;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 6;
            // 
            // colYearKilowatt
            // 
            this.colYearKilowatt.FieldName = "YearKilowatt";
            this.colYearKilowatt.Name = "colYearKilowatt";
            this.colYearKilowatt.OptionsColumn.AllowEdit = false;
            this.colYearKilowatt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "YearKilowatt", "合计={0:0.##}")});
            this.colYearKilowatt.Visible = true;
            this.colYearKilowatt.VisibleIndex = 5;
            // 
            // colYearAmount
            // 
            this.colYearAmount.FieldName = "YearAmount";
            this.colYearAmount.Name = "colYearAmount";
            this.colYearAmount.OptionsColumn.AllowEdit = false;
            this.colYearAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "YearAmount", "合计={0:0.##}")});
            this.colYearAmount.Visible = true;
            this.colYearAmount.VisibleIndex = 7;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 8;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // StaffTargetGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "StaffTargetGrid";
            this.Size = new System.Drawing.Size(462, 303);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthKilowatt;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthCount;
        private DevExpress.XtraGrid.Columns.GridColumn colYearKilowatt;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colYearAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
    }
}
