using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edpProject2
{
    public partial class SelectServiceForm : Form
    {
        private string firstName;
        public SelectServiceForm()
        {
            InitializeComponent();
            firstName = "Siti";
        }

        public SelectServiceForm(string fname)
        {
            InitializeComponent();
            firstName = fname;
        }

        private void SelectServiceForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + firstName;
        }

        private string GetSelectedService()
        {
            foreach (Control control in groupBoxServices.Controls)
            {
                if (control is RadioButton rb && rb.Checked)
                {
                    return rb.Text;
                }
            }
            return "";
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            string selectedService = GetSelectedService();

            if (selectedService == "")
            {
                MessageBox.Show(
                    "Please select a dental service first.",
                    "Service Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            SelectDoctorForm doctorForm = new SelectDoctorForm();
            doctorForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PageOurService page = new PageOurService();

            page.Show();
            this.Hide();
        }
    }
}

