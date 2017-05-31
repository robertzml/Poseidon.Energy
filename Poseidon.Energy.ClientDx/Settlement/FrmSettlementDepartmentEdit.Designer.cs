namespace Poseidon.Energy.ClientDx
{
    partial class FrmSettlementDepartmentEdit
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
            this.recordGrid = new Poseidon.Energy.ClientDx.SettlementRecordGrid();
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(892, 15);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(783, 15);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.tableLayoutPanel1);
            this.plFill.Size = new System.Drawing.Size(984, 282);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Location = new System.Drawing.Point(0, 282);
            this.plBottom.Size = new System.Drawing.Size(984, 60);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 282);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.recordGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(978, 276);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "结算信息";
            // 
            // recordGrid
            // 
            this.recordGrid.AllowBeginEdit = true;
            this.recordGrid.AllowFilter = false;
            this.recordGrid.AllowGroup = false;
            this.recordGrid.AllowSort = false;
            this.recordGrid.DataSource = null;
            this.recordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordGrid.Editable = true;
            this.recordGrid.EnableMasterView = false;
            this.recordGrid.EnableMultiSelect = false;
            this.recordGrid.Location = new System.Drawing.Point(2, 21);
            this.recordGrid.Name = "recordGrid";
            this.recordGrid.ShowAddMenu = false;
            this.recordGrid.ShowFooter = true;
            this.recordGrid.ShowLineNumber = true;
            this.recordGrid.ShowMenu = false;
            this.recordGrid.ShowNavigator = false;
            this.recordGrid.ShowRefColumn = false;
            this.recordGrid.ShowSettlement = true;
            this.recordGrid.Size = new System.Drawing.Size(974, 253);
            this.recordGrid.TabIndex = 0;
            // 
            // FrmSettlementDepartmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 342);
            this.Name = "FrmSettlementDepartmentEdit";
            this.Text = "编辑部门结算记录";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private SettlementRecordGrid recordGrid;
    }
}