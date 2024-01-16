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
using static System.Resources.ResXFileRef;

namespace PassportManagmentOffice.Forms
{
    public partial class ViewAppointmentCalendar : Form
    {
        string officerID = "000001";
        public ViewAppointmentCalendar()
        {
            InitializeComponent();

            LoadAppointments();
        }
        private void LoadAppointments()
        {
            using (SqlConnection conn = new SqlConnection("Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true"))
            {
                conn.Open();
                string query = "SELECT AppointmentID, Applicant.Name, Applicant.ApplicantID, AppointmentDate, AppointmentTime, Status " +
                               "FROM Appointment " +
                               "INNER JOIN Applicant ON Appointment.ApplicantID = Applicant.ApplicantID " +
                                "ORDER BY AppointmentDate, AppointmentTime";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OfficerID", officerID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                appointmentsDataGridView.DataSource = dt;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (appointmentsDataGridView.Columns[e.ColumnIndex].Name == "ViewButtonColumn" && e.RowIndex >= 0)
            {
                int appointmentID = Convert.ToInt32(appointmentsDataGridView.Rows[e.RowIndex].Cells["AppointmentID"].Value);

                using (SqlConnection conn = new SqlConnection("Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true"))
                {
                    conn.Open();
                    string query = "SELECT Photo FROM Applicant WHERE ApplicantID = (SELECT ApplicantID FROM Appointment WHERE AppointmentID = @AppointmentID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);


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
    }
}
