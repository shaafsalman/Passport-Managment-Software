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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PassportManagmentOffice.Forms
{
    public partial class ProcessAppointment : Form
    {

        public ProcessAppointment()
        {

            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true"))
                {
                    conn.Open();
                    string query = "SELECT A.AppointmentID, A.ApplicantID, A.OfficerID, A.AppointmentDate, A.AppointmentTime, A.Status, B.Name " +
                                                    "FROM Appointment A " +
                                                    "INNER JOIN Applicant B ON A.ApplicantID = B.ApplicantID " +
                                                    "WHERE A.Status = 'Scheduled'";
                    SqlCommand cmd = new SqlCommand(query, conn);


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }




        public string GetApplicantName(string applicantID)
        {
            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true"; // Replace with your connection string

            string name = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name FROM Applicant WHERE ApplicantID = @applicantID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@applicantID", applicantID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    name = reader.GetString(0);
                }
            }

            return name;
        }

        public int GetNextCargoID()
        {
            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true"; // Replace with your connection string

            int nextID = 1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT MAX(CargoID) FROM Cargo";
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

        public bool UniqueApplicantCargo()
        {
            string ID = CNICDisplay.Text;
            string connectionString = "Data Source=SS-PAVILION;Database=PassportManagmentDB;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ApplicantID FROM Cargo WHERE ApplicantID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool UniqueApplicantAppointment()
        {
            string ID = CNICDisplay.Text;
            string connectionString = "Data Source=SS-PAVILION;Database=PassportManagmentDB;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ApplicantID FROM Appointment WHERE ApplicantID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        private void RejectButton_Click(object sender, EventArgs e)
        {
            string applicantID = CNICDisplay.Text;
            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true";
            string deleteAppointmentQuery = "DELETE FROM Appointment WHERE ApplicantID=@ApplicantID";
            string deleteApplicantQuery = "DELETE FROM Applicant WHERE ApplicantID=@ApplicantID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Delete the appointment for the given applicant ID
                using (SqlCommand command = new SqlCommand(deleteAppointmentQuery, connection))
                {
                    command.Parameters.AddWithValue("@ApplicantID", applicantID);
                    command.ExecuteNonQuery();
                }

                // Delete the applicant for the given applicant ID
                using (SqlCommand command = new SqlCommand(deleteApplicantQuery, connection))
                {
                    command.Parameters.AddWithValue("@ApplicantID", applicantID);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        private void ProcessAppointment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)


        {

            string applicantId = IDtextBox.Text; // replace with actual applicant ID
            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name,ApplicantID FROM Applicant WHERE ApplicantID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", applicantId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        nameDisplay.Text = reader.GetString(0);
                        CNICDisplay.Text = reader.GetString(1);
                    }


                    reader.Close();
                    connection.Close();
                }
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SS-PAVILION;Database=PassportManagmentDB;Trusted_Connection=True;";

            string applicantID = CNICDisplay.Text;

            if (UniqueApplicantAppointment())
            {
                string status = "Completed";

                string updateQuery = "UPDATE Appointment SET Status = @Status WHERE ApplicantID = @applicantID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@applicantID", applicantID);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                bool isUrgent = true;
                if (GetPassportStatus(applicantID) == "Regular")
                {
                    isUrgent = false;
                }

                DateTime appointmentDate = DateTime.MinValue;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT AppointmentDate FROM Appointment WHERE ApplicantID = @ApplicantID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicantID", applicantID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                appointmentDate = reader.GetDateTime(0);
                            }
                        }
                    }
                }

                DateTime DepartureDate = isUrgent ? DateTime.Today.AddDays(3) : DateTime.Today.AddDays(7);
                if (UniqueApplicantCargo())
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO Cargo (CargoID, ApplicantID, DepartureDate) VALUES (@CargoID, @ApplicantID, @DepartureDate)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            string cargoID = Guid.NewGuid().ToString();
                            command.Parameters.AddWithValue("@CargoID", GetNextCargoID());
                            command.Parameters.AddWithValue("@ApplicantID", applicantID);
                            command.Parameters.AddWithValue("@DepartureDate", DepartureDate);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }
                }

            }



        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
            adminDashboardForm.Closed += (s, args) => this.Close();
            adminDashboardForm.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                CNICDisplay.Text = row.Cells["ApplicantID"].Value.ToString();
                string ID = row.Cells["ApplicantID"].Value.ToString();
                nameDisplay.Text = GetApplicantName(ID);
            }
        }
    }
}
