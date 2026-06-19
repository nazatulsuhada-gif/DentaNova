using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DITP2123_DentaNovaClinic
{
    public partial class LogInForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-9K5QG8P\SQLEXPRESS;Initial Catalog=DentaNovaClinic;Integrated Security=True");
        public LogInForm()
        {
            InitializeComponent();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim().ToLower();

            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Admin login
            if(email.Contains("@dentanova"))
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();
            }

            // Patient login
            else if (email.Contains("@gmail") || email.Contains("@yahoo") || email.Contains("@outlook"))
            {
                PatientDashboard patientDashboard = new PatientDashboard();
                patientDashboard.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid email. Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
