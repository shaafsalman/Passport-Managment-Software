using System;
using System.CodeDom;
using System.Data.SqlClient;
using FastPassport.Config;

namespace FastPassport.Controller
{
    class adminController
    {
        private string connectionString;
        private SqlConnection connection;

        public adminController()
        {
            ConnectionFile connectionFile = new ConnectionFile();
            connectionString = connectionFile.getConnectionString();
            connection = new SqlConnection(connectionString);
        }

        public string GeneratePassportNumber()
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

        public void InsertApplicant(string CNIC, string name, string address, string phone, string email,
         DateTime dob, string gender, int pages, int validityPeriod, bool urgent)
        {
            string type = "normal";
            if (urgent)
            {
                type = "urgent";
            }
            

            // Insert the new applicant's data into the Applicant table
            string insertApplicantQuery = @"
        INSERT INTO Applicant (ApplicantID, Name, Address, Phone, Email, DateOfBirth, Gender, IsChild, AdultGuardianID, FatherID, MotherID)
        VALUES (@ApplicantID, @Name, @Address, @Phone, @Email, @DateOfBirth, @Gender, @IsChild, @AdultGuardianID, @FatherID, @MotherID)";

            SqlCommand applicantCommand = new SqlCommand(insertApplicantQuery, connection);
            applicantCommand.Parameters.AddWithValue("@ApplicantID", CNIC);
            applicantCommand.Parameters.AddWithValue("@Name", name);
            applicantCommand.Parameters.AddWithValue("@Address", address);
            applicantCommand.Parameters.AddWithValue("@Phone", phone);
            applicantCommand.Parameters.AddWithValue("@Email", email);
            applicantCommand.Parameters.AddWithValue("@DateOfBirth", dob);
            applicantCommand.Parameters.AddWithValue("@Gender", gender);
            applicantCommand.Parameters.AddWithValue("@IsChild", false);
            applicantCommand.Parameters.AddWithValue("@AdultGuardianID", DBNull.Value); // Set to actual value if applicable
            applicantCommand.Parameters.AddWithValue("@FatherID", DBNull.Value); // Set to actual value if applicable
            applicantCommand.Parameters.AddWithValue("@MotherID", DBNull.Value); // Set to actual value if applicable
            

            connection.Open();
            applicantCommand.ExecuteNonQuery();

            // Insert the new applicant's data into the PassportType table
            string insertPassportTypeQuery = @"
        INSERT INTO PassportType (PassportTypeID, ApplicantID, Type, ValidityPeriod, Pages)
        VALUES (@PassportTypeID, @ApplicantID, @Type, @ValidityPeriod, @Pages)";

            SqlCommand passportTypeCommand = new SqlCommand(insertPassportTypeQuery, connection);
            passportTypeCommand.Parameters.AddWithValue("@PassportTypeID", GeneratePassportNumber());
            passportTypeCommand.Parameters.AddWithValue("@ApplicantID", CNIC);
            passportTypeCommand.Parameters.AddWithValue("@Type", type); 
            passportTypeCommand.Parameters.AddWithValue("@ValidityPeriod", validityPeriod);
            passportTypeCommand.Parameters.AddWithValue("@Pages", pages);

            passportTypeCommand.ExecuteNonQuery();

        //    // Insert the new applicant's data into the PassportApplication table
        //    string insertPassportApplicationQuery = @"
        //INSERT INTO PassportApplication (ApplicationID, ApplicantID, PassportTypeID, ApplicationDate, Status)
        //VALUES (@ApplicationID, @ApplicantID, @PassportTypeID, @ApplicationDate, @Status)";

        //    SqlCommand passportApplicationCommand = new SqlCommand(insertPassportApplicationQuery, connection);
        //    passportApplicationCommand.Parameters.AddWithValue("@ApplicationID", 1); // You may set the ApplicationID accordingly
        //    passportApplicationCommand.Parameters.AddWithValue("@ApplicantID", CNIC);
        //    passportApplicationCommand.Parameters.AddWithValue("@PassportTypeID", GeneratePassportNumber());
        //    passportApplicationCommand.Parameters.AddWithValue("@ApplicationDate", DateTime.Now); // Set to actual value
        //    passportApplicationCommand.Parameters.AddWithValue("@Status", "UnVerified"); // Set to actual value

        //    passportApplicationCommand.ExecuteNonQuery();

             connection.Close();
        //}
    }


        public string InsertChildApplicant(string bayform, string name, string address, string phone, string email,
            DateTime dob, string gender, string fatherName, string motherName, string fatherCNIC, string motherCNIC,
            int pages, int validityPeriod, bool urgent)
        {
            string passportID = GeneratePassportNumber();

            string type = "normal";
            if (urgent)
            {
                type = "urgent";
            }

            string insertQuery = "INSERT INTO Applicant (ApplicantID, Name, Address, Phone, Email, DateOfBirth, Gender, IsChild, FatherName, MothersName, FatherID, MotherID) " +
                "VALUES (@ApplicantID, @Name, @Address, @Phone, @Email, @DateOfBirth, @Gender, @IsChild, @FatherName, @MothersName, @FatherID, @MotherID)";

            SqlCommand command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@ApplicantID", bayform);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@DateOfBirth", dob);
            command.Parameters.AddWithValue("@Gender", gender);
            command.Parameters.AddWithValue("@IsChild", true);
            command.Parameters.AddWithValue("@FatherName", fatherName);
            command.Parameters.AddWithValue("@MothersName", motherName);
            command.Parameters.AddWithValue("@FatherID", fatherCNIC);
            command.Parameters.AddWithValue("@MotherID", motherCNIC);
            
            connection.Open();
            command.ExecuteNonQuery();
            // Insert the new applicant's data into the PassportType table
            string insertPassportTypeQuery = @"
        INSERT INTO PassportType (PassportTypeID, ApplicantID, Type, ValidityPeriod, Pages)
        VALUES (@PassportTypeID, @ApplicantID, @Type, @ValidityPeriod, @Pages)";

            SqlCommand passportTypeCommand = new SqlCommand(insertPassportTypeQuery, connection);
            passportTypeCommand.Parameters.AddWithValue("@PassportTypeID", GeneratePassportNumber());
            passportTypeCommand.Parameters.AddWithValue("@ApplicantID", bayform);
            passportTypeCommand.Parameters.AddWithValue("@Type", type);
            passportTypeCommand.Parameters.AddWithValue("@ValidityPeriod", validityPeriod);
            passportTypeCommand.Parameters.AddWithValue("@Pages", pages);

            passportTypeCommand.ExecuteNonQuery();


            connection.Close();

            return passportID;
        }
        public void UpdatePaymentStatus(string CNIC, bool status)
        {
            string updateQuery = "UPDATE Applicant SET PaymentStatus = @PaymentStatus WHERE ApplicantID = @ApplicantID";
            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@PaymentStatus", status);
            updateCommand.Parameters.AddWithValue("@ApplicantID", CNIC);

            connection.Open();
            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        public double CalculatePassportCost(int pages, int validityPeriod, bool isUrgent)
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
    }
}
