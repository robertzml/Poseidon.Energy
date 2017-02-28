namespace Poseidon.Energy.ClientDx
{
    partial class FrmTargetDepartment
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.departmentTargetGrid1 = new Poseidon.Energy.ClientDx.DepartmentTargetGrid();
            this.staffTargetGrid1 = new Poseidon.Energy.ClientDx.StaffTargetGrid();
            this.lbPlanTarget = new DevExpress.XtraEditors.ListBoxControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbPlanTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 501);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.departmentTargetGrid1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 203);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(194, 144);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "部门列表";
            // 
            // groupControl2
            // 
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(203, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(599, 194);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "指标分项";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.staffTargetGrid1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(203, 203);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(599, 144);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "人员指标";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.lbPlanTarget);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(3, 3);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(194, 194);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "年度指标计划列表";
            // 
            // departmentTargetGrid1
            // 
            this.departmentTargetGrid1.DataSource = null;
            this.departmentTargetGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentTargetGrid1.Editable = false;
            this.departmentTargetGrid1.Location = new System.Drawing.Point(2, 21);
            this.departmentTargetGrid1.Name = "departmentTargetGrid1";
            this.departmentTargetGrid1.ShowFooter = false;
            this.departmentTargetGrid1.ShowLineNumber = false;
            this.departmentTargetGrid1.Size = new System.Drawing.Size(190, 121);
            this.departmentTargetGrid1.TabIndex = 0;
            // 
            // staffTargetGrid1
            // 
            this.staffTargetGrid1.DataSource = null;
            this.staffTargetGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffTargetGrid1.Editable = false;
            this.staffTargetGrid1.Location = new System.Drawing.Point(2, 21);
            this.staffTargetGrid1.Name = "staffTargetGrid1";
            this.staffTargetGrid1.ShowFooter = false;
            this.staffTargetGrid1.ShowLineNumber = false;
            this.staffTargetGrid1.Size = new System.Drawing.Size(595, 121);
            this.staffTargetGrid1.TabIndex = 0;
            // 
            // lbPlanTarget
            // 
            this.lbPlanTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPlanTarget.Location = new System.Drawing.Point(2, 21);
            this.lbPlanTarget.Name = "lbPlanTarget";
            this.lbPlanTarget.Size = new System.Drawing.Size(190, 171);
            this.lbPlanTarget.TabIndex = 0;
            // 
            // FrmTargetDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmTargetDepartment";
            this.Text = "部门指标制定";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbPlanTarget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DepartmentTargetGrid departmentTargetGrid1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private StaffTargetGrid staffTargetGrid1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.ListBoxControl lbPlanTarget;
    }
}