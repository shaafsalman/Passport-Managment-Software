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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PassportManagmentOffice.Forms
{
    //final
    public partial class AdultPassportPortalForm : Form
    {

        public AdultPassportPortalForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            string GeneratePassportNumber()
            {
                string prefix = "PK";
                string date = DateTime.Now.ToString("yyMMdd");
                string uniqueNumber = "";
                Random rnd = new Random();

                // generate a unique 6-digit number


                // concatenate the parts to form the passport number
                string passportNumber = prefix + date + uniqueNumber;
                return passportNumber;
            }
            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true"; ;
            SqlConnection connection = new SqlConnection(connectionString);

            // Get the input data for the new applicant
            string CNIC = BayformtextBox.Text;
            string name = FirstNameInput.Text + " " + LastNameInput.Text;
            string address = AddressInput.Text;
            string phone = GaurdianPhoneNumberInput.Text;
            string email = GaurdianEmailInput.Text;
            DateTime dob = DOBInput.Value;
            string PassportID = GeneratePassportNumber();
            string ApplicationStatus = "UnVerified";

            string gender = "";
            int pages = 0;
            if (checkBoxMale.Checked)
            {
                gender = "Male";
            }
            else if (checkBoxFemale.Checked)
            {
                gender = "Female";
            }
            if (checkBox36.Checked == true)
                pages += 36;
            if (checkBox72.Checked == true)
                pages += 72;
            if (checkBox100.Checked == true)
                pages += 100;

            bool urgent = false;

            if (CheckboxUrgent.Checked)
            {
                urgent = true;
            }
            int years = 5;

            if (checkBox10.Checked)
            {
                years = 10;
            }

            // Insert the new applicant's data into the Applicant table
            string insertQuery = "INSERT INTO Applicant (ApplicantID, Name, Address, Phone, Email, DateOfBirth, Gender, IsChild, FatherName, MothersName, FatherID, MotherID, Pages,ValidityPeriod,PassportID,ApplicationStatus,PaymentStatus,Urgent) VALUES (@ApplicantID, @Name, @Address, @Phone, @Email, @DateOfBirth, @Gender, @IsChild, @FatherName, @MothersName, @FatherID, @MotherID, @Pages,@ValidityPeriod,@PassportID,@ApplicationStatus,@PaymentStatus,@Urgent)";
            SqlCommand command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@ApplicantID", CNIC);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@DateOfBirth", dob);
            command.Parameters.AddWithValue("@Gender", gender);
            command.Parameters.AddWithValue("@IsChild", false);
            command.Parameters.AddWithValue("@FatherName", "");
            command.Parameters.AddWithValue("@MothersName", "");
            command.Parameters.AddWithValue("@FatherID", "");
            command.Parameters.AddWithValue("@MotherID", "");
            command.Parameters.AddWithValue("@Pages", pages);
            command.Parameters.AddWithValue("@ValidityPeriod", years);
            command.Parameters.AddWithValue("@PassportID", PassportID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@PaymentStatus", false);
            command.Parameters.AddWithValue("@Urgent", urgent);




            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            static double CalculatePassportCost(int pages, int validityPeriod, bool isUrgent)
            {
                double baseCost = 100;
                double pageCost = 50;
                double urgentCost = 5000;
                double tenYearCost = 5000;

                double totalCost = baseCost + (pages * pageCost);

                if (validityPeriod == 10)
                {
                    totalCost += tenYearCost;
                }

                if (isUrgent)
                {
                    totalCost += urgentCost;
                }

                return totalCost;
            }





            double cost = CalculatePassportCost(pages, years, urgent);

            // Create a message to show the applicant
            string message = string.Format("Your passport application has been submitted.\n\n" +
                "Passport ID: {0}\n" +
                "Number of Pages: {1}\n" +
                "Validity Period: {2} Years\n" +
                "Urgent: {3}\n\n" +
                "Cost: PKR: {4}", PassportID, pages, years, urgent ? "Pay" : "Cancel", cost);

            // Show the message to the applicant
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, "Passport Application", buttons);

            // If the applicant clicks "Pay", update the payment status in the database
            if (result == DialogResult.OK)
            {
                string updateQuery = "UPDATE Applicant SET PaymentStatus = @PaymentStatus WHERE ApplicantID = @ApplicantID";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@PaymentStatus", true);
                updateCommand.Parameters.AddWithValue("@ApplicantID", CNIC);

                connection.Open();
                updateCommand.ExecuteNonQuery();
                connection.Close();

                var uploadPictureForm = new UploadPictureForm(CNIC);
                uploadPictureForm.ShowDialog();
                this.Hide();


                // Display success message
                MessageBox.Show("Your passport application has been submitted successfully. Thank you!");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicantDashboardForm applicantDashboardForm = new ApplicantDashboardForm();
            applicantDashboardForm.Closed += (s, args) => this.Close();
            applicantDashboardForm.Show();
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
