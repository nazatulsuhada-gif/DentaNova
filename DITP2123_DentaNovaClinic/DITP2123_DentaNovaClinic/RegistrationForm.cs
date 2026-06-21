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
using DITP2123_DentaNovaClinic;

namespace edpProject1._0
{
    public partial class RegistrationForm : Form
    {
        SqlConnection connection = new SqlConnection(
        @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\HP\OneDrive - Universiti Teknikal Malaysia Melaka\edpProject-haifa\haifa-Registration Form - Copy\edpProject1.0\edpProject1.0\PatientDB.mdf;
        Integrated Security=True;
        Connect Timeout=30");

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // CHECK EMPTY
            if (textBoxFirstName.Text.Trim() == "" ||
                textBoxLastName.Text.Trim() == "" ||
                textBoxPhoneNumber.Text.Trim() == "" ||
                textBoxEmail.Text.Trim() == "" ||
                textBoxPassword.Text.Trim() == "" ||
                textBoxConfirmPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            // CHECK PASSWORD MATCH
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match!");
                return;
            }

            try
            {
                connection.Open();

                // CHECK DUPLICATE EMAIL
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Patient WHERE Email=@email", connection);

                checkCmd.Parameters.AddWithValue("@email", textBoxEmail.Text.Trim());

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Email already exists!");
                    connection.Close();
                    return;
                }

                // INSERT DATA
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Patient (FirstName, LastName, PhoneNumber, Email, Password) " +
                    "VALUES (@fn, @ln, @phone, @email, @pw)", connection);

                cmd.Parameters.AddWithValue("@fn", textBoxFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@ln", textBoxLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", textBoxPhoneNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@email", textBoxEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@pw", textBoxPassword.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account Created Successfully!");

                // CLEAR FORM
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                textBoxPhoneNumber.Clear();
                textBoxEmail.Clear();
                textBoxPassword.Clear();
                textBoxConfirmPassword.Clear();

                // GO TO LOGIN FORM
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
