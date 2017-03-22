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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.plDepartmentTarget = new DevExpress.XtraEditors.PanelControl();
            this.groupTreeTarget = new Poseidon.Winform.Core.GroupChildrenTree();
            this.depTargetMod = new Poseidon.Energy.ClientDx.DepartmentTargetModule();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plDepartmentTarget)).BeginInit();
            this.plDepartmentTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 518);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.plDepartmentTarget);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(303, 3);
            this.groupControl1.Name = "groupControl1";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl1, 2);
            this.groupControl1.Size = new System.Drawing.Size(595, 512);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "部门指标信息";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupTreeTarget);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl2, 2);
            this.groupControl2.Size = new System.Drawing.Size(294, 512);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "指标计划部门列表";
            // 
            // plDepartmentTarget
            // 
            this.plDepartmentTarget.Controls.Add(this.depTargetMod);
            this.plDepartmentTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plDepartmentTarget.Location = new System.Drawing.Point(2, 21);
            this.plDepartmentTarget.Name = "plDepartmentTarget";
            this.plDepartmentTarget.Size = new System.Drawing.Size(591, 489);
            this.plDepartmentTarget.TabIndex = 0;
            // 
            // groupTreeTarget
            // 
            this.groupTreeTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTreeTarget.Location = new System.Drawing.Point(2, 21);
            this.groupTreeTarget.Name = "groupTreeTarget";
            this.groupTreeTarget.ShowFindPanel = false;
            this.groupTreeTarget.Size = new System.Drawing.Size(290, 489);
            this.groupTreeTarget.TabIndex = 0;
            this.groupTreeTarget.OrganizationSelected += new System.EventHandler(this.groupTreeTarget_OrganizationSelected);
            // 
            // depTargetMod
            // 
            this.depTargetMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depTargetMod.Location = new System.Drawing.Point(2, 2);
            this.depTargetMod.Name = "depTargetMod";
            this.depTargetMod.Size = new System.Drawing.Size(587, 485);
            this.depTargetMod.TabIndex = 0;
            // 
            // FrmTargetOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 518);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmTargetOverview";
            this.Text = "指标计划总览";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plDepartmentTarget)).EndInit();
            this.plDepartmentTarget.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Winform.Core.GroupChildrenTree groupTreeTarget;
        private DevExpress.XtraEditors.PanelControl plDepartmentTarget;
        private DepartmentTargetModule depTargetMod;
    }
}