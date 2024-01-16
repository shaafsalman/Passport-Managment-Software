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
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace PassportManagmentOffice.Forms
{
    public partial class ViewApplicationStatus : Form
    {
        public ViewApplicationStatus()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            string applicantId = IDtextBox.Text; // replace with actual applicant ID
            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, ApplicationStatus,Photo FROM Applicant WHERE ApplicantID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", applicantId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string applicantName = reader.GetString(0);
                        string applicationStatus = reader.GetString(1);



                        if (!Convert.IsDBNull(reader["Photo"]))
                        {

                            byte[] imageBytes = (byte[])reader["Photo"];

                            if (imageBytes != null)
                            {
                                using (MemoryStream stream = new MemoryStream(imageBytes))
                                {
                                    Image photo = Image.FromStream(stream);
                                    pictureBox1.Image = photo;
                                }
                            }
                        }


                        // Display the applicant's name and application status




                        DisplayApplicant.Text = applicantName;
                        DisplayVerification.Text = applicationStatus;

                        if (applicationStatus == "Details Verified")
                        {
                            progressBar1.Value = 30;
                        }
                    }


                    reader.Close();
                    connection.Close();
                }
            }

            // Get the applicant's appointment details
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Status, AppointmentDate, AppointmentTime FROM Appointment WHERE ApplicantID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", applicantId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        String status = reader.GetString(0);
                        DateTime appointmentDate = reader.GetDateTime(1);
                        TimeSpan appointmentTime = reader.GetTimeSpan(2);

                        // Display the appointment details
                        DisplayAppointmentStatus.Text = status;
                        DisplayAppointmentDate.Text = appointmentDate.ToString("MM/dd/yyyy") + " " + appointmentTime.ToString("hh\\:mm");
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string ID = IDtextBox.Text;
                string query = "SELECT DepartureDate FROM Cargo WHERE ApplicantID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", applicantId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        DateTime deliveryDate = reader.GetDateTime(0);

                        // Display the delivery date on the label
                        deliverystatusDisplay.Text = "In Process";
                        deliverydatedisplay.Text = deliveryDate.ToString("MM/dd/yyyy");
                        progressBar1.Value = 70;

                    }
                    else
                    {
                        deliverystatusDisplay.Text = "Has to be Dispatched";
                        deliverydatedisplay.Text = "-";
                        progressBar1.Value = 50;
                    }
                    reader.Close();
                    connection.Close();
                }
            }

        }

        private void DisplayAppointmentStatus_Click(object sender, EventArgs e)
        {

        }

        private void DisplayVerification_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayApplicant_Click(object sender, EventArgs e)
        {

        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicantDashboardForm applicantDashboardForm = new ApplicantDashboardForm();
            applicantDashboardForm.Closed += (s, args) => this.Close();
            applicantDashboardForm.Show();

        }
    }
}
