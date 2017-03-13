namespace Poseidon.Energy.ClientDx
{
    partial class ElectricExpenseRecordGrid
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
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.colMeterNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFeeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCmbFeeType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colPrevious = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMultiple = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalcQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCmbFeeType)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Energy.Core.DL.ElectricExpenseRecord);
            // 
            // dgcEntity
            // 
            this.dgcEntity.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCmbFeeType});
            this.dgcEntity.Size = new System.Drawing.Size(647, 354);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMeterNumber,
            this.colMeterName,
            this.colFeeType,
            this.colPrevious,
            this.colCurrent,
            this.colMultiple,
            this.colCalcQuantity,
            this.colQuantity,
            this.colUnitPrice,
            this.colAmount,
            this.colPrize,
            this.colRemark});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.DataSource = this.bsEntity;
            this.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataNavigator1.Location = new System.Drawing.Point(0, 354);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(647, 24);
            this.dataNavigator1.TabIndex = 1;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dataNavigator1.TextStringFormat = "记录 {0} of {1}";
            // 
            // colMeterNumber
            // 
            this.colMeterNumber.Caption = "电表编号";
            this.colMeterNumber.FieldName = "MeterNumber";
            this.colMeterNumber.Name = "colMeterNumber";
            this.colMeterNumber.Visible = true;
            this.colMeterNumber.VisibleIndex = 0;
            // 
            // colMeterName
            // 
            this.colMeterName.Caption = "电表名称";
            this.colMeterName.FieldName = "MeterName";
            this.colMeterName.Name = "colMeterName";
            this.colMeterName.Visible = true;
            this.colMeterName.VisibleIndex = 1;
            // 
            // colFeeType
            // 
            this.colFeeType.Caption = "费用类型";
            this.colFeeType.ColumnEdit = this.repoCmbFeeType;
            this.colFeeType.FieldName = "FeeType";
            this.colFeeType.Name = "colFeeType";
            this.colFeeType.Visible = true;
            this.colFeeType.VisibleIndex = 2;
            // 
            // repoCmbFeeType
            // 
            this.repoCmbFeeType.AutoHeight = false;
            this.repoCmbFeeType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoCmbFeeType.Name = "repoCmbFeeType";
            // 
            // colPrevious
            // 
            this.colPrevious.Caption = "上期数";
            this.colPrevious.FieldName = "Previous";
            this.colPrevious.Name = "colPrevious";
            this.colPrevious.Visible = true;
            this.colPrevious.VisibleIndex = 3;
            // 
            // colCurrent
            // 
            this.colCurrent.Caption = "本期数";
            this.colCurrent.FieldName = "Current";
            this.colCurrent.Name = "colCurrent";
            this.colCurrent.Visible = true;
            this.colCurrent.VisibleIndex = 4;
            // 
            // colMultiple
            // 
            this.colMultiple.Caption = "倍率";
            this.colMultiple.FieldName = "Multiple";
            this.colMultiple.Name = "colMultiple";
            this.colMultiple.Visible = true;
            this.colMultiple.VisibleIndex = 5;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "用量(度)";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "合计={0:0.##}")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 7;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "单价";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 8;
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
            // colPrize
            // 
            this.colPrize.Caption = "功率因数奖(元)";
            this.colPrize.FieldName = "Prize";
            this.colPrize.Name = "colPrize";
            this.colPrize.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Prize", "合计={0:0.##}")});
            this.colPrize.Visible = true;
            this.colPrize.VisibleIndex = 10;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 11;
            // 
            // colCalcQuantity
            // 
            this.colCalcQuantity.Caption = "计算用量";
            this.colCalcQuantity.FieldName = "colCalcQuantity";
            this.colCalcQuantity.Name = "colCalcQuantity";
            this.colCalcQuantity.OptionsColumn.AllowEdit = false;
            this.colCalcQuantity.UnboundExpression = "([Current] - [Previous]) * [Multiple]";
            this.colCalcQuantity.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colCalcQuantity.Visible = true;
            this.colCalcQuantity.VisibleIndex = 6;
            // 
            // ElectricExpenseRecordGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataNavigator1);
            this.Name = "ElectricExpenseRecordGrid";
            this.Size = new System.Drawing.Size(647, 378);
            this.Load += new System.EventHandler(this.ElectricExpenseRecordGrid_Load);
            this.Controls.SetChildIndex(this.dataNavigator1, 0);
            this.Controls.SetChildIndex(this.dgcEntity, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCmbFeeType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraGrid.Columns.GridColumn colMeterNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMeterName;
        private DevExpress.XtraGrid.Columns.GridColumn colFeeType;
        private DevExpress.XtraGrid.Columns.GridColumn colPrevious;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrent;
        private DevExpress.XtraGrid.Columns.GridColumn colMultiple;
        private DevExpress.XtraGrid.Columns.GridColumn colCalcQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPrize;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoCmbFeeType;
    }
}
