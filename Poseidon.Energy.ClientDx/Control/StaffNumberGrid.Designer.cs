namespace Poseidon.Energy.ClientDx
{
    partial class StaffNumberGrid
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
            this.colEstablishment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonnelAgency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInlandShort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLaborDispatch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForeignShort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForeignLong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUndergraduate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaster = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfessionalMaster = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbroadStudent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Energy.Core.DL.StaffNumber);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(710, 427);
            // 
            // dgvEntity
            // 
            this.dgvEntity.ActiveFilterEnabled = false;
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDepartmentId,
            this.colEstablishment,
            this.colPersonnelAgency,
            this.colPostDoctor,
            this.colInlandShort,
            this.colLaborDispatch,
            this.colForeignShort,
            this.colForeignLong,
            this.colUndergraduate,
            this.colMaster,
            this.colProfessionalMaster,
            this.colDoctor,
            this.colAbroadStudent,
            this.colRemark,
            this.colStatus});
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsFilter.AllowFilterEditor = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowFooter = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.Caption = "部门名称";
            this.colDepartmentId.FieldName = "DepartmentId";
            this.colDepartmentId.Name = "colDepartmentId";
            this.colDepartmentId.Visible = true;
            this.colDepartmentId.VisibleIndex = 0;
            // 
            // colEstablishment
            // 
            this.colEstablishment.Caption = "在职在编";
            this.colEstablishment.FieldName = "Establishment";
            this.colEstablishment.Name = "colEstablishment";
            this.colEstablishment.Visible = true;
            this.colEstablishment.VisibleIndex = 1;
            // 
            // colPersonnelAgency
            // 
            this.colPersonnelAgency.Caption = "人事代理";
            this.colPersonnelAgency.FieldName = "PersonnelAgency";
            this.colPersonnelAgency.Name = "colPersonnelAgency";
            this.colPersonnelAgency.Visible = true;
            this.colPersonnelAgency.VisibleIndex = 2;
            // 
            // colPostDoctor
            // 
            this.colPostDoctor.Caption = "博士后";
            this.colPostDoctor.FieldName = "PostDoctor";
            this.colPostDoctor.Name = "colPostDoctor";
            this.colPostDoctor.Visible = true;
            this.colPostDoctor.VisibleIndex = 3;
            // 
            // colInlandShort
            // 
            this.colInlandShort.Caption = "国内短期聘用";
            this.colInlandShort.FieldName = "InlandShort";
            this.colInlandShort.Name = "colInlandShort";
            this.colInlandShort.Visible = true;
            this.colInlandShort.VisibleIndex = 4;
            // 
            // colLaborDispatch
            // 
            this.colLaborDispatch.FieldName = "LaborDispatch";
            this.colLaborDispatch.Name = "colLaborDispatch";
            this.colLaborDispatch.Visible = true;
            this.colLaborDispatch.VisibleIndex = 5;
            // 
            // colForeignShort
            // 
            this.colForeignShort.FieldName = "ForeignShort";
            this.colForeignShort.Name = "colForeignShort";
            this.colForeignShort.Visible = true;
            this.colForeignShort.VisibleIndex = 6;
            // 
            // colForeignLong
            // 
            this.colForeignLong.FieldName = "ForeignLong";
            this.colForeignLong.Name = "colForeignLong";
            this.colForeignLong.Visible = true;
            this.colForeignLong.VisibleIndex = 7;
            // 
            // colUndergraduate
            // 
            this.colUndergraduate.FieldName = "Undergraduate";
            this.colUndergraduate.Name = "colUndergraduate";
            this.colUndergraduate.Visible = true;
            this.colUndergraduate.VisibleIndex = 8;
            // 
            // colMaster
            // 
            this.colMaster.FieldName = "Master";
            this.colMaster.Name = "colMaster";
            this.colMaster.Visible = true;
            this.colMaster.VisibleIndex = 9;
            // 
            // colProfessionalMaster
            // 
            this.colProfessionalMaster.FieldName = "ProfessionalMaster";
            this.colProfessionalMaster.Name = "colProfessionalMaster";
            this.colProfessionalMaster.Visible = true;
            this.colProfessionalMaster.VisibleIndex = 10;
            // 
            // colDoctor
            // 
            this.colDoctor.FieldName = "Doctor";
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.Visible = true;
            this.colDoctor.VisibleIndex = 11;
            // 
            // colAbroadStudent
            // 
            this.colAbroadStudent.FieldName = "AbroadStudent";
            this.colAbroadStudent.Name = "colAbroadStudent";
            this.colAbroadStudent.Visible = true;
            this.colAbroadStudent.VisibleIndex = 12;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 13;
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
            // 
            // StaffNumberGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "StaffNumberGrid";
            this.ShowFooter = true;
            this.Size = new System.Drawing.Size(710, 427);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colEstablishment;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonnelAgency;
        private DevExpress.XtraGrid.Columns.GridColumn colPostDoctor;
        private DevExpress.XtraGrid.Columns.GridColumn colInlandShort;
        private DevExpress.XtraGrid.Columns.GridColumn colLaborDispatch;
        private DevExpress.XtraGrid.Columns.GridColumn colForeignShort;
        private DevExpress.XtraGrid.Columns.GridColumn colForeignLong;
        private DevExpress.XtraGrid.Columns.GridColumn colUndergraduate;
        private DevExpress.XtraGrid.Columns.GridColumn colMaster;
        private DevExpress.XtraGrid.Columns.GridColumn colProfessionalMaster;
        private DevExpress.XtraGrid.Columns.GridColumn colDoctor;
        private DevExpress.XtraGrid.Columns.GridColumn colAbroadStudent;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}
