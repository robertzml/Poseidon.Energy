namespace Poseidon.Energy.ClientDx
{
    partial class DepartmentTargetModule
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
            this.tabMain = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageYear = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbTargets = new DevExpress.XtraEditors.ListBoxControl();
            this.bsTarget = new System.Windows.Forms.BindingSource();
            this.tabRecords = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageElectric = new DevExpress.XtraTab.XtraTabPage();
            this.recordElectric = new Poseidon.Energy.ClientDx.TargetRecordModule();
            this.tabPageWater = new DevExpress.XtraTab.XtraTabPage();
            this.recordWater = new Poseidon.Energy.ClientDx.TargetRecordModule();
            this.tabPageTrend = new DevExpress.XtraTab.XtraTabPage();
            this.tabTrend = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageElectricTrend = new DevExpress.XtraTab.XtraTabPage();
            this.electricTrendMod = new Poseidon.Energy.ClientDx.TargetTrendModule();
            this.tabPageWaterTrend = new DevExpress.XtraTab.XtraTabPage();
            this.waterTrendMod = new Poseidon.Energy.ClientDx.TargetTrendModule();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPageYear.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTargets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabRecords)).BeginInit();
            this.tabRecords.SuspendLayout();
            this.tabPageElectric.SuspendLayout();
            this.tabPageWater.SuspendLayout();
            this.tabPageTrend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabTrend)).BeginInit();
            this.tabTrend.SuspendLayout();
            this.tabPageElectricTrend.SuspendLayout();
            this.tabPageWaterTrend.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedTabPage = this.tabPageYear;
            this.tabMain.Size = new System.Drawing.Size(748, 577);
            this.tabMain.TabIndex = 0;
            this.tabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageYear,
            this.tabPageTrend});
            // 
            // tabPageYear
            // 
            this.tabPageYear.Controls.Add(this.tableLayoutPanel1);
            this.tabPageYear.Name = "tabPageYear";
            this.tabPageYear.Size = new System.Drawing.Size(742, 548);
            this.tabPageYear.Text = "年度指标计划";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabRecords, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 548);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbTargets);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl1, 2);
            this.groupControl1.Size = new System.Drawing.Size(154, 542);
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
            this.lbTargets.Size = new System.Drawing.Size(150, 519);
            this.lbTargets.TabIndex = 0;
            this.lbTargets.ValueMember = "Id";
            this.lbTargets.SelectedIndexChanged += new System.EventHandler(this.lbTargets_SelectedIndexChanged);
            // 
            // bsTarget
            // 
            this.bsTarget.DataSource = typeof(Poseidon.Energy.Core.DL.Target);
            // 
            // tabRecords
            // 
            this.tabRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRecords.Location = new System.Drawing.Point(163, 3);
            this.tabRecords.Name = "tabRecords";
            this.tableLayoutPanel1.SetRowSpan(this.tabRecords, 2);
            this.tabRecords.SelectedTabPage = this.tabPageElectric;
            this.tabRecords.Size = new System.Drawing.Size(576, 542);
            this.tabRecords.TabIndex = 1;
            this.tabRecords.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageElectric,
            this.tabPageWater});
            // 
            // tabPageElectric
            // 
            this.tabPageElectric.Controls.Add(this.recordElectric);
            this.tabPageElectric.Name = "tabPageElectric";
            this.tabPageElectric.PageVisible = false;
            this.tabPageElectric.Size = new System.Drawing.Size(570, 513);
            this.tabPageElectric.Text = "电指标";
            // 
            // recordElectric
            // 
            this.recordElectric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordElectric.Location = new System.Drawing.Point(0, 0);
            this.recordElectric.Name = "recordElectric";
            this.recordElectric.Size = new System.Drawing.Size(570, 513);
            this.recordElectric.TabIndex = 0;
            // 
            // tabPageWater
            // 
            this.tabPageWater.Controls.Add(this.recordWater);
            this.tabPageWater.Name = "tabPageWater";
            this.tabPageWater.PageVisible = false;
            this.tabPageWater.Size = new System.Drawing.Size(570, 513);
            this.tabPageWater.Text = "水指标";
            // 
            // recordWater
            // 
            this.recordWater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordWater.Location = new System.Drawing.Point(0, 0);
            this.recordWater.Name = "recordWater";
            this.recordWater.Size = new System.Drawing.Size(570, 513);
            this.recordWater.TabIndex = 0;
            // 
            // tabPageTrend
            // 
            this.tabPageTrend.Controls.Add(this.tabTrend);
            this.tabPageTrend.Name = "tabPageTrend";
            this.tabPageTrend.Size = new System.Drawing.Size(742, 548);
            this.tabPageTrend.Text = "指标趋势";
            // 
            // tabTrend
            // 
            this.tabTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTrend.Location = new System.Drawing.Point(0, 0);
            this.tabTrend.Name = "tabTrend";
            this.tabTrend.SelectedTabPage = this.tabPageElectricTrend;
            this.tabTrend.Size = new System.Drawing.Size(742, 548);
            this.tabTrend.TabIndex = 0;
            this.tabTrend.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageElectricTrend,
            this.tabPageWaterTrend});
            // 
            // tabPageElectricTrend
            // 
            this.tabPageElectricTrend.Controls.Add(this.electricTrendMod);
            this.tabPageElectricTrend.Name = "tabPageElectricTrend";
            this.tabPageElectricTrend.Size = new System.Drawing.Size(736, 519);
            this.tabPageElectricTrend.Text = "用电指标";
            // 
            // electricTrendMod
            // 
            this.electricTrendMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.electricTrendMod.Location = new System.Drawing.Point(0, 0);
            this.electricTrendMod.Name = "electricTrendMod";
            this.electricTrendMod.Size = new System.Drawing.Size(736, 519);
            this.electricTrendMod.TabIndex = 0;
            // 
            // tabPageWaterTrend
            // 
            this.tabPageWaterTrend.Controls.Add(this.waterTrendMod);
            this.tabPageWaterTrend.Name = "tabPageWaterTrend";
            this.tabPageWaterTrend.Size = new System.Drawing.Size(736, 519);
            this.tabPageWaterTrend.Text = "用水指标";
            // 
            // waterTrendMod
            // 
            this.waterTrendMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterTrendMod.Location = new System.Drawing.Point(0, 0);
            this.waterTrendMod.Name = "waterTrendMod";
            this.waterTrendMod.Size = new System.Drawing.Size(736, 519);
            this.waterTrendMod.TabIndex = 0;
            // 
            // DepartmentTargetModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabMain);
            this.Name = "DepartmentTargetModule";
            this.Size = new System.Drawing.Size(748, 577);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPageYear.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbTargets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabRecords)).EndInit();
            this.tabRecords.ResumeLayout(false);
            this.tabPageElectric.ResumeLayout(false);
            this.tabPageWater.ResumeLayout(false);
            this.tabPageTrend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabTrend)).EndInit();
            this.tabTrend.ResumeLayout(false);
            this.tabPageElectricTrend.ResumeLayout(false);
            this.tabPageWaterTrend.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabMain;
        private DevExpress.XtraTab.XtraTabPage tabPageYear;
        private DevExpress.XtraTab.XtraTabPage tabPageTrend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl lbTargets;
        private System.Windows.Forms.BindingSource bsTarget;
        private DevExpress.XtraTab.XtraTabControl tabRecords;
        private DevExpress.XtraTab.XtraTabPage tabPageElectric;
        private TargetRecordModule recordElectric;
        private DevExpress.XtraTab.XtraTabPage tabPageWater;
        private TargetRecordModule recordWater;
        private DevExpress.XtraTab.XtraTabControl tabTrend;
        private DevExpress.XtraTab.XtraTabPage tabPageElectricTrend;
        private DevExpress.XtraTab.XtraTabPage tabPageWaterTrend;
        private TargetTrendModule electricTrendMod;
        private TargetTrendModule waterTrendMod;
    }
}
