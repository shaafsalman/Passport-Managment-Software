using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PassportManagmentOffice.Forms
{
    public partial class RenewPassport : Form
    {
        public RenewPassport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true";
            SqlConnection connection = new SqlConnection(connectionString);

            string sqlQuery = "DELETE FROM Applicant WHERE ApplicantID=@id";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@id", CNICDisplay.Text);

            try
            {
                // Open the connection
                connection.Open();

                // Execute the query to delete the tuple
                int rowsAffected = command.ExecuteNonQuery();

                // Display a message to the user with the number of rows affected
                MessageBox.Show($"{rowsAffected} row(s) deleted.");

                // Close the connection
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting tuple: " + ex.Message);
            }


            AdultPassportPortalForm adultPassportPortalForm = new AdultPassportPortalForm();
            adultPassportPortalForm.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            DateTime newExpirationDate = DateTime.Today.AddYears(10);
            MessageBox.Show($"Applicant {nameDisplay.Text} with CNIC {CNICDisplay.Text}  with PassportID {PassportNumberDisplay.Text} has been extended to {newExpirationDate.ToString("dd/MM/yyyy")}.");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true";
            SqlConnection connection = new SqlConnection(connectionString);



            // Set up the SQL query to retrieve the data
            string sqlQuery = "SELECT Name, PassportID FROM applicant WHERE ApplicantID=@id";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@id", IDtextBox.Text);

            // Create a command object with the query and the connection

            try
            {
                // Open the connection
                connection.Open();

                // Execute the query and get the data
                SqlDataReader reader = command.ExecuteReader();

                // Display the data in the text box
                while (reader.Read())
                {
                    nameDisplay.Text = reader["Name"].ToString() + Environment.NewLine;
                    CNICDisplay.Text = IDtextBox.Text;
                    PassportNumberDisplay.Text = reader["PassportID"].ToString() + Environment.NewLine + Environment.NewLine;
                }

                // Close the reader and the connection
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }









        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicantDashboardForm applicantDashboardForm = new ApplicantDashboardForm();
            applicantDashboardForm.Closed += (s, args) => this.Close();
            applicantDashboardForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PassportNumberDisplay_Click(object sender, EventArgs e)
        {
        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void CNICDisplay_Click(object sender, EventArgs e)
        {
        }

        private void nameDisplay_Click(object sender, EventArgs e)
        {
        }

        private void ApplicantCnicheader_Click(object sender, EventArgs e)
        {
        }

        private void ApplicantNameHeader_Click(object sender, EventArgs e)
        {
        }
    }
}
