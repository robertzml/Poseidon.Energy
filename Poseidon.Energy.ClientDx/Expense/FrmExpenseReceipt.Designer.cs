namespace Poseidon.Energy.ClientDx
{
    partial class FrmExpenseReceipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.accountTree = new Poseidon.Energy.ClientDx.ExpenseAccountTree();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageInfo = new DevExpress.XtraTab.XtraTabPage();
            this.ctrAccountInfo = new Poseidon.Energy.ClientDx.ExpenseAccountInfo();
            this.tabPageElectric = new DevExpress.XtraTab.XtraTabPage();
            this.electricReceipt = new Poseidon.Energy.ClientDx.ElectricExpenseReceipt();
            this.tabPageWater = new DevExpress.XtraTab.XtraTabPage();
            this.waterReceipt = new Poseidon.Energy.ClientDx.WaterExpenseReceipt();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.tabPageElectric.SuspendLayout();
            this.tabPageWater.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 539);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.accountTree);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(194, 533);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "支出账户";
            // 
            // accountTree
            // 
            this.accountTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountTree.Location = new System.Drawing.Point(2, 21);
            this.accountTree.Name = "accountTree";
            this.accountTree.Size = new System.Drawing.Size(190, 510);
            this.accountTree.TabIndex = 0;
            this.accountTree.AccountSelected += new System.EventHandler(this.accountTree_AccountSelected);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tabControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(203, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(703, 533);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "单据管理";
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(2, 21);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.tabPageInfo;
            this.tabControl.Size = new System.Drawing.Size(699, 510);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageInfo,
            this.tabPageElectric,
            this.tabPageWater});
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.ctrAccountInfo);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Size = new System.Drawing.Size(693, 481);
            this.tabPageInfo.Text = "基本信息";
            // 
            // ctrAccountInfo
            // 
            this.ctrAccountInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrAccountInfo.Location = new System.Drawing.Point(0, 0);
            this.ctrAccountInfo.Name = "ctrAccountInfo";
            this.ctrAccountInfo.Size = new System.Drawing.Size(693, 190);
            this.ctrAccountInfo.TabIndex = 0;
            // 
            // tabPageElectric
            // 
            this.tabPageElectric.Controls.Add(this.electricReceipt);
            this.tabPageElectric.Name = "tabPageElectric";
            this.tabPageElectric.PageVisible = false;
            this.tabPageElectric.Size = new System.Drawing.Size(693, 481);
            this.tabPageElectric.Text = "电费单据";
            // 
            // electricReceipt
            // 
            this.electricReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.electricReceipt.Editable = true;
            this.electricReceipt.Location = new System.Drawing.Point(0, 0);
            this.electricReceipt.Name = "electricReceipt";
            this.electricReceipt.Size = new System.Drawing.Size(693, 481);
            this.electricReceipt.TabIndex = 0;
            // 
            // tabPageWater
            // 
            this.tabPageWater.Controls.Add(this.waterReceipt);
            this.tabPageWater.Name = "tabPageWater";
            this.tabPageWater.PageVisible = false;
            this.tabPageWater.Size = new System.Drawing.Size(693, 481);
            this.tabPageWater.Text = "水费单据";
            // 
            // waterReceipt
            // 
            this.waterReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterReceipt.Editable = true;
            this.waterReceipt.Location = new System.Drawing.Point(0, 0);
            this.waterReceipt.Name = "waterReceipt";
            this.waterReceipt.Size = new System.Drawing.Size(693, 481);
            this.waterReceipt.TabIndex = 0;
            // 
            // FrmExpenseReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 539);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmExpenseReceipt";
            this.Text = "支出单据";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageElectric.ResumeLayout(false);
            this.tabPageWater.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private ExpenseAccountTree accountTree;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabPage tabPageInfo;
        private DevExpress.XtraTab.XtraTabPage tabPageElectric;
        private DevExpress.XtraTab.XtraTabPage tabPageWater;
        private WaterExpenseReceipt waterReceipt;
        private ExpenseAccountInfo ctrAccountInfo;
        private ElectricExpenseReceipt electricReceipt;
    }
}