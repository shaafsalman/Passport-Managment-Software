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
using FastPassport.Forms;
using FastPassport.Config;

namespace FastPassport
{
    public partial class LoginPage : Form
    {

        public static LoginPage instance;
        private readonly ConnectionFile connectionFile = new ConnectionFile();


        private readonly string connectionString;

        public LoginPage()
        {
            InitializeComponent();
            instance = this;
            ConnectionFile connectionFile = new ConnectionFile();
            connectionString = connectionFile.getConnectionString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public string UsernameData { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userType = "";

            UsernameData = username;


            string loginQuery = $"SELECT COUNT(*) FROM Login WHERE Username = '{username}' AND Password = '{password}'";
            string userTypeQuery = $"SELECT Type FROM Login WHERE Username = '{username}' AND Password = '{password}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand loginCommand = new SqlCommand(loginQuery, connection);
                SqlCommand userTypeCommand = new SqlCommand(userTypeQuery, connection);
                connection.Open();

                int count = (int)loginCommand.ExecuteScalar();

                if (count == 1)
                {
                    MessageBox.Show("Successful");
                    SqlDataReader userTypeReader = userTypeCommand.ExecuteReader();

                    while (userTypeReader.Read())
                    {
                        userType = userTypeReader.GetString(0);

                    }

                    userTypeReader.Close();

                    if (userType == "applicant")
                    {
                        MessageBox.Show("Welcome Applicant!");
                        ApplicantDashboardForm applicantDashboardForm = new ApplicantDashboardForm();
                        applicantDashboardForm.Show();
                        this.Hide();
                    }

                    else if (userType == "Officer")
                    {
                        MessageBox.Show("Welcome Officer!");
                        AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
                        adminDashboardForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SighnUp SighnUp = new SighnUp();
            SighnUp.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
