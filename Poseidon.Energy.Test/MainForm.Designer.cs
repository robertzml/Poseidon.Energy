﻿namespace Poseidon.Energy.Test
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTargetOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTargetMake = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPopulationManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFundManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPopulationOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFundOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepartmentOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExpense = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExpenseOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExpenseReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExpenseAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMeasureManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMeasureOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettlement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettlementManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettlementOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTarget,
            this.menuDepartment,
            this.menuExpense,
            this.menuMeasure,
            this.menuSettlement});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTarget
            // 
            this.menuTarget.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTargetOverview,
            this.menuTargetMake,
            this.toolStripSeparator1,
            this.menuPopulationManage,
            this.menuFundManage,
            this.menuPopulationOverview,
            this.menuFundOverview});
            this.menuTarget.Name = "menuTarget";
            this.menuTarget.Size = new System.Drawing.Size(80, 21);
            this.menuTarget.Text = "指标化管理";
            // 
            // menuTargetOverview
            // 
            this.menuTargetOverview.Name = "menuTargetOverview";
            this.menuTargetOverview.Size = new System.Drawing.Size(124, 22);
            this.menuTargetOverview.Text = "指标总览";
            this.menuTargetOverview.Click += new System.EventHandler(this.menuTargetOverview_Click);
            // 
            // menuTargetMake
            // 
            this.menuTargetMake.Name = "menuTargetMake";
            this.menuTargetMake.Size = new System.Drawing.Size(124, 22);
            this.menuTargetMake.Text = "指标制定";
            this.menuTargetMake.Click += new System.EventHandler(this.menuTargetMake_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // menuPopulationManage
            // 
            this.menuPopulationManage.Name = "menuPopulationManage";
            this.menuPopulationManage.Size = new System.Drawing.Size(124, 22);
            this.menuPopulationManage.Text = "人数统计";
            this.menuPopulationManage.Click += new System.EventHandler(this.menuPopulationManage_Click);
            // 
            // menuFundManage
            // 
            this.menuFundManage.Name = "menuFundManage";
            this.menuFundManage.Size = new System.Drawing.Size(124, 22);
            this.menuFundManage.Text = "经费统计";
            this.menuFundManage.Click += new System.EventHandler(this.menuFundManage_Click);
            // 
            // menuPopulationOverview
            // 
            this.menuPopulationOverview.Name = "menuPopulationOverview";
            this.menuPopulationOverview.Size = new System.Drawing.Size(124, 22);
            this.menuPopulationOverview.Text = "人数总览";
            this.menuPopulationOverview.Click += new System.EventHandler(this.menuPopulationOverview_Click);
            // 
            // menuFundOverview
            // 
            this.menuFundOverview.Name = "menuFundOverview";
            this.menuFundOverview.Size = new System.Drawing.Size(124, 22);
            this.menuFundOverview.Text = "经费总览";
            this.menuFundOverview.Click += new System.EventHandler(this.menuFundOverview_Click);
            // 
            // menuDepartment
            // 
            this.menuDepartment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDepartmentOverview});
            this.menuDepartment.Name = "menuDepartment";
            this.menuDepartment.Size = new System.Drawing.Size(68, 21);
            this.menuDepartment.Text = "部门管理";
            // 
            // menuDepartmentOverview
            // 
            this.menuDepartmentOverview.Name = "menuDepartmentOverview";
            this.menuDepartmentOverview.Size = new System.Drawing.Size(124, 22);
            this.menuDepartmentOverview.Text = "部门总览";
            this.menuDepartmentOverview.Click += new System.EventHandler(this.menuDepartmentOverview_Click);
            // 
            // menuExpense
            // 
            this.menuExpense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExpenseOverview,
            this.menuExpenseReceipt,
            this.menuExpenseAccount});
            this.menuExpense.Name = "menuExpense";
            this.menuExpense.Size = new System.Drawing.Size(68, 21);
            this.menuExpense.Text = "支出管理";
            // 
            // menuExpenseOverview
            // 
            this.menuExpenseOverview.Name = "menuExpenseOverview";
            this.menuExpenseOverview.Size = new System.Drawing.Size(124, 22);
            this.menuExpenseOverview.Text = "支出总览";
            this.menuExpenseOverview.Click += new System.EventHandler(this.menuExpenseOverview_Click);
            // 
            // menuExpenseReceipt
            // 
            this.menuExpenseReceipt.Name = "menuExpenseReceipt";
            this.menuExpenseReceipt.Size = new System.Drawing.Size(124, 22);
            this.menuExpenseReceipt.Text = "支出单据";
            this.menuExpenseReceipt.Click += new System.EventHandler(this.menuExpenseReceipt_Click);
            // 
            // menuExpenseAccount
            // 
            this.menuExpenseAccount.Name = "menuExpenseAccount";
            this.menuExpenseAccount.Size = new System.Drawing.Size(124, 22);
            this.menuExpenseAccount.Text = "账户管理";
            this.menuExpenseAccount.Click += new System.EventHandler(this.menuExpenseAccount_Click);
            // 
            // menuMeasure
            // 
            this.menuMeasure.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMeasureManage,
            this.menuMeasureOverview});
            this.menuMeasure.Name = "menuMeasure";
            this.menuMeasure.Size = new System.Drawing.Size(68, 21);
            this.menuMeasure.Text = "能源计量";
            // 
            // menuMeasureManage
            // 
            this.menuMeasureManage.Name = "menuMeasureManage";
            this.menuMeasureManage.Size = new System.Drawing.Size(148, 22);
            this.menuMeasureManage.Text = "能源计量管理";
            this.menuMeasureManage.Click += new System.EventHandler(this.menuMeasureManage_Click);
            // 
            // menuMeasureOverview
            // 
            this.menuMeasureOverview.Name = "menuMeasureOverview";
            this.menuMeasureOverview.Size = new System.Drawing.Size(148, 22);
            this.menuMeasureOverview.Text = "能源计量总览";
            this.menuMeasureOverview.Click += new System.EventHandler(this.menuMeasureOverview_Click);
            // 
            // menuSettlement
            // 
            this.menuSettlement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettlementManage,
            this.menuSettlementOverview});
            this.menuSettlement.Name = "menuSettlement";
            this.menuSettlement.Size = new System.Drawing.Size(68, 21);
            this.menuSettlement.Text = "能源结算";
            // 
            // menuSettlementManage
            // 
            this.menuSettlementManage.Name = "menuSettlementManage";
            this.menuSettlementManage.Size = new System.Drawing.Size(152, 22);
            this.menuSettlementManage.Text = "能源结算管理";
            this.menuSettlementManage.Click += new System.EventHandler(this.menuSettlementManage_Click);
            // 
            // menuSettlementOverview
            // 
            this.menuSettlementOverview.Name = "menuSettlementOverview";
            this.menuSettlementOverview.Size = new System.Drawing.Size(152, 22);
            this.menuSettlementOverview.Text = "能源结算总览";
            this.menuSettlementOverview.Click += new System.EventHandler(this.menuSettlementOverview_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 480);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "测试";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTarget;
        private System.Windows.Forms.ToolStripMenuItem menuTargetOverview;
        private System.Windows.Forms.ToolStripMenuItem menuTargetMake;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuPopulationManage;
        private System.Windows.Forms.ToolStripMenuItem menuFundManage;
        private System.Windows.Forms.ToolStripMenuItem menuDepartment;
        private System.Windows.Forms.ToolStripMenuItem menuDepartmentOverview;
        private System.Windows.Forms.ToolStripMenuItem menuExpense;
        private System.Windows.Forms.ToolStripMenuItem menuExpenseOverview;
        private System.Windows.Forms.ToolStripMenuItem menuExpenseAccount;
        private System.Windows.Forms.ToolStripMenuItem menuExpenseReceipt;
        private System.Windows.Forms.ToolStripMenuItem menuPopulationOverview;
        private System.Windows.Forms.ToolStripMenuItem menuFundOverview;
        private System.Windows.Forms.ToolStripMenuItem menuMeasure;
        private System.Windows.Forms.ToolStripMenuItem menuMeasureManage;
        private System.Windows.Forms.ToolStripMenuItem menuMeasureOverview;
        private System.Windows.Forms.ToolStripMenuItem menuSettlement;
        private System.Windows.Forms.ToolStripMenuItem menuSettlementManage;
        private System.Windows.Forms.ToolStripMenuItem menuSettlementOverview;
    }
}

