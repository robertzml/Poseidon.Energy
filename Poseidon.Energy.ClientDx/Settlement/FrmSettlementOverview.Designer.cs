namespace Poseidon.Energy.ClientDx
{
    partial class FrmSettlementOverview
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.settlementTree = new Poseidon.Winform.Core.GroupChildrenTree();
            this.navFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navPageGroup = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupSettlementMod = new Poseidon.Energy.ClientDx.GroupSettlementModule();
            this.depSettlementMod = new Poseidon.Energy.ClientDx.DepartmentSettlementModule();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.navFrame.SuspendLayout();
            this.navPageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.navFrame);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(876, 542);
            this.splitContainerControl1.SplitterPosition = 179;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.settlementTree);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(179, 542);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "部门列表";
            // 
            // settlementTree
            // 
            this.settlementTree.CascadeOrganization = false;
            this.settlementTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settlementTree.Location = new System.Drawing.Point(2, 21);
            this.settlementTree.Name = "settlementTree";
            this.settlementTree.ShowFindPanel = false;
            this.settlementTree.Size = new System.Drawing.Size(175, 519);
            this.settlementTree.TabIndex = 0;
            this.settlementTree.GroupSelected += new System.EventHandler(this.settlementTree_GroupSelected);
            this.settlementTree.OrganizationSelected += new System.EventHandler(this.settlementTree_OrganizationSelected);
            // 
            // navFrame
            // 
            this.navFrame.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.navFrame.Controls.Add(this.navPageGroup);
            this.navFrame.Controls.Add(this.navigationPage2);
            this.navFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navFrame.Location = new System.Drawing.Point(0, 0);
            this.navFrame.Name = "navFrame";
            this.navFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPage[] {
            this.navPageGroup,
            this.navigationPage2});
            this.navFrame.SelectedPage = this.navigationPage2;
            this.navFrame.SelectedPageIndex = 1;
            this.navFrame.Size = new System.Drawing.Size(692, 542);
            this.navFrame.TabIndex = 0;
            this.navFrame.Text = "navigationFrame1";
            // 
            // navPageGroup
            // 
            this.navPageGroup.Caption = "navPageGroup";
            this.navPageGroup.Controls.Add(this.groupControl2);
            this.navPageGroup.Name = "navPageGroup";
            this.navPageGroup.Size = new System.Drawing.Size(692, 542);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupSettlementMod);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(692, 542);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "分组能源结算总览";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Controls.Add(this.groupControl3);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(692, 542);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.depSettlementMod);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(692, 542);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "部门能源结算总览";
            // 
            // groupSettlementMod
            // 
            this.groupSettlementMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSettlementMod.Location = new System.Drawing.Point(2, 21);
            this.groupSettlementMod.Name = "groupSettlementMod";
            this.groupSettlementMod.Size = new System.Drawing.Size(688, 519);
            this.groupSettlementMod.TabIndex = 0;
            // 
            // depSettlementMod
            // 
            this.depSettlementMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depSettlementMod.Location = new System.Drawing.Point(2, 21);
            this.depSettlementMod.Name = "depSettlementMod";
            this.depSettlementMod.Size = new System.Drawing.Size(688, 519);
            this.depSettlementMod.TabIndex = 0;
            // 
            // FrmSettlementOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 542);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmSettlementOverview";
            this.Text = "能源结算总览";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.navFrame.ResumeLayout(false);
            this.navPageGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Winform.Core.GroupChildrenTree settlementTree;
        private DevExpress.XtraBars.Navigation.NavigationFrame navFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageGroup;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private GroupSettlementModule groupSettlementMod;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DepartmentSettlementModule depSettlementMod;
    }
}