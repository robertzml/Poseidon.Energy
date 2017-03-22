namespace Poseidon.Energy.ClientDx
{
    partial class GroupTargetModule
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
            this.components = new System.ComponentModel.Container();
            this.tabMain = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageTarget = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbTargets = new DevExpress.XtraEditors.ListBoxControl();
            this.bsTarget = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.recordGrid = new Poseidon.Energy.ClientDx.TargetRecordGrid();
            this.tabPageTrend = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPageTarget.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTargets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedTabPage = this.tabPageTarget;
            this.tabMain.Size = new System.Drawing.Size(820, 510);
            this.tabMain.TabIndex = 0;
            this.tabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageTarget,
            this.tabPageTrend});
            // 
            // tabPageTarget
            // 
            this.tabPageTarget.Controls.Add(this.tableLayoutPanel1);
            this.tabPageTarget.Name = "tabPageTarget";
            this.tabPageTarget.Size = new System.Drawing.Size(814, 481);
            this.tabPageTarget.Text = "指标计划";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 481);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbTargets);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl1, 2);
            this.groupControl1.Size = new System.Drawing.Size(154, 475);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "指标计划列表";
            // 
            // lbTargets
            // 
            this.lbTargets.DataSource = this.bsTarget;
            this.lbTargets.DisplayMember = "Name";
            this.lbTargets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTargets.Location = new System.Drawing.Point(2, 21);
            this.lbTargets.Name = "lbTargets";
            this.lbTargets.Size = new System.Drawing.Size(150, 452);
            this.lbTargets.TabIndex = 0;
            this.lbTargets.ValueMember = "Id";
            this.lbTargets.SelectedIndexChanged += new System.EventHandler(this.lbTargets_SelectedIndexChanged);
            // 
            // bsTarget
            // 
            this.bsTarget.DataSource = typeof(Poseidon.Energy.Core.DL.Target);
            // 
            // groupControl2
            // 
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(163, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(648, 194);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.recordGrid);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(163, 203);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(648, 275);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "指标记录";
            // 
            // recordGrid
            // 
            this.recordGrid.AllowFilter = true;
            this.recordGrid.AllowGroup = false;
            this.recordGrid.AllowSort = true;
            this.recordGrid.DataSource = null;
            this.recordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordGrid.Editable = false;
            this.recordGrid.EnableMasterView = false;
            this.recordGrid.Location = new System.Drawing.Point(2, 21);
            this.recordGrid.Name = "recordGrid";
            this.recordGrid.ShowAddMenu = false;
            this.recordGrid.ShowFooter = false;
            this.recordGrid.ShowLineNumber = true;
            this.recordGrid.ShowNavigator = false;
            this.recordGrid.Size = new System.Drawing.Size(644, 252);
            this.recordGrid.TabIndex = 0;
            // 
            // tabPageTrend
            // 
            this.tabPageTrend.Name = "tabPageTrend";
            this.tabPageTrend.Size = new System.Drawing.Size(814, 481);
            this.tabPageTrend.Text = "指标趋势";
            // 
            // GroupTargetModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabMain);
            this.Name = "GroupTargetModule";
            this.Size = new System.Drawing.Size(820, 510);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPageTarget.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbTargets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabMain;
        private DevExpress.XtraTab.XtraTabPage tabPageTarget;
        private DevExpress.XtraTab.XtraTabPage tabPageTrend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl lbTargets;
        private System.Windows.Forms.BindingSource bsTarget;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private TargetRecordGrid recordGrid;
    }
}
