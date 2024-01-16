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

namespace FastPassport.Forms
{
    public partial class ViewCargoProgressForms : Form
    {
        public ViewCargoProgressForms()
        {
            InitializeComponent();
            OfficerNameDisplay.Text = LoginPage.instance.txtUsername.Text;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true";
            DataTable cargoTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string cargoQuery = "SELECT * FROM Cargo";
                using (SqlCommand cargoCommand = new SqlCommand(cargoQuery, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cargoCommand);
                    adapter.Fill(cargoTable);

                    DataColumn applicantNameColumn = new DataColumn("Applicant Name", typeof(string));
                    DataColumn passportIDColumn = new DataColumn("Passport ID", typeof(string));
                    DataColumn urgentStatusColumn = new DataColumn("Urgent Status", typeof(bool));
                    cargoTable.Columns.Add(applicantNameColumn);
                    cargoTable.Columns.Add(passportIDColumn);
                    cargoTable.Columns.Add(urgentStatusColumn);

                    foreach (DataRow row in cargoTable.Rows)
                    {
                        string applicantId = row["ApplicantID"].ToString();
                        string applicantQuery = "SELECT Name, PassportID, Urgent FROM Applicant WHERE ApplicantID = @ID";
                        using (SqlCommand applicantCommand = new SqlCommand(applicantQuery, connection))
                        {
                            applicantCommand.Parameters.AddWithValue("@ID", applicantId);
                            SqlDataReader reader = applicantCommand.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                string applicantName = reader.GetString(0);
                                string passportID = reader.GetString(1);
                                bool urgentStatus = reader.GetBoolean(2);

                                row["Applicant Name"] = applicantName;
                                row["Passport ID"] = passportID;
                                row["Urgent Status"] = urgentStatus;
                            }
                            reader.Close();
                        }
                    }
                    connection.Close();
                }
            }

            dataGridView1.DataSource = cargoTable;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
            adminDashboardForm.Closed += (s, args) => this.Close();
            adminDashboardForm.Show();
        }

        private void ViewCargoProgressForms_Load(object sender, EventArgs e)
        {

        }
    }
}
