namespace Poseidon.Energy.ClientDx
{
    partial class ElectricMeterGrid
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
            this.colSectionNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMultiple = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Energy.Core.DL.ElectricMeter);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(568, 354);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colSectionNumber,
            this.colNumber,
            this.colAccountName,
            this.colAddress,
            this.colMultiple,
            this.colRemark,
            this.colStatus});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            // 
            // colSectionNumber
            // 
            this.colSectionNumber.Caption = "段户号";
            this.colSectionNumber.FieldName = "SectionNumber";
            this.colSectionNumber.Name = "colSectionNumber";
            this.colSectionNumber.Visible = true;
            this.colSectionNumber.VisibleIndex = 1;
            // 
            // colNumber
            // 
            this.colNumber.Caption = "总户号";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 2;
            // 
            // colAccountName
            // 
            this.colAccountName.Caption = "户名";
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Visible = true;
            this.colAccountName.VisibleIndex = 3;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "地址";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            // 
            // colMultiple
            // 
            this.colMultiple.Caption = "倍率";
            this.colMultiple.FieldName = "Multiple";
            this.colMultiple.Name = "colMultiple";
            this.colMultiple.Visible = true;
            this.colMultiple.VisibleIndex = 5;
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 6;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "状态";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 7;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.DataSource = this.bsEntity;
            this.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataNavigator1.Location = new System.Drawing.Point(0, 354);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(568, 24);
            this.dataNavigator1.TabIndex = 1;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dataNavigator1.TextStringFormat = "记录 {0} of {1}";
            // 
            // ElectricMeterGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataNavigator1);
            this.Name = "ElectricMeterGrid";
            this.Load += new System.EventHandler(this.ElectricMeterGrid_Load);
            this.Controls.SetChildIndex(this.dataNavigator1, 0);
            this.Controls.SetChildIndex(this.dgcEntity, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colSectionNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colMultiple;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
    }
}
