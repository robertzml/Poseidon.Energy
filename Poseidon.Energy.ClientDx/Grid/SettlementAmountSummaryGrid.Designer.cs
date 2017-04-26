namespace Poseidon.Energy.ClientDx
{
    partial class SettlementAmountSummaryGrid
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.colRemainAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnergyType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstQuarter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecondQuarter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThirdQuarter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFourthQuarter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSchoolTake = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelfTake = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Energy.Core.Utility.SettlementAmountSummary);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDepartmentName,
            this.colYear,
            this.colEnergyType,
            this.colUnitPrice,
            this.colPlanAmount,
            this.colFirstQuarter,
            this.colSecondQuarter,
            this.colThirdQuarter,
            this.colFourthQuarter,
            this.colTotalAmount,
            this.colRemainAmount,
            this.colSchoolTake,
            this.colSelfTake});
            gridFormatRule1.Column = this.colRemainAmount;
            gridFormatRule1.ColumnApplyTo = this.colRemainAmount;
            gridFormatRule1.Name = "Highlight Negative";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Red;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Less;
            formatConditionRuleValue1.Value1 = 0;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.dgvEntity.FormatRules.Add(gridFormatRule1);
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsDetail.EnableMasterViewMode = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            // 
            // colRemainAmount
            // 
            this.colRemainAmount.Caption = "剩余金额(元)";
            this.colRemainAmount.FieldName = "RemainAmount";
            this.colRemainAmount.Name = "colRemainAmount";
            this.colRemainAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RemainAmount", "合计={0:0.##}")});
            this.colRemainAmount.Visible = true;
            this.colRemainAmount.VisibleIndex = 10;
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.FieldName = "DepartmentName";
            this.colDepartmentName.Name = "colDepartmentName";
            this.colDepartmentName.Visible = true;
            this.colDepartmentName.VisibleIndex = 0;
            // 
            // colEnergyType
            // 
            this.colEnergyType.FieldName = "EnergyType";
            this.colEnergyType.Name = "colEnergyType";
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
            // colPlanAmount
            // 
            this.colPlanAmount.Caption = "年度计划金额(元)";
            this.colPlanAmount.FieldName = "PlanAmount";
            this.colPlanAmount.Name = "colPlanAmount";
            this.colPlanAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanAmount", "合计={0:0.##}")});
            this.colPlanAmount.Visible = true;
            this.colPlanAmount.VisibleIndex = 4;
            // 
            // colFirstQuarter
            // 
            this.colFirstQuarter.Caption = "一季度金额(元)";
            this.colFirstQuarter.FieldName = "FirstQuarter";
            this.colFirstQuarter.Name = "colFirstQuarter";
            this.colFirstQuarter.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FirstQuarter", "合计={0:0.##}")});
            this.colFirstQuarter.Visible = true;
            this.colFirstQuarter.VisibleIndex = 5;
            // 
            // colSecondQuarter
            // 
            this.colSecondQuarter.Caption = "二季度金额(元)";
            this.colSecondQuarter.FieldName = "SecondQuarter";
            this.colSecondQuarter.Name = "colSecondQuarter";
            this.colSecondQuarter.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SecondQuarter", "合计={0:0.##}")});
            this.colSecondQuarter.Visible = true;
            this.colSecondQuarter.VisibleIndex = 6;
            // 
            // colThirdQuarter
            // 
            this.colThirdQuarter.Caption = "三季度金额(元)";
            this.colThirdQuarter.FieldName = "ThirdQuarter";
            this.colThirdQuarter.Name = "colThirdQuarter";
            this.colThirdQuarter.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThirdQuarter", "合计={0:0.##}")});
            this.colThirdQuarter.Visible = true;
            this.colThirdQuarter.VisibleIndex = 7;
            // 
            // colFourthQuarter
            // 
            this.colFourthQuarter.Caption = "四季度金额(元)";
            this.colFourthQuarter.FieldName = "FourthQuarter";
            this.colFourthQuarter.Name = "colFourthQuarter";
            this.colFourthQuarter.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FourthQuarter", "合计={0:0.##}")});
            this.colFourthQuarter.Visible = true;
            this.colFourthQuarter.VisibleIndex = 8;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Caption = "累计金额(元)";
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "合计={0:0.##}")});
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 9;
            // 
            // colSchoolTake
            // 
            this.colSchoolTake.Caption = "学校承担金额(元)";
            this.colSchoolTake.FieldName = "SchoolTake";
            this.colSchoolTake.Name = "colSchoolTake";
            this.colSchoolTake.Visible = true;
            this.colSchoolTake.VisibleIndex = 11;
            // 
            // colSelfTake
            // 
            this.colSelfTake.Caption = "部门承担金额(元)";
            this.colSelfTake.FieldName = "SelfTake";
            this.colSelfTake.Name = "colSelfTake";
            this.colSelfTake.Visible = true;
            this.colSelfTake.VisibleIndex = 12;
            // 
            // colYear
            // 
            this.colYear.Caption = "年度";
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 1;
            // 
            // SettlementAmountSummaryGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SettlementAmountSummaryGrid";
            this.Load += new System.EventHandler(this.SettlementAmountSummaryGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colEnergyType;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstQuarter;
        private DevExpress.XtraGrid.Columns.GridColumn colSecondQuarter;
        private DevExpress.XtraGrid.Columns.GridColumn colThirdQuarter;
        private DevExpress.XtraGrid.Columns.GridColumn colFourthQuarter;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSchoolTake;
        private DevExpress.XtraGrid.Columns.GridColumn colSelfTake;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
    }
}
