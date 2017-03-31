namespace Poseidon.Energy.ClientDx
{
    partial class SettlementRecordGrid
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
            this.colSettlementId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnergyType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeginQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeginAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSchoolTakeAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelfTakeAmount = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.bsEntity.DataSource = typeof(Poseidon.Energy.Core.DL.SettlementRecord);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSettlementId,
            this.colDepartmentId,
            this.colEnergyType,
            this.colUnitPrice,
            this.colBeginQuantum,
            this.colBeginAmount,
            this.colQuantum,
            this.colAmount,
            this.colSchoolTakeAmount,
            this.colSelfTakeAmount,
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
            // colSettlementId
            // 
            this.colSettlementId.FieldName = "SettlementId";
            this.colSettlementId.Name = "colSettlementId";
            this.colSettlementId.OptionsColumn.AllowEdit = false;
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.FieldName = "DepartmentId";
            this.colDepartmentId.Name = "colDepartmentId";
            this.colDepartmentId.OptionsColumn.AllowEdit = false;
            this.colDepartmentId.Visible = true;
            this.colDepartmentId.VisibleIndex = 0;
            // 
            // colEnergyType
            // 
            this.colEnergyType.FieldName = "EnergyType";
            this.colEnergyType.Name = "colEnergyType";
            this.colEnergyType.Visible = true;
            this.colEnergyType.VisibleIndex = 1;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 2;
            // 
            // colBeginQuantum
            // 
            this.colBeginQuantum.FieldName = "BeginQuantum";
            this.colBeginQuantum.Name = "colBeginQuantum";
            this.colBeginQuantum.Visible = true;
            this.colBeginQuantum.VisibleIndex = 3;
            // 
            // colBeginAmount
            // 
            this.colBeginAmount.FieldName = "BeginAmount";
            this.colBeginAmount.Name = "colBeginAmount";
            this.colBeginAmount.Visible = true;
            this.colBeginAmount.VisibleIndex = 4;
            // 
            // colQuantum
            // 
            this.colQuantum.FieldName = "Quantum";
            this.colQuantum.Name = "colQuantum";
            this.colQuantum.Visible = true;
            this.colQuantum.VisibleIndex = 5;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 6;
            // 
            // colSchoolTakeAmount
            // 
            this.colSchoolTakeAmount.FieldName = "SchoolTakeAmount";
            this.colSchoolTakeAmount.Name = "colSchoolTakeAmount";
            this.colSchoolTakeAmount.Visible = true;
            this.colSchoolTakeAmount.VisibleIndex = 7;
            // 
            // colSelfTakeAmount
            // 
            this.colSelfTakeAmount.FieldName = "SelfTakeAmount";
            this.colSelfTakeAmount.Name = "colSelfTakeAmount";
            this.colSelfTakeAmount.Visible = true;
            this.colSelfTakeAmount.VisibleIndex = 8;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 9;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 10;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // SettlementRecordGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SettlementRecordGrid";
            this.Load += new System.EventHandler(this.SettlementRecordGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colSettlementId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colEnergyType;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colBeginQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colBeginAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSchoolTakeAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSelfTakeAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}
