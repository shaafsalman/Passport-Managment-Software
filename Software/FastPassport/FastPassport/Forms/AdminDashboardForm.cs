using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastPassport.Forms
{
    //final
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {


        }

        private void ApplicantListButton_Click(object sender, EventArgs e)
        {
            ViewApplicantList viewApplicantList = new ViewApplicantList();
            viewApplicantList.Show();
            this.Hide();


        }

        private void AppointmentCalendar_Click(object sender, EventArgs e)
        {
            ViewAppointmentCalendar viewAppointmentCalendar = new ViewAppointmentCalendar();
            viewAppointmentCalendar.Show();
            this.Hide();
        }

        //private void ScheduleAppointmentButton_Click(object sender, EventArgs e)
        //{
        //    ScheduleAppointment scheduleAppointment = new ScheduleAppointment();
        //    scheduleAppointment.Show();
        //    this.Hide();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessAppointment processAppointment = new ProcessAppointment();
            processAppointment.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ViewCargoProgressForms viewCargoProgressForms = new ViewCargoProgressForms();
            viewCargoProgressForms.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Closed += (s, args) => this.Close();
            loginPage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            editInfo editInfo = new editInfo();
            editInfo.Show();
            this.Hide();
        }
    }
}
