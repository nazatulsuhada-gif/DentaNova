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
    public partial class ManageDoctors : Form
    {
        public ManageDoctors()
        {
            InitializeComponent();
        }

        private void ManageDoctors_Load(object sender, EventArgs e)
        {
            dgvDoctors.Columns.Clear();

            dgvDoctors.Columns.Add("DoctorID", "Doctor ID");
            dgvDoctors.Columns.Add("DoctorName", "Doctor Name");
            dgvDoctors.Columns.Add("Specialization", "Specialization");
            dgvDoctors.Columns.Add("Phone", "Phone");
            dgvDoctors.Columns.Add("Email", "Email");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvDoctors.Rows.Add(
               txtDoctorID.Text,
               txtDoctorName.Text,
               txtSpecialization.Text,
               txtPhone.Text,
               txtEmail.Text);

            ClearBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow != null)
            {
                dgvDoctors.CurrentRow.Cells[0].Value = txtDoctorID.Text;
                dgvDoctors.CurrentRow.Cells[1].Value = txtDoctorName.Text;
                dgvDoctors.CurrentRow.Cells[2].Value = txtSpecialization.Text;
                dgvDoctors.CurrentRow.Cells[3].Value = txtPhone.Text;
                dgvDoctors.CurrentRow.Cells[4].Value = txtEmail.Text;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow != null)
            {
                dgvDoctors.Rows.Remove(dgvDoctors.CurrentRow);
            }
        }

        private void dgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDoctors.Rows[e.RowIndex];

                txtDoctorID.Text = row.Cells[0].Value?.ToString();
                txtDoctorName.Text = row.Cells[1].Value?.ToString();
                txtSpecialization.Text = row.Cells[2].Value?.ToString();
                txtPhone.Text = row.Cells[3].Value?.ToString();
                txtEmail.Text = row.Cells[4].Value?.ToString();
            }
        }

       

        private void ClearBoxes()
        {
            txtDoctorID.Clear();
            txtDoctorName.Clear();
            txtSpecialization.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }
    }
}
