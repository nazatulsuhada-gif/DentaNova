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
    public partial class FormServices : Form
    {
        int i = 0;

        string[] servicesName = { "Braces", "Dental Consultation", "Dental Filling", "Teeth Cleaning",
        "Teeth Whitening", "Tooth Extraction", "Veneers", "Wisdom Extraction"};

        public FormServices()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (i<7)
            {
                i++;
                picBox_listServices.Image = imageListServices.Images[i];
                lbl_ServicesName.Text = servicesName[i];
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                picBox_listServices.Image = imageListServices.Images[i];
                lbl_ServicesName.Text = servicesName[i];
            }
        }

        private void FormServices_Load_1(object sender, EventArgs e)
        {
            picBox_listServices.Image = imageListServices.Images[i];
            lbl_ServicesName.Text = servicesName[i];
        }

        private void lbl_TimeDay_Click(object sender, EventArgs e)
        {

        }
    }
}
