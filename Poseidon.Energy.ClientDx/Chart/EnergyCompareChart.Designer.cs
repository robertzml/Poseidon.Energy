namespace Poseidon.Energy.ClientDx
{
    partial class EnergyCompareChart
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
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartMain = new DevExpress.XtraCharts.ChartControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPrint = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            this.chartMain.ContextMenuStrip = this.contextMenuStrip1;
            this.chartMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMain.Location = new System.Drawing.Point(0, 0);
            this.chartMain.Name = "chartMain";
            this.chartMain.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartMain.Size = new System.Drawing.Size(842, 531);
            this.chartMain.TabIndex = 0;
            chartTitle1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartMain.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrint});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // menuPrint
            // 
            this.menuPrint.Name = "menuPrint";
            this.menuPrint.Size = new System.Drawing.Size(152, 22);
            this.menuPrint.Text = "打印";
            this.menuPrint.Click += new System.EventHandler(this.menuPrint_Click);
            // 
            // EnergyCompareChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartMain);
            this.Name = "EnergyCompareChart";
            this.Size = new System.Drawing.Size(842, 531);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrint;
    }
}
