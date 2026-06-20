namespace dentanova_admin
{
    partial class FormAnalytical
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.reportTypeCB = new System.Windows.Forms.ComboBox();
            this.reportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.generateBtn = new System.Windows.Forms.Button();
            this.nextTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Report Type : ";
            // 
            // reportTypeCB
            // 
            this.reportTypeCB.FormattingEnabled = true;
            this.reportTypeCB.Items.AddRange(new object[] {
            "Most Popular Doctor",
            "Most Popular Service",
            "Appointment Status",
            "Monthly Appointments"});
            this.reportTypeCB.Location = new System.Drawing.Point(299, 69);
            this.reportTypeCB.Name = "reportTypeCB";
            this.reportTypeCB.Size = new System.Drawing.Size(505, 33);
            this.reportTypeCB.TabIndex = 2;
            // 
            // reportChart
            // 
            chartArea4.Name = "ChartArea1";
            this.reportChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.reportChart.Legends.Add(legend4);
            this.reportChart.Location = new System.Drawing.Point(106, 136);
            this.reportChart.Name = "reportChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.reportChart.Series.Add(series4);
            this.reportChart.Size = new System.Drawing.Size(881, 414);
            this.reportChart.TabIndex = 3;
            this.reportChart.Text = "reportChart";
            this.reportChart.Click += new System.EventHandler(this.reportChart_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Location = new System.Drawing.Point(866, 69);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(121, 33);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click_1);
            // 
            // nextTest
            // 
            this.nextTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.nextTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.nextTest.Location = new System.Drawing.Point(892, 598);
            this.nextTest.Name = "nextTest";
            this.nextTest.Size = new System.Drawing.Size(95, 38);
            this.nextTest.TabIndex = 5;
            this.nextTest.Text = "next";
            this.nextTest.UseVisualStyleBackColor = false;
            this.nextTest.Click += new System.EventHandler(this.nextTest_Click);
            // 
            // FormAnalytical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.nextTest);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.reportChart);
            this.Controls.Add(this.reportTypeCB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormAnalytical";
            this.Text = "View Analytical Service";
            this.Load += new System.EventHandler(this.FormAnalytical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox reportTypeCB;
        private System.Windows.Forms.DataVisualization.Charting.Chart reportChart;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button nextTest;
    }
}