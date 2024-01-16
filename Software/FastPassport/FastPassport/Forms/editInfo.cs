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
using FastPassport.Controller;

namespace FastPassport.Forms
{
    public partial class editInfo : Form
    {
        adminController controller;
        public editInfo()
        {
            InitializeComponent();
            controller = new adminController();
        }

        private void editInfo_Load(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }

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
                bool isUploadSuccessful = controller.UploadApplicantImage(applicantID.Text, pictureBox.Image);

                if (isUploadSuccessful)
                {
                    MessageBox.Show("Image uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to upload image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //private void SubmitButton_Click(object sender, EventArgs e)
        //{
        //    if (pictureBox.Image == null)
        //    {
        //        MessageBox.Show("Please select an image to upload.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    try
        //    {
        //        // Convert the image to byte array for storage in the database
        //        byte[] imageData = null;
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //            imageData = ms.ToArray();
        //        }

        //        // Update the applicant's record in the database with the uploaded image
        //        string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true";
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            string updateQuery = "UPDATE Applicant SET Photo = @Photo WHERE ApplicantID = @ApplicantID";
        //            SqlCommand command = new SqlCommand(updateQuery, connection);
        //            command.Parameters.AddWithValue("@Photo", imageData);
        //            command.Parameters.AddWithValue("@ApplicantID", applicantID.Text);
        //            int rowsAffected = command.ExecuteNonQuery();

        //            if (rowsAffected > 0)
        //            {
        //                MessageBox.Show("Image uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                this.Close();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Failed to upload image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error uploading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
