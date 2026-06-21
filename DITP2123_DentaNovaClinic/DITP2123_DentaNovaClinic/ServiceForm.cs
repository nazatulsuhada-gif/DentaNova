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
    public partial class ServiceForm : Form
    {
        int i = 0;
        string[] serviceName =
        {
            "Dental Consultation",
            "Scaling & Polishing",
            "Dental Filling",
            "Tooth Extraction",
            "Wisdom Tooth Extraction",
            "Teeth Whitening",
            "Braces",
            "Veneers"
        };

        public ServiceForm()
        {
            InitializeComponent();
        }

        private void button_Prev_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                pictureBox_service.Image = imageListService.Images[i];
                label_Service.Text = serviceName[i];
            }
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (i < serviceName.Length - 1)
            {
                i++;
                pictureBox_service.Image = imageListService.Images[i];
                label_Service.Text = serviceName[i];
            }
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            pictureBox_service.Image = imageListService.Images[i];
            label_Service.Text = serviceName[i];
        }

        private void btn_makeAppoint_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
