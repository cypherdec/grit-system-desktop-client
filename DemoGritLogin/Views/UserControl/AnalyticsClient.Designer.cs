
namespace DemoGritLogin
{
    partial class AnalyticsClient
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.AgeBreakdownChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TrainingGoalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.GenderAnalysisChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxRecords = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AgeBreakdownChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingGoalChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderAnalysisChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateChart)).BeginInit();
            this.SuspendLayout();
            // 
            // AgeBreakdownChart
            // 
            this.AgeBreakdownChart.BackColor = System.Drawing.Color.Gray;
            this.AgeBreakdownChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.BackColor = System.Drawing.Color.Silver;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Silver;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea1.Name = "Age Breakdown";
            this.AgeBreakdownChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Gray;
            legend1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.AgeBreakdownChart.Legends.Add(legend1);
            this.AgeBreakdownChart.Location = new System.Drawing.Point(165, 68);
            this.AgeBreakdownChart.Name = "AgeBreakdownChart";
            this.AgeBreakdownChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.AgeBreakdownChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))))};
            series1.ChartArea = "Age Breakdown";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Label = "#PERCENT / #VALY";
            series1.Legend = "Legend1";
            series1.Name = "Age";
            this.AgeBreakdownChart.Series.Add(series1);
            this.AgeBreakdownChart.Size = new System.Drawing.Size(744, 377);
            this.AgeBreakdownChart.TabIndex = 18;
            this.AgeBreakdownChart.Text = "Age Breakdown";
            title1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Age Breakdown";
            this.AgeBreakdownChart.Titles.Add(title1);
            // 
            // TrainingGoalChart
            // 
            this.TrainingGoalChart.BackColor = System.Drawing.Color.Gray;
            this.TrainingGoalChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.BackColor = System.Drawing.Color.Silver;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea2.BackImageTransparentColor = System.Drawing.Color.Silver;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea2.Name = "Training Goal Breakdown";
            this.TrainingGoalChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Gray;
            legend2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.TrainingGoalChart.Legends.Add(legend2);
            this.TrainingGoalChart.Location = new System.Drawing.Point(165, 459);
            this.TrainingGoalChart.Name = "TrainingGoalChart";
            this.TrainingGoalChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.TrainingGoalChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))))};
            series2.ChartArea = "Training Goal Breakdown";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Label = "#PERCENT / #VALY";
            series2.Legend = "Legend1";
            series2.Name = "Goal";
            this.TrainingGoalChart.Series.Add(series2);
            this.TrainingGoalChart.Size = new System.Drawing.Size(744, 377);
            this.TrainingGoalChart.TabIndex = 19;
            this.TrainingGoalChart.Text = "Traiing Goal Breakdown";
            title2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Training Goal Breakdown";
            this.TrainingGoalChart.Titles.Add(title2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(459, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Client Statistics";
            // 
            // GenderAnalysisChart
            // 
            this.GenderAnalysisChart.BackColor = System.Drawing.Color.Gray;
            this.GenderAnalysisChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.BackColor = System.Drawing.Color.Silver;
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea3.BackImageTransparentColor = System.Drawing.Color.Silver;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea3.Name = "Training Goal Breakdown";
            this.GenderAnalysisChart.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Gray;
            legend3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.GenderAnalysisChart.Legends.Add(legend3);
            this.GenderAnalysisChart.Location = new System.Drawing.Point(165, 850);
            this.GenderAnalysisChart.Name = "GenderAnalysisChart";
            this.GenderAnalysisChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.GenderAnalysisChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))))};
            series3.ChartArea = "Training Goal Breakdown";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Label = "#PERCENT / #VALY";
            series3.Legend = "Legend1";
            series3.Name = "Gender";
            this.GenderAnalysisChart.Series.Add(series3);
            this.GenderAnalysisChart.Size = new System.Drawing.Size(744, 377);
            this.GenderAnalysisChart.TabIndex = 21;
            this.GenderAnalysisChart.Text = "Traiing Goal Breakdown";
            title3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Gender Breakdown";
            this.GenderAnalysisChart.Titles.Add(title3);
            // 
            // DateChart
            // 
            this.DateChart.BackColor = System.Drawing.Color.Gray;
            this.DateChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea4.BackColor = System.Drawing.Color.Silver;
            chartArea4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea4.BackImageTransparentColor = System.Drawing.Color.Silver;
            chartArea4.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea4.Name = "Training Goal Breakdown";
            this.DateChart.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Gray;
            legend4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.DateChart.Legends.Add(legend4);
            this.DateChart.Location = new System.Drawing.Point(165, 1241);
            this.DateChart.Name = "DateChart";
            this.DateChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.DateChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Yellow};
            series4.ChartArea = "Training Goal Breakdown";
            series4.Color = System.Drawing.Color.Yellow;
            series4.CustomProperties = "DrawingStyle=LightToDark";
            series4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Registration";
            this.DateChart.Series.Add(series4);
            this.DateChart.Size = new System.Drawing.Size(744, 377);
            this.DateChart.TabIndex = 22;
            this.DateChart.Text = "Traiing Goal Breakdown";
            title4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Date";
            title4.Text = "Resgistration Trends";
            this.DateChart.Titles.Add(title4);
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
            this.cbxRecords.Location = new System.Drawing.Point(634, 26);
            this.cbxRecords.Name = "cbxRecords";
            this.cbxRecords.Size = new System.Drawing.Size(140, 29);
            this.cbxRecords.TabIndex = 53;
            this.cbxRecords.Text = "See All ";
            this.cbxRecords.SelectedIndexChanged += new System.EventHandler(this.cbxRecords_SelectedIndexChanged);
            // 
            // AnalyticsClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.cbxRecords);
            this.Controls.Add(this.DateChart);
            this.Controls.Add(this.GenderAnalysisChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrainingGoalChart);
            this.Controls.Add(this.AgeBreakdownChart);
            this.Name = "AnalyticsClient";
            this.Size = new System.Drawing.Size(1041, 551);
            this.Load += new System.EventHandler(this.AnalyticsClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgeBreakdownChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingGoalChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderAnalysisChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart AgeBreakdownChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart TrainingGoalChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GenderAnalysisChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart DateChart;
        private System.Windows.Forms.ComboBox cbxRecords;
    }
}
