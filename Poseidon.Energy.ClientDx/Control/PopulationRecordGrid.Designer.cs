namespace Poseidon.Energy.ClientDx
{
    partial class PopulationRecordGrid
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
            this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUndergraduate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstablishment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonnelAgency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfessionalMaster = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaster = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbroadStudent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumTeacher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumStudent = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Energy.Core.DL.PopulationRecord);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(847, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDepartmentId,
            this.colEstablishment,
            this.colPersonnelAgency,
            this.colSumTeacher,
            this.colUndergraduate,
            this.colMaster,
            this.colProfessionalMaster,
            this.colDoctor,
            this.colAbroadStudent,
            this.colSumStudent,
            this.colRemark,
            this.colStatus});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsCustomization.AllowFilter = false;
            this.dgvEntity.OptionsCustomization.AllowGroup = false;
            this.dgvEntity.OptionsDetail.EnableMasterViewMode = false;
            this.dgvEntity.OptionsMenu.EnableGroupPanelMenu = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowFooter = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            this.dgvEntity.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.dgvEntity_CustomUnboundColumnData);
            this.dgvEntity.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.dgvEntity_CustomColumnDisplayText);
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.Caption = "部门名称";
            this.colDepartmentId.FieldName = "DepartmentId";
            this.colDepartmentId.Name = "colDepartmentId";
            this.colDepartmentId.OptionsColumn.AllowEdit = false;
            this.colDepartmentId.Visible = true;
            this.colDepartmentId.VisibleIndex = 0;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 10;
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
            // colUndergraduate
            // 
            this.colUndergraduate.Caption = "本科生";
            this.colUndergraduate.FieldName = "colUndergraduate";
            this.colUndergraduate.Name = "colUndergraduate";
            this.colUndergraduate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colUndergraduate", "合计={0:0.##}")});
            this.colUndergraduate.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colUndergraduate.Visible = true;
            this.colUndergraduate.VisibleIndex = 4;
            // 
            // colEstablishment
            // 
            this.colEstablishment.Caption = "在职在编";
            this.colEstablishment.FieldName = "colEstablishment";
            this.colEstablishment.Name = "colEstablishment";
            this.colEstablishment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colEstablishment", "合计={0:0.##}")});
            this.colEstablishment.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colEstablishment.Visible = true;
            this.colEstablishment.VisibleIndex = 1;
            // 
            // colPersonnelAgency
            // 
            this.colPersonnelAgency.Caption = "人事代理";
            this.colPersonnelAgency.FieldName = "colPersonnelAgency";
            this.colPersonnelAgency.Name = "colPersonnelAgency";
            this.colPersonnelAgency.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colPersonnelAgency", "合计={0:0.##}")});
            this.colPersonnelAgency.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colPersonnelAgency.Visible = true;
            this.colPersonnelAgency.VisibleIndex = 2;
            // 
            // colDoctor
            // 
            this.colDoctor.Caption = "博士生";
            this.colDoctor.FieldName = "colDoctor";
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colDoctor", "合计={0:0.##}")});
            this.colDoctor.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colDoctor.Visible = true;
            this.colDoctor.VisibleIndex = 7;
            // 
            // colProfessionalMaster
            // 
            this.colProfessionalMaster.Caption = "专业硕士生";
            this.colProfessionalMaster.FieldName = "colProfessionalMaster";
            this.colProfessionalMaster.Name = "colProfessionalMaster";
            this.colProfessionalMaster.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colProfessionalMaster", "合计={0:0.##}")});
            this.colProfessionalMaster.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colProfessionalMaster.Visible = true;
            this.colProfessionalMaster.VisibleIndex = 6;
            // 
            // colMaster
            // 
            this.colMaster.Caption = "硕士生";
            this.colMaster.FieldName = "colMaster";
            this.colMaster.Name = "colMaster";
            this.colMaster.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colMaster", "合计={0:0.##}")});
            this.colMaster.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colMaster.Visible = true;
            this.colMaster.VisibleIndex = 5;
            // 
            // colAbroadStudent
            // 
            this.colAbroadStudent.Caption = "留学生";
            this.colAbroadStudent.FieldName = "colAbroadStudent";
            this.colAbroadStudent.Name = "colAbroadStudent";
            this.colAbroadStudent.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colAbroadStudent.Visible = true;
            this.colAbroadStudent.VisibleIndex = 8;
            // 
            // colSumTeacher
            // 
            this.colSumTeacher.Caption = "教工合计";
            this.colSumTeacher.FieldName = "colSumTeacher";
            this.colSumTeacher.Name = "colSumTeacher";
            this.colSumTeacher.OptionsColumn.AllowEdit = false;
            this.colSumTeacher.UnboundExpression = "[colEstablishment] + [colPersonnelAgency]";
            this.colSumTeacher.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colSumTeacher.Visible = true;
            this.colSumTeacher.VisibleIndex = 3;
            // 
            // colSumStudent
            // 
            this.colSumStudent.Caption = "学生合计";
            this.colSumStudent.FieldName = "colSumStudent";
            this.colSumStudent.Name = "colSumStudent";
            this.colSumStudent.OptionsColumn.AllowEdit = false;
            this.colSumStudent.UnboundExpression = "[colUndergraduate] + [colMaster] + [colProfessionalMaster] + [colDoctor] + [colAb" +
    "roadStudent]";
            this.colSumStudent.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colSumStudent.Visible = true;
            this.colSumStudent.VisibleIndex = 9;
            // 
            // PopulationRecordGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PopulationRecordGrid";
            this.ShowFooter = true;
            this.Size = new System.Drawing.Size(847, 378);
            this.Load += new System.EventHandler(this.PopulationRecordGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonnelAgency;
        private DevExpress.XtraGrid.Columns.GridColumn colEstablishment;
        private DevExpress.XtraGrid.Columns.GridColumn colUndergraduate;
        private DevExpress.XtraGrid.Columns.GridColumn colMaster;
        private DevExpress.XtraGrid.Columns.GridColumn colProfessionalMaster;
        private DevExpress.XtraGrid.Columns.GridColumn colDoctor;
        private DevExpress.XtraGrid.Columns.GridColumn colAbroadStudent;
        private DevExpress.XtraGrid.Columns.GridColumn colSumTeacher;
        private DevExpress.XtraGrid.Columns.GridColumn colSumStudent;
    }
}
