namespace Poseidon.Energy.ClientDx
{
    partial class FrmTargetOverview
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupTreeTarget = new Poseidon.Winform.Core.GroupChildrenTree();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navPageGroup = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.navPageDepartment = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupTargetMod = new Poseidon.Energy.ClientDx.GroupTargetModule();
            this.depTargetMod = new Poseidon.Energy.ClientDx.DepartmentTargetModule();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.navFrame.SuspendLayout();
            this.navPageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.navPageDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupTreeTarget);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(181, 518);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "指标计划部门列表";
            // 
            // groupTreeTarget
            // 
            this.groupTreeTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTreeTarget.Location = new System.Drawing.Point(2, 21);
            this.groupTreeTarget.Name = "groupTreeTarget";
            this.groupTreeTarget.ShowFindPanel = false;
            this.groupTreeTarget.Size = new System.Drawing.Size(177, 495);
            this.groupTreeTarget.TabIndex = 0;
            this.groupTreeTarget.GroupSelected += new System.EventHandler(this.groupTreeTarget_GroupSelected);
            this.groupTreeTarget.EntitySelected += new System.EventHandler(this.groupTreeTarget_EntitySelected);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.depTargetMod);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(715, 518);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "部门指标信息";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.navFrame);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(901, 518);
            this.splitContainerControl1.SplitterPosition = 181;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // navFrame
            // 
            this.navFrame.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.navFrame.Controls.Add(this.navPageGroup);
            this.navFrame.Controls.Add(this.navPageDepartment);
            this.navFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navFrame.Location = new System.Drawing.Point(0, 0);
            this.navFrame.Name = "navFrame";
            this.navFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPage[] {
            this.navPageGroup,
            this.navPageDepartment});
            this.navFrame.SelectedPage = this.navPageGroup;
            this.navFrame.SelectedPageIndex = 0;
            this.navFrame.Size = new System.Drawing.Size(715, 518);
            this.navFrame.TabIndex = 0;
            this.navFrame.Text = "navigationFrame1";
            // 
            // navPageGroup
            // 
            this.navPageGroup.Controls.Add(this.groupControl3);
            this.navPageGroup.Name = "navPageGroup";
            this.navPageGroup.Size = new System.Drawing.Size(715, 518);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.groupTargetMod);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(715, 518);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "分组指标总览";
            // 
            // navPageDepartment
            // 
            this.navPageDepartment.Caption = "navigationPage2";
            this.navPageDepartment.Controls.Add(this.groupControl1);
            this.navPageDepartment.Name = "navPageDepartment";
            this.navPageDepartment.Size = new System.Drawing.Size(715, 518);
            // 
            // groupTargetMod
            // 
            this.groupTargetMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTargetMod.Location = new System.Drawing.Point(2, 21);
            this.groupTargetMod.Name = "groupTargetMod";
            this.groupTargetMod.Size = new System.Drawing.Size(711, 495);
            this.groupTargetMod.TabIndex = 0;
            // 
            // depTargetMod
            // 
            this.depTargetMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depTargetMod.Location = new System.Drawing.Point(2, 21);
            this.depTargetMod.Name = "depTargetMod";
            this.depTargetMod.Size = new System.Drawing.Size(711, 495);
            this.depTargetMod.TabIndex = 0;
            // 
            // FrmTargetOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 518);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmTargetOverview";
            this.Text = "指标计划总览";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.navFrame.ResumeLayout(false);
            this.navPageGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.navPageDepartment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Winform.Core.GroupChildrenTree groupTreeTarget;
        private DepartmentTargetModule depTargetMod;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageGroup;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageDepartment;
        private GroupTargetModule groupTargetMod;
    }
}