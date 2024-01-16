using Microsoft.VisualBasic.ApplicationServices;
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

namespace PassportManagmentOffice.Forms
{
    public partial class SighnUp : Form
    {
        private readonly string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true";// Replace with your own connection string

        public SighnUp()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string userId = CNICInput.Text;
            string username = UseernameInput.Text;
            string password = PasswordInput.Text;
            string usertype = "Applicant";

            //string query = $"UPDATE Login SET Username = '{username}', Password = '{password}' WHERE UserID = {userId};";
            string query = "INSERT INTO Login (UserID, Username, Password,Type) VALUES (@userId,@username, @password,@usertype)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", userId);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@UserType", usertype);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Login details updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating login details: {ex.Message}");
                }
            }
        }

        private void SighnUp_Load(object sender, EventArgs e)
        {

        }

        private void IDHeader_Click(object sender, EventArgs e)
        {

        }

        private void CNICInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void UsernameHeader_Click(object sender, EventArgs e)
        {
        }

        private void UseernameInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordHeader_Click(object sender, EventArgs e)
        {
        }

        private void RegisterTittle_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage LoginPage = new LoginPage();
            LoginPage.Show();
            this.Hide();
        }
    }
}
