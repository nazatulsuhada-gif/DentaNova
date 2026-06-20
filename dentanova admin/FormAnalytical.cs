using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace dentanova_admin
{
    public partial class FormAnalytical : Form
    {
        public FormAnalytical()
        {
            InitializeComponent();
        }

        private void FormAnalytical_Load(object sender, EventArgs e)
        {

        }

        private void reportChart_Click(object sender, EventArgs e)
        {

        }

        private void LoadDoctorChart()
        {
            reportChart.Series.Add("Report");

            reportChart.Series["Report"].ChartType = SeriesChartType.Column;

            reportChart.Titles.Add("Most Popular Doctors");

            // test data
            reportChart.Series["Report"].Points.AddXY("Dr. Tan", 25);
            reportChart.Series["Report"].Points.AddXY("Dr. Lim", 18);
            reportChart.Series["Report"].Points.AddXY("Dr. Lee", 12);
        }

        private void LoadServiceChart()
        {
            reportChart.Series.Add("Report");

            reportChart.Series["Report"].ChartType = SeriesChartType.Column;

            reportChart.Titles.Add("Most Popular Services");

            //test data
            reportChart.Series["Report"].Points.AddXY("Scaling", 30);
            reportChart.Series["Report"].Points.AddXY("Filling", 20);
            reportChart.Series["Report"].Points.AddXY("Extraction", 15);
        }

        
        private void LoadStatusChart()
        {
            reportChart.Series.Clear();
            reportChart.Titles.Clear();

            Series s = reportChart.Series.Add("Status");
            s.ChartType = SeriesChartType.Pie;

            s.Points.AddXY("Pending", 10);
            s.Points.AddXY("Completed", 40);
            s.Points.AddXY("Cancelled", 5);

            reportChart.Titles.Add("Appointment Status");
        }

        private void LoadMonthlyChart()
        {
            reportChart.Series.Clear();
            reportChart.Titles.Clear();

            Series s = reportChart.Series.Add("Monthly");
            s.ChartType = SeriesChartType.Line;

            s.Points.AddXY("Jan", 20);
            s.Points.AddXY("Feb", 30);
            s.Points.AddXY("Mar", 25);

            reportChart.Titles.Add("Monthly Appointments");
        }




        private void nextTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDoctorSchedule form2 = new FormDoctorSchedule();
            form2.ShowDialog();
            this.Close();
        }

        private void generateBtn_Click_1(object sender, EventArgs e)
        {
            // Make sure a report is selected
            if (reportTypeCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a report type.");
                return;
            }

            // Clear previous chart
            reportChart.Series.Clear();
            reportChart.Titles.Clear();

            switch (reportTypeCB.Text)
            {
                case "Most Popular Doctor":
                    LoadDoctorChart();
                    break;

                case "Most Popular Service":
                    LoadServiceChart();
                    break;

                case "Appointment Status":
                    LoadStatusChart();
                    break;

                case "Monthly Appointments":
                    LoadMonthlyChart();
                    break;
            }
        }
    }
}
