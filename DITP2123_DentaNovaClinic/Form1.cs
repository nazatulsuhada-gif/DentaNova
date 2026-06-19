using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DITP2123_DentaNovaClinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTo_Services_Click(object sender, EventArgs e)
        {
            FormServices servicesForm = new FormServices();
            servicesForm.Show();
            this.Hide();
        }
    }
}
