
namespace DemoGritLogin
{
    partial class AnalyticsProgress
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblHeight = new System.Windows.Forms.Label();
            this.BMIAnalysisChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWeight1 = new System.Windows.Forms.Label();
            this.lblWeight2 = new System.Windows.Forms.Label();
            this.ProgressDisChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxRecords = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BMIAnalysisChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressDisChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.Color.Yellow;
            this.lblHeight.Location = new System.Drawing.Point(423, 16);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(32, 24);
            this.lblHeight.TabIndex = 21;
            this.lblHeight.Text = "__";
            // 
            // BMIAnalysisChart
            // 
            this.BMIAnalysisChart.BackColor = System.Drawing.Color.Gray;
            this.BMIAnalysisChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.BackColor = System.Drawing.Color.Silver;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Silver;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea1.Name = "Training Goal Breakdown";
            this.BMIAnalysisChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Gray;
            legend1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.BMIAnalysisChart.Legends.Add(legend1);
            this.BMIAnalysisChart.Location = new System.Drawing.Point(148, 196);
            this.BMIAnalysisChart.Name = "BMIAnalysisChart";
            this.BMIAnalysisChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.BMIAnalysisChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))))};
            series1.ChartArea = "Training Goal Breakdown";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Label = "#PERCENT / #VALY";
            series1.Legend = "Legend1";
            series1.Name = "BMI";
            this.BMIAnalysisChart.Series.Add(series1);
            this.BMIAnalysisChart.Size = new System.Drawing.Size(744, 377);
            this.BMIAnalysisChart.TabIndex = 22;
            this.BMIAnalysisChart.Text = "BMI Breakdown";
            title1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "BMI Breakdown";
            this.BMIAnalysisChart.Titles.Add(title1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(235, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Average Height :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(174, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Average Initial Weight :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(148, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Average Current Weight :";
            // 
            // lblWeight1
            // 
            this.lblWeight1.AutoSize = true;
            this.lblWeight1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight1.ForeColor = System.Drawing.Color.Yellow;
            this.lblWeight1.Location = new System.Drawing.Point(423, 76);
            this.lblWeight1.Name = "lblWeight1";
            this.lblWeight1.Size = new System.Drawing.Size(32, 24);
            this.lblWeight1.TabIndex = 21;
            this.lblWeight1.Text = "__";
            // 
            // lblWeight2
            // 
            this.lblWeight2.AutoSize = true;
            this.lblWeight2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight2.ForeColor = System.Drawing.Color.Yellow;
            this.lblWeight2.Location = new System.Drawing.Point(423, 136);
            this.lblWeight2.Name = "lblWeight2";
            this.lblWeight2.Size = new System.Drawing.Size(32, 24);
            this.lblWeight2.TabIndex = 21;
            this.lblWeight2.Text = "__";
            // 
            // ProgressDisChart
            // 
            this.ProgressDisChart.BackColor = System.Drawing.Color.Gray;
            this.ProgressDisChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.BackColor = System.Drawing.Color.Silver;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea2.BackImageTransparentColor = System.Drawing.Color.Silver;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea2.Name = "Training Goal Breakdown";
            this.ProgressDisChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Gray;
            legend2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.ProgressDisChart.Legends.Add(legend2);
            this.ProgressDisChart.Location = new System.Drawing.Point(148, 595);
            this.ProgressDisChart.Name = "ProgressDisChart";
            this.ProgressDisChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ProgressDisChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))))};
            series2.ChartArea = "Training Goal Breakdown";
            series2.Legend = "Legend1";
            series2.Name = "Progress Logs";
            this.ProgressDisChart.Series.Add(series2);
            this.ProgressDisChart.Size = new System.Drawing.Size(744, 377);
            this.ProgressDisChart.TabIndex = 23;
            this.ProgressDisChart.Text = "BMI Breakdown";
            title2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Record Distribution Breakdown";
            this.ProgressDisChart.Titles.Add(title2);
            // 
            // cbxRecords
            // 
            this.cbxRecords.AutoCompleteCustomSource.AddRange(new string[] {
            "Past Month",
            "Past 3 Months",
            "Past 6 Months",
            "Past 12 Months"});
            this.cbxRecords.BackColor = System.Drawing.Color.Black;
            this.cbxRecords.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRecords.ForeColor = System.Drawing.Color.Yellow;
            this.cbxRecords.FormattingEnabled = true;
            this.cbxRecords.Items.AddRange(new object[] {
            "See All",
            "1 Month",
            "3 Months",
            "6 Months",
            "12 Months"});
            this.cbxRecords.Location = new System.Drawing.Point(752, 11);
            this.cbxRecords.Name = "cbxRecords";
            this.cbxRecords.Size = new System.Drawing.Size(140, 29);
            this.cbxRecords.TabIndex = 54;
            this.cbxRecords.Text = "See All ";
            this.cbxRecords.SelectedIndexChanged += new System.EventHandler(this.cbxRecords_SelectedIndexChanged);
            // 
            // AnalyticsProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.cbxRecords);
            this.Controls.Add(this.ProgressDisChart);
            this.Controls.Add(this.BMIAnalysisChart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWeight2);
            this.Controls.Add(this.lblWeight1);
            this.Controls.Add(this.lblHeight);
            this.Name = "AnalyticsProgress";
            this.Size = new System.Drawing.Size(1024, 551);
            this.Load += new System.EventHandler(this.AnalyticsProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BMIAnalysisChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressDisChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.DataVisualization.Charting.Chart BMIAnalysisChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWeight1;
        private System.Windows.Forms.Label lblWeight2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProgressDisChart;
        private System.Windows.Forms.ComboBox cbxRecords;
    }
}
