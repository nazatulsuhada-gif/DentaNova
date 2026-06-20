using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edpProject3
{
    public partial class AppointmentSummaryForm : Form
    {
        public AppointmentSummaryForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking Confirmed!", "Success");

            MyAppointmentForm myForm = new MyAppointmentForm();
            myForm.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel booking?",
                "Cancel Booking",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                ChoosePatientForm patientForm = new ChoosePatientForm();
                patientForm.Show();
                this.Hide();
            }
        }
    }
}

