using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace DentaNova2
{

    public partial class SelectDoctor : Form
    {
        int index = 0;

        string[] doctorNames =
        {
            "Dr. Nurin",
            "Dr. Najmi",
            "Dr. Nazatul",
            "Dr. Haifa",
            "Dr. Ryny"
        };

        string[] specializations =
        {
             "Wisdom Extraction",            // Dr. Nurin
            "Tooth Extraction, Veneers",   // Dr. Najmi
            "Consultation, Cleaning",      // Dr. Nazatul
            "Braces",                       // Dr. Haifa
            "Teeth Whitening, Scaling"     // Dr. Ryny
        };

        string[] workingDays =
        {
            "Mon, Tue, Wed",
            "Thu, Fri, Sat",
            "Mon, Wed, Fri",
            "Tue, Thu",
            "Mon - Fri"
        };

        string[] workingHours =
        {
            "9:00 AM - 5:00 PM",
            "10:00 AM - 6:00 PM",
            "8:00 AM - 4:00 PM",
            "11:00 AM - 7:00 PM",
            "9:00 AM - 3:00 PM"
        };
        
        public SelectDoctor()
        {
            InitializeComponent();
        }

        string[] doctorImages =
{
    "Images/drnurin.jpg",
    "Images/drnajmi.jpg",
    "Images/drnazatul.jpg",
    "Images/drhaifa.jpg",
    "Images/drryny.jpg"
};

        private int currentDoctor = 0;
        private void SelectDoctor_Load(object sender, EventArgs e)
        {
            picDoctor.Image = imageList1.Images[currentDoctor];
            ShowDoctor();
        }

        private void ShowDoctor()
        {
            //lblDoctorName.Text = doctorNames[index];
            //lblDoctorSpecialization.Text = specializations[index];

            //lblDoctorDays.Text = "Mon - Sat";
            //lblDoctorHours.Text = "9:00 AM - 5:00 PM";

            lblDoctorName.Text = doctorNames[index];
            lblDoctorSpecialization.Text = specializations[index];

            lblDoctorDays.Text = workingDays[index];
            lblDoctorHours.Text = workingHours[index];

            picDoctor.Image = imageList1.Images[index];

            
        }

        private void btnNextDoctor_Click(object sender, EventArgs e)
        {
           index++;

           if (index >= doctorNames.Length)
                index = 0;

            ShowDoctor();
            //
            currentDoctor++;

            if (currentDoctor >= imageList1.Images.Count)
                currentDoctor = 0;

            picDoctor.Image = imageList1.Images[currentDoctor];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index--;

            if (index < 0)
                index = doctorNames.Length - 1;

            ShowDoctor();
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            index--;

            if (index < 0)
                index = doctorNames.Length - 1;

            ShowDoctor();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SelectDoctor form = new SelectDoctor();
            form.Show();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           

            SelectDateTime form = new SelectDateTime();
            form.Show();
        }


    }
}
