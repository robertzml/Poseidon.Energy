namespace Poseidon.Energy.ClientDx
{
    partial class DepartmentSettlementSummaryGrid
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
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSettleQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSettleAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSchoolTake = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelfTake = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Energy.Core.Utility.DepartmentSettlementSummary);
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
            this.colPlanQuantum,
            this.colSettleQuantum,
            this.colRemainQuantum,
            this.colPlanAmount,
            this.colSettleAmount,
            this.colRemainAmount,
            this.colSchoolTake,
            this.colSelfTake});
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
            // colYear
            // 
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 1;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 3;
            // 
            // colPlanQuantum
            // 
            this.colPlanQuantum.FieldName = "PlanQuantum";
            this.colPlanQuantum.Name = "colPlanQuantum";
            this.colPlanQuantum.Visible = true;
            this.colPlanQuantum.VisibleIndex = 4;
            // 
            // colSettleQuantum
            // 
            this.colSettleQuantum.FieldName = "SettleQuantum";
            this.colSettleQuantum.Name = "colSettleQuantum";
            this.colSettleQuantum.Visible = true;
            this.colSettleQuantum.VisibleIndex = 5;
            // 
            // colRemainQuantum
            // 
            this.colRemainQuantum.FieldName = "RemainQuantum";
            this.colRemainQuantum.Name = "colRemainQuantum";
            this.colRemainQuantum.Visible = true;
            this.colRemainQuantum.VisibleIndex = 6;
            // 
            // colPlanAmount
            // 
            this.colPlanAmount.Caption = "计划金额(元)";
            this.colPlanAmount.FieldName = "PlanAmount";
            this.colPlanAmount.Name = "colPlanAmount";
            this.colPlanAmount.Visible = true;
            this.colPlanAmount.VisibleIndex = 7;
            // 
            // colSettleAmount
            // 
            this.colSettleAmount.Caption = "结算金额(元)";
            this.colSettleAmount.FieldName = "SettleAmount";
            this.colSettleAmount.Name = "colSettleAmount";
            this.colSettleAmount.Visible = true;
            this.colSettleAmount.VisibleIndex = 8;
            // 
            // colRemainAmount
            // 
            this.colRemainAmount.Caption = "剩余金额(元)";
            this.colRemainAmount.FieldName = "RemainAmount";
            this.colRemainAmount.Name = "colRemainAmount";
            this.colRemainAmount.Visible = true;
            this.colRemainAmount.VisibleIndex = 9;
            // 
            // colSchoolTake
            // 
            this.colSchoolTake.Caption = "学校承担金额(元)";
            this.colSchoolTake.FieldName = "SchoolTake";
            this.colSchoolTake.Name = "colSchoolTake";
            this.colSchoolTake.Visible = true;
            this.colSchoolTake.VisibleIndex = 10;
            // 
            // colSelfTake
            // 
            this.colSelfTake.Caption = "部门承担金额(元)";
            this.colSelfTake.FieldName = "SelfTake";
            this.colSelfTake.Name = "colSelfTake";
            this.colSelfTake.Visible = true;
            this.colSelfTake.VisibleIndex = 11;
            // 
            // DepartmentSettlementSummaryGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DepartmentSettlementSummaryGrid";
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colEnergyType;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colSettleQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSettleAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSchoolTake;
        private DevExpress.XtraGrid.Columns.GridColumn colSelfTake;
    }
}
