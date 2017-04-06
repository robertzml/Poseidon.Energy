namespace Poseidon.Energy.ClientDx
{
    partial class WaterExpenseChart
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartEntity = new DevExpress.XtraCharts.ChartControl();
            this.bsWaterExpense = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWaterExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEntity
            // 
            this.chartEntity.DataSource = this.bsWaterExpense;
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month;
            xyDiagram1.AxisX.DateTimeScaleOptions.ProcessMissingPoints = DevExpress.XtraCharts.ProcessMissingPointsMode.InsertZeroValues;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartEntity.Diagram = xyDiagram1;
            this.chartEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartEntity.Location = new System.Drawing.Point(0, 0);
            this.chartEntity.Name = "chartEntity";
            series1.ArgumentDataMember = "BelongDate";
            series1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "水费";
            series1.ValueDataMembersSerializable = "TotalQuantity";
            this.chartEntity.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartEntity.Size = new System.Drawing.Size(709, 439);
            this.chartEntity.TabIndex = 0;
            chartTitle1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chartTitle1.Text = "水费支出";
            this.chartEntity.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // bsWaterExpense
            // 
            this.bsWaterExpense.DataSource = typeof(Poseidon.Energy.Core.DL.WaterExpense);
            // 
            // WaterExpenseChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartEntity);
            this.Name = "WaterExpenseChart";
            this.Size = new System.Drawing.Size(709, 439);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWaterExpense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartEntity;
        private System.Windows.Forms.BindingSource bsWaterExpense;
    }
}
