using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentaNova
{
    public partial class ChoosePatientForm : Form
    {
        public ChoosePatientForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            PatientDetailsForm form = new PatientDetailsForm();
            form.Show();
            this.Hide();
        }
    }
}
