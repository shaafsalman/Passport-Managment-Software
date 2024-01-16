using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastPassport.Forms
{
    public partial class ViewApplicantList : Form
    {
        public ViewApplicantList()
        {
            InitializeComponent();

            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true";

            string query = "SELECT * FROM Applicant ORDER BY ApplicationStatus ASC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void ViewApplicantList_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            byte[] image = row.Cells[12].Value as byte[];



            //if (e.ColumnIndex == 12 && e.RowIndex != -1)
            //{

            string ID = row.Cells[0].Value as string;

            //if (image != null)
            //{
            ImageForm form = new ImageForm(ID);
            if (image != null)
            {
                Image byteArrayToImage(byte[] byteArrayIn)
                {
                    MemoryStream ms = new MemoryStream(byteArrayIn);
                    Image returnImage = Image.FromStream(ms);
                    return returnImage;
                }
                form.pictureBox1.Image = byteArrayToImage(image);
            }


            form.nameDisplay.Text = row.Cells[1].Value as string;
            form.CNICDisplay.Text = row.Cells[0].Value as string;
            form.StatusDisplay.Text = row.Cells[14].Value as string;
            form.Show();


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
