using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentanova_admin
{
    public partial class FormManageAppointment : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\alif4\\source\\repos\\dentanova admin\\dentanova admin\\DentaNovaDatabase.mdf\";Integrated Security=True");

        int selectedAppointmentID;
        private void LoadData()
        {
            string query = @"
        SELECT
            a.appointmentID,
            p.patientName,
            d.doctorName,
            a.appointmentDate,
            a.status
            FROM appointment a
            INNER JOIN patient p
            ON a.patientID = p.patientID
            INNER JOIN doctor d
            ON a.doctorID = d.doctorID";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            da.Fill(dt);

            appointmentDGV.DataSource = dt;
        }

        public FormManageAppointment()
        {
            InitializeComponent();
        }

       
            private void cancelBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"
                 UPDATE appointment
                SET status = 'Cancelled'
                WHERE appointmentID = @id";

            cmd.Parameters.AddWithValue("@id", selectedAppointmentID);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadData();

            MessageBox.Show("Appointment cancelled.");
        
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"
            UPDATE appointment
            SET status = 'Completed'
            WHERE appointmentID = @id";

            cmd.Parameters.AddWithValue("@id", selectedAppointmentID);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadData();

            MessageBox.Show("Appointment completed.");
        }

        

        private void appointmentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedAppointmentID =
                    Convert.ToInt32(
                        appointmentDGV.Rows[e.RowIndex]
                        .Cells["appointmentID"].Value);
            }
        }

        private void FormManageAppointment_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void nextTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAnalytical form2 = new FormAnalytical();
            form2.ShowDialog();
            this.Close();
        }
    }
}
