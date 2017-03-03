namespace Poseidon.Energy.ClientDx
{
    partial class ExpenseAccountTree
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
            this.tlData = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tlData)).BeginInit();
            this.SuspendLayout();
            // 
            // tlData
            // 
            this.tlData.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.colName});
            this.tlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlData.Location = new System.Drawing.Point(0, 0);
            this.tlData.Name = "tlData";
            this.tlData.OptionsBehavior.Editable = false;
            this.tlData.Size = new System.Drawing.Size(186, 269);
            this.tlData.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "colName";
            this.colName.Name = "colName";
            this.colName.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 131;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "colId";
            this.colId.Name = "colId";
            this.colId.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            // 
            // ExpenseAccountTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlData);
            this.Name = "ExpenseAccountTree";
            this.Size = new System.Drawing.Size(186, 269);
            this.Load += new System.EventHandler(this.ExpenseAccountTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlData;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
    }
}
