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
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthKilowatt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearKilowatt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearAmount = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colName,
            this.colCount,
            this.colMonthKilowatt,
            this.colMonthCount,
            this.colYearKilowatt,
            this.colYearAmount});
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colCount
            // 
            this.colCount.Caption = "人数";
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 1;
            // 
            // colMonthKilowatt
            // 
            this.colMonthKilowatt.Caption = "月度数";
            this.colMonthKilowatt.FieldName = "MonthKilowatt";
            this.colMonthKilowatt.Name = "colMonthKilowatt";
            this.colMonthKilowatt.Visible = true;
            this.colMonthKilowatt.VisibleIndex = 2;
            // 
            // colMonthCount
            // 
            this.colMonthCount.Caption = "月数";
            this.colMonthCount.FieldName = "MonthCount";
            this.colMonthCount.Name = "colMonthCount";
            this.colMonthCount.Visible = true;
            this.colMonthCount.VisibleIndex = 3;
            // 
            // colYearKilowatt
            // 
            this.colYearKilowatt.Caption = "年指标度数";
            this.colYearKilowatt.FieldName = "YearKilowatt";
            this.colYearKilowatt.Name = "colYearKilowatt";
            this.colYearKilowatt.Visible = true;
            this.colYearKilowatt.VisibleIndex = 4;
            // 
            // colYearAmount
            // 
            this.colYearAmount.Caption = "年指标金额(元)";
            this.colYearAmount.FieldName = "YearAmount";
            this.colYearAmount.Name = "colYearAmount";
            this.colYearAmount.Visible = true;
            this.colYearAmount.VisibleIndex = 5;
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

        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthKilowatt;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthCount;
        private DevExpress.XtraGrid.Columns.GridColumn colYearKilowatt;
        private DevExpress.XtraGrid.Columns.GridColumn colYearAmount;
    }
}
