namespace Poseidon.Energy.ClientDx
{
    partial class FrmMeasureOverview
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.measureTree = new Poseidon.Winform.Core.GroupChildrenTree();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navPageGroup = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.navPageDepartment = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupMeasureMod = new Poseidon.Energy.ClientDx.GroupMeasureModule();
            this.depMeasureMod = new Poseidon.Energy.ClientDx.DepartmentMeasureModule();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.navFrame.SuspendLayout();
            this.navPageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.navPageDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.measureTree);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(229, 539);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "部门列表";
            // 
            // measureTree
            // 
            this.measureTree.CascadeOrganization = true;
            this.measureTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measureTree.Location = new System.Drawing.Point(2, 21);
            this.measureTree.Name = "measureTree";
            this.measureTree.ShowFindPanel = false;
            this.measureTree.Size = new System.Drawing.Size(225, 516);
            this.measureTree.TabIndex = 0;
            this.measureTree.GroupSelected += new System.EventHandler(this.measureTree_GroupSelected);
            this.measureTree.OrganizationSelected += new System.EventHandler(this.measureTree_OrganizationSelected);
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
            this.splitContainerControl1.Size = new System.Drawing.Size(911, 539);
            this.splitContainerControl1.SplitterPosition = 229;
            this.splitContainerControl1.TabIndex = 1;
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
            this.navFrame.Size = new System.Drawing.Size(677, 539);
            this.navFrame.TabIndex = 0;
            this.navFrame.Text = "navigationFrame1";
            // 
            // navPageGroup
            // 
            this.navPageGroup.Caption = "navPageGroup";
            this.navPageGroup.Controls.Add(this.groupControl2);
            this.navPageGroup.Name = "navPageGroup";
            this.navPageGroup.Size = new System.Drawing.Size(677, 539);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupMeasureMod);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(677, 539);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "分组能源计量总览";
            // 
            // navPageDepartment
            // 
            this.navPageDepartment.Caption = "navPageDepartment";
            this.navPageDepartment.Controls.Add(this.groupControl3);
            this.navPageDepartment.Name = "navPageDepartment";
            this.navPageDepartment.Size = new System.Drawing.Size(677, 539);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.depMeasureMod);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(677, 539);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "部门能源计量总览";
            // 
            // groupMeasureMod
            // 
            this.groupMeasureMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMeasureMod.Location = new System.Drawing.Point(2, 21);
            this.groupMeasureMod.Name = "groupMeasureMod";
            this.groupMeasureMod.Size = new System.Drawing.Size(673, 516);
            this.groupMeasureMod.TabIndex = 0;
            // 
            // depMeasureMod
            // 
            this.depMeasureMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depMeasureMod.Location = new System.Drawing.Point(2, 21);
            this.depMeasureMod.Name = "depMeasureMod";
            this.depMeasureMod.Size = new System.Drawing.Size(673, 516);
            this.depMeasureMod.TabIndex = 0;
            // 
            // FrmMeasureOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 539);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmMeasureOverview";
            this.Text = "能源计量总览";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.navFrame.ResumeLayout(false);
            this.navPageGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.navPageDepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Winform.Core.GroupChildrenTree measureTree;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageGroup;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageDepartment;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private GroupMeasureModule groupMeasureMod;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DepartmentMeasureModule depMeasureMod;
    }
}