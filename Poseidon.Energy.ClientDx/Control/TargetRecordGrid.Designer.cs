namespace Poseidon.Energy.ClientDx
{
    partial class TargetRecordGrid
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
            this.colTargetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCmbType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colFinance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSchoolTake = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelfTake = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCmbType)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Energy.Core.DL.TargetRecord);
            // 
            // dgcEntity
            // 
            this.dgcEntity.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCmbType});
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTargetId,
            this.colDepartmentId,
            this.colType,
            this.colFinance,
            this.colSchoolTake,
            this.colSelfTake,
            this.colPlanQuantum,
            this.colPlanAmount,
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
            this.dgvEntity.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.dgvEntity_CustomColumnDisplayText);
            // 
            // colTargetId
            // 
            this.colTargetId.FieldName = "TargetId";
            this.colTargetId.Name = "colTargetId";
            this.colTargetId.OptionsColumn.AllowEdit = false;
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.Caption = "部门名称";
            this.colDepartmentId.FieldName = "DepartmentId";
            this.colDepartmentId.Name = "colDepartmentId";
            this.colDepartmentId.Visible = true;
            this.colDepartmentId.VisibleIndex = 0;
            // 
            // colType
            // 
            this.colType.ColumnEdit = this.repoCmbType;
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 1;
            // 
            // repoCmbType
            // 
            this.repoCmbType.AutoHeight = false;
            this.repoCmbType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoCmbType.Name = "repoCmbType";
            // 
            // colFinance
            // 
            this.colFinance.FieldName = "Finance";
            this.colFinance.Name = "colFinance";
            this.colFinance.Visible = true;
            this.colFinance.VisibleIndex = 2;
            // 
            // colSchoolTake
            // 
            this.colSchoolTake.DisplayFormat.FormatString = "p0";
            this.colSchoolTake.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSchoolTake.FieldName = "SchoolTake";
            this.colSchoolTake.Name = "colSchoolTake";
            this.colSchoolTake.Visible = true;
            this.colSchoolTake.VisibleIndex = 3;
            // 
            // colSelfTake
            // 
            this.colSelfTake.DisplayFormat.FormatString = "p0";
            this.colSelfTake.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSelfTake.FieldName = "SelfTake";
            this.colSelfTake.Name = "colSelfTake";
            this.colSelfTake.Visible = true;
            this.colSelfTake.VisibleIndex = 4;
            // 
            // colPlanQuantum
            // 
            this.colPlanQuantum.FieldName = "PlanQuantum";
            this.colPlanQuantum.Name = "colPlanQuantum";
            this.colPlanQuantum.Visible = true;
            this.colPlanQuantum.VisibleIndex = 5;
            // 
            // colPlanAmount
            // 
            this.colPlanAmount.FieldName = "PlanAmount";
            this.colPlanAmount.Name = "colPlanAmount";
            this.colPlanAmount.Visible = true;
            this.colPlanAmount.VisibleIndex = 6;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 7;
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
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // TargetRecordGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TargetRecordGrid";
            this.ExportToExcelCustomCell += new System.Action<DevExpress.Export.CustomizeCellEventArgs>(this.TargetRecordGrid_ExportToExcelCustomCell);
            this.Load += new System.EventHandler(this.TargetRecordGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCmbType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colFinance;
        private DevExpress.XtraGrid.Columns.GridColumn colSchoolTake;
        private DevExpress.XtraGrid.Columns.GridColumn colSelfTake;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoCmbType;
    }
}
