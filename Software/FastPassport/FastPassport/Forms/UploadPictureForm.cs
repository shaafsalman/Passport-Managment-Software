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

namespace FastPassport.Forms
{
    public partial class UploadPictureForm : Form
    {
        private SqlConnection connection;
        private string applicantID;

        public UploadPictureForm(string CNIC)
        {
            InitializeComponent();
            this.applicantID = CNIC;

        }
        private byte[] imageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }

            //string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true";
            //string updateQuery = "UPDATE Applicant SET Photo = @Photo WHERE ApplicantID = @ApplicantID";
            //SqlCommand command = new SqlCommand(updateQuery, connection);
            //command.Parameters.AddWithValue("@Photo", imageToByteArray(pictureBox.Image));
            //command.Parameters.AddWithValue("@ApplicantID", applicantID);

            //connection.Open();
            //command.ExecuteNonQuery();
            //connection.Close();

            //// Close the form after the picture has been uploaded
            //this.Close();


        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Please select an image to upload.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Convert the image to byte array for storage in the database
                byte[] imageData = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageData = ms.ToArray();
                }

                // Update the applicant's record in the database with the uploaded image
                string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Applicant SET Photo = @Photo WHERE ApplicantID = @ApplicantID";
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@Photo", imageData);
                    command.Parameters.AddWithValue("@ApplicantID", applicantID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Image uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to upload image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
