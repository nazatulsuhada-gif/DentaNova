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

namespace dentanova_admin
{
    public partial class FormDoctorSchedule : Form

    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\alif4\\source\\repos\\dentanova admin\\dentanova admin\\DentaNovaDatabase.mdf\";Integrated Security=True") ;
        public FormDoctorSchedule()
        {
            InitializeComponent();
        }

        int selectedDoctorID;

        private void LoadDoctor()
        {
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT doctorID, doctorName FROM doctor",
                conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            doctorCB.DataSource = dt;
            doctorCB.DisplayMember = "doctorName";
            doctorCB.ValueMember = "doctorID";

            conn.Close();
        }

        private void LoadData()
        {
            string query = @"
        SELECT 
            d.doctorID,
            d.doctorName,
            d.status,
            STRING_AGG(ds.day, ', ') AS workingDays,
            MIN(ds.startTime) AS startTime,
            MAX(ds.endTime) AS endTime
        FROM doctor d
        LEFT JOIN doctorSchedule ds
            ON d.doctorID = ds.doctorID
        GROUP BY 
            d.doctorID,
            d.doctorName,
            d.status";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            scheduleDGV.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
               
                int doctorID = Convert.ToInt32(doctorCB.SelectedValue);

                // enter day n time + schedule
                foreach (var day in dayCheckListBx.CheckedItems)
                {
                    SqlCommand cmdSchedule = conn.CreateCommand();

                    cmdSchedule.CommandText = @"
                        INSERT INTO doctorSchedule
                        (doctorID, day, startTime, endTime)
                        VALUES
                        (@doctorID, @day, @start, @end)";

                    cmdSchedule.Parameters.AddWithValue("@doctorID", doctorID);
                    cmdSchedule.Parameters.AddWithValue("@day", day.ToString());
                    cmdSchedule.Parameters.AddWithValue("@start", startDTP.Value.TimeOfDay);
                    cmdSchedule.Parameters.AddWithValue("@end", endDTP.Value.TimeOfDay);

                    cmdSchedule.ExecuteNonQuery();
                }

                MessageBox.Show("Schedule added successfully");

               
                availableRB.Checked = true;

                for (int i = 0; i < dayCheckListBx.Items.Count; i++)
                {
                    dayCheckListBx.SetItemChecked(i, false);
                }

                startDTP.Value = DateTime.Now;
                endDTP.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                LoadData();
            }
        }

       

        private void dayCheckListBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                int doctorID = Convert.ToInt32(doctorCB.SelectedValue);

                string status = availableRB.Checked ? "On Site" : "Off Site";

                SqlCommand cmdDoctor = conn.CreateCommand();

                cmdDoctor.CommandText = @"
                UPDATE doctor
                SET status = @status
                WHERE doctorID = @id";

                cmdDoctor.Parameters.AddWithValue("@status", status);
                cmdDoctor.Parameters.AddWithValue("@id", doctorID);

                cmdDoctor.ExecuteNonQuery();

                // delete old schedule
                SqlCommand cmdDelete = conn.CreateCommand();
                cmdDelete.CommandType = CommandType.Text;

                cmdDelete.CommandText = @"
                    DELETE FROM DoctorSchedule
                    WHERE doctorID = @id";

                cmdDelete.Parameters.AddWithValue("@id", doctorID);

                cmdDelete.ExecuteNonQuery();


                // 3. enter new schedule
                foreach (var day in dayCheckListBx.CheckedItems)
                {
                    SqlCommand cmdSchedule = conn.CreateCommand();

                    cmdSchedule.CommandText = @"
                         INSERT INTO doctorSchedule
                        (doctorID, day, startTime, endTime)
                         VALUES
                         (@doctorID, @day, @start, @end)";

                    cmdSchedule.Parameters.AddWithValue("@doctorID", doctorID);
                    cmdSchedule.Parameters.AddWithValue("@day", day.ToString());
                    cmdSchedule.Parameters.AddWithValue("@start", startDTP.Value.TimeOfDay);
                    cmdSchedule.Parameters.AddWithValue("@end", endDTP.Value.TimeOfDay);

                    cmdSchedule.ExecuteNonQuery();
                }

                MessageBox.Show("Schedule updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                LoadData();

                // clear form
                
                availableRB.Checked = true;

                for (int i = 0; i < dayCheckListBx.Items.Count; i++)
                {
                    dayCheckListBx.SetItemChecked(i, false);
                }

                startDTP.Value = DateTime.Now;
                endDTP.Value = DateTime.Now;
            }
        }

        private void scheduleDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDoctorID =
                Convert.ToInt32(scheduleDGV.CurrentRow.Cells["DoctorID"].Value);

                doctorCB.SelectedValue = selectedDoctorID;

            if (scheduleDGV.CurrentRow.Cells["Status"].Value.ToString() == "On Site")
                availableRB.Checked = true;
            else
                notAvailableRB.Checked = true;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (selectedDoctorID == 0)
            {
                MessageBox.Show("Please select a schedule first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this schedule?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            conn.Open();

            try
            {
                // delete schedule 
                SqlCommand cmdSchedule = conn.CreateCommand();
                cmdSchedule.CommandType = CommandType.Text;

                cmdSchedule.CommandText = @"
            DELETE FROM doctorSchedule
            WHERE doctorID = @id";

                cmdSchedule.Parameters.AddWithValue("@id", selectedDoctorID);
                cmdSchedule.ExecuteNonQuery();


                MessageBox.Show("Schedule deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                LoadData();

                // clear form

                availableRB.Checked = true;

                for (int i = 0; i < dayCheckListBx.Items.Count; i++)
                {
                    dayCheckListBx.SetItemChecked(i, false);
                }

                startDTP.Value = DateTime.Now;
                endDTP.Value = DateTime.Now;

                selectedDoctorID = 0;
            }
        }

        private void FormDoctorSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dentaNovaDataset.Doctor' table. You can move, or remove it, as needed.
            LoadDoctor();
            LoadData();
        }

        private void nextTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManageAppointment form2 = new FormManageAppointment();
            form2.ShowDialog();
            this.Close();
        }
    }
}
