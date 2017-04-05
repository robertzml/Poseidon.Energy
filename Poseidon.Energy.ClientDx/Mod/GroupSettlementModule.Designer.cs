namespace Poseidon.Energy.ClientDx
{
    partial class GroupSettlementModule
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
            this.tabSettlement = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageSummary = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageRecord = new DevExpress.XtraTab.XtraTabPage();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.settlementQuantumSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabSettlement)).BeginInit();
            this.tabSettlement.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementQuantumSummaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSettlement
            // 
            this.tabSettlement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettlement.Location = new System.Drawing.Point(0, 0);
            this.tabSettlement.Name = "tabSettlement";
            this.tabSettlement.SelectedTabPage = this.tabPageSummary;
            this.tabSettlement.Size = new System.Drawing.Size(667, 423);
            this.tabSettlement.TabIndex = 0;
            this.tabSettlement.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageSummary,
            this.tabPageRecord});
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Controls.Add(this.lookUpEdit1);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Size = new System.Drawing.Size(661, 394);
            this.tabPageSummary.Text = "能源结算汇总";
            // 
            // tabPageRecord
            // 
            this.tabPageRecord.Name = "tabPageRecord";
            this.tabPageRecord.Size = new System.Drawing.Size(661, 394);
            this.tabPageRecord.Text = "能源结算记录";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(176, 124);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DataSource = this.settlementQuantumSummaryBindingSource;
            this.lookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.lookUpEdit1.TabIndex = 0;
            // 
            // settlementQuantumSummaryBindingSource
            // 
            this.settlementQuantumSummaryBindingSource.DataSource = typeof(Poseidon.Energy.Core.Utility.SettlementQuantumSummary);
            // 
            // GroupSettlementModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabSettlement);
            this.Name = "GroupSettlementModule";
            this.Size = new System.Drawing.Size(667, 423);
            ((System.ComponentModel.ISupportInitialize)(this.tabSettlement)).EndInit();
            this.tabSettlement.ResumeLayout(false);
            this.tabPageSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementQuantumSummaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabSettlement;
        private DevExpress.XtraTab.XtraTabPage tabPageSummary;
        private DevExpress.XtraTab.XtraTabPage tabPageRecord;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.BindingSource settlementQuantumSummaryBindingSource;
    }
}
