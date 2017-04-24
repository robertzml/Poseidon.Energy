namespace Poseidon.Energy.ClientDx
{
    partial class SettlementQuantumSummaryGrid
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
            this.colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnergyType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstQuarter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecondQuarter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThirdQuarter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFourthQuarter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Energy.Core.Utility.SettlementQuantumSummary);
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
            this.colPlanQuantum,
            this.colFirstQuarter,
            this.colSecondQuarter,
            this.colThirdQuarter,
            this.colFourthQuarter,
            this.colTotalQuantum,
            this.colRemainQuantum});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsDetail.EnableMasterViewMode = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
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
            // colPlanQuantum
            // 
            this.colPlanQuantum.FieldName = "PlanQuantum";
            this.colPlanQuantum.Name = "colPlanQuantum";
            this.colPlanQuantum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanQuantum", "合计={0:0.##}")});
            this.colPlanQuantum.Visible = true;
            this.colPlanQuantum.VisibleIndex = 3;
            // 
            // colFirstQuarter
            // 
            this.colFirstQuarter.FieldName = "FirstQuarter";
            this.colFirstQuarter.Name = "colFirstQuarter";
            this.colFirstQuarter.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FirstQuarter", "合计={0:0.##}")});
            this.colFirstQuarter.Visible = true;
            this.colFirstQuarter.VisibleIndex = 4;
            // 
            // colSecondQuarter
            // 
            this.colSecondQuarter.FieldName = "SecondQuarter";
            this.colSecondQuarter.Name = "colSecondQuarter";
            this.colSecondQuarter.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SecondQuarter", "合计={0:0.##}")});
            this.colSecondQuarter.Visible = true;
            this.colSecondQuarter.VisibleIndex = 5;
            // 
            // colThirdQuarter
            // 
            this.colThirdQuarter.FieldName = "ThirdQuarter";
            this.colThirdQuarter.Name = "colThirdQuarter";
            this.colThirdQuarter.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThirdQuarter", "合计={0:0.##}")});
            this.colThirdQuarter.Visible = true;
            this.colThirdQuarter.VisibleIndex = 6;
            // 
            // colFourthQuarter
            // 
            this.colFourthQuarter.FieldName = "FourthQuarter";
            this.colFourthQuarter.Name = "colFourthQuarter";
            this.colFourthQuarter.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FourthQuarter", "合计={0:0.##}")});
            this.colFourthQuarter.Visible = true;
            this.colFourthQuarter.VisibleIndex = 7;
            // 
            // colTotalQuantum
            // 
            this.colTotalQuantum.FieldName = "TotalQuantum";
            this.colTotalQuantum.Name = "colTotalQuantum";
            this.colTotalQuantum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQuantum", "合计={0:0.##}")});
            this.colTotalQuantum.Visible = true;
            this.colTotalQuantum.VisibleIndex = 8;
            // 
            // colRemainQuantum
            // 
            this.colRemainQuantum.FieldName = "RemainQuantum";
            this.colRemainQuantum.Name = "colRemainQuantum";
            this.colRemainQuantum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RemainQuantum", "合计={0:0.##}")});
            this.colRemainQuantum.Visible = true;
            this.colRemainQuantum.VisibleIndex = 9;
            // 
            // colYear
            // 
            this.colYear.Caption = "年度";
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 1;
            // 
            // SettlementQuantumSummaryGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SettlementQuantumSummaryGrid";
            this.Load += new System.EventHandler(this.SettlementQuantumSummaryGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colEnergyType;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstQuarter;
        private DevExpress.XtraGrid.Columns.GridColumn colSecondQuarter;
        private DevExpress.XtraGrid.Columns.GridColumn colThirdQuarter;
        private DevExpress.XtraGrid.Columns.GridColumn colFourthQuarter;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
    }
}
