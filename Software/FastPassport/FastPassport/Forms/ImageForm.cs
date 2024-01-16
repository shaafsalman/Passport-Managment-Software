using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FastPassport.Forms
{
    public partial class ImageForm : Form
    {
        private string applicantId;

        public ImageForm(string id)
        {
            InitializeComponent();



        }


        public string GetPassportStatus(string applicantID)
        {
            string status = "";
            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Urgent FROM Applicant WHERE ApplicantID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", applicantID);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        bool isUrgent = (bool)reader["Urgent"];
                        status = isUrgent ? "Urgent" : "Regular";
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            return status;
        }

        public static Random random = new Random();

        DateTime appointmentTime()
        {
            int minutes = random.Next(0, 60);
            int hours = random.Next(9, 17);
            int daysToAdd = 0;

            // If it's after 5pm, add the remaining time until 5pm to the daysToAdd variable
            if (hours == 17 && minutes >= 1)
            {
                daysToAdd += 1;
            }

            // Calculate the next working day if today is not a working day
            while ((int)DateTime.Now.AddDays(daysToAdd).DayOfWeek == 0 || (int)DateTime.Now.AddDays(daysToAdd).DayOfWeek == 6)
            {
                daysToAdd += 1;
            }

            DateTime randomDate = DateTime.Now.AddDays(daysToAdd);
            return randomDate.Date.AddHours(hours).AddMinutes(minutes);
        }

        public int GetNextAppointmentID()
        {
            int nextID = 1;
            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true"; // Replace with your connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT MAX(AppointmentID) FROM Appointment";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        nextID = Convert.ToInt32(result) + 1;
                    }
                }
            }
            return nextID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Update the status of the applicant in the database
            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string id = CNICDisplay.Text;
                string query = "UPDATE Applicant SET ApplicationStatus = 'Details Verified' WHERE ApplicantID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        // Check the application type to determine appointment date
                        DateTime appointmentDate;
                        if (GetPassportStatus(id) == "Regular")
                        {
                            appointmentDate = DateTime.Today.AddDays(14); // Add 14 days for regular application
                            while (appointmentDate.DayOfWeek == DayOfWeek.Saturday || appointmentDate.DayOfWeek == DayOfWeek.Sunday)
                            {
                                appointmentDate = appointmentDate.AddDays(1); // Skip weekends
                            }
                        }
                        else // Urgent application
                        {
                            appointmentDate = DateTime.Today.AddDays(5); // Add 5 days for urgent application
                            while (appointmentDate.DayOfWeek == DayOfWeek.Saturday || appointmentDate.DayOfWeek == DayOfWeek.Sunday)
                            {
                                appointmentDate = appointmentDate.AddDays(1); // Skip weekends
                            }
                        }
                        DateTime time = appointmentTime();
                        // Add entry to appointment table
                        query = "INSERT INTO Appointment (AppointmentID,ApplicantID,OfficerID, AppointmentDate,AppointmentTime,Status) VALUES (@AppointmentID,@ApplicantID,@OfficerID, @AppointmentDate,@AppointmentTime,@Status)";
                        using (SqlCommand appointmentCommand = new SqlCommand(query, connection))
                        {
                            appointmentCommand.Parameters.AddWithValue("@AppointmentID", GetNextAppointmentID());
                            appointmentCommand.Parameters.AddWithValue("@ApplicantID", id);
                            appointmentCommand.Parameters.AddWithValue("@OfficerID", "O0001");
                            appointmentCommand.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                            appointmentCommand.Parameters.AddWithValue("@AppointmentTime", time);
                            appointmentCommand.Parameters.AddWithValue("@Status", "Scheduled");

                            connection.Open();
                            rowsAffected = appointmentCommand.ExecuteNonQuery();
                            connection.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Application status updated successfully. Appointment scheduled for " + appointmentDate.ToString("dd/MM/yyyy") + time);
                            }
                            else
                            {
                                MessageBox.Show("Failed to schedule appointment.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to update application status.");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string id = CNICDisplay.Text;
            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true";
            string query = "DELETE FROM Applicant WHERE ApplicantID = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Application rejected and deleted!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicantDashboardForm applicantDashboardForm = new ApplicantDashboardForm();
            applicantDashboardForm.Closed += (s, args) => this.Close();
            applicantDashboardForm.Show();
        }
    }
}
