namespace FastPassport.Forms
{
    partial class AdminDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ApplicantListButton = new Button();
            AppointmentCalendar = new Button();
            ProcessInterviewButton = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ApplicantListButton
            // 
            ApplicantListButton.Location = new Point(78, 294);
            ApplicantListButton.Name = "ApplicantListButton";
            ApplicantListButton.Size = new Size(302, 51);
            ApplicantListButton.TabIndex = 0;
            ApplicantListButton.Text = "View Applicant List";
            ApplicantListButton.UseVisualStyleBackColor = true;
            ApplicantListButton.Click += ApplicantListButton_Click;
            // 
            // AppointmentCalendar
            // 
            AppointmentCalendar.Location = new Point(78, 364);
            AppointmentCalendar.Name = "AppointmentCalendar";
            AppointmentCalendar.Size = new Size(302, 51);
            AppointmentCalendar.TabIndex = 1;
            AppointmentCalendar.Text = "View Appointment Calendar";
            AppointmentCalendar.UseVisualStyleBackColor = true;
            AppointmentCalendar.Click += AppointmentCalendar_Click;
            // 
            // ProcessInterviewButton
            // 
            ProcessInterviewButton.Location = new Point(426, 294);
            ProcessInterviewButton.Name = "ProcessInterviewButton";
            ProcessInterviewButton.Size = new Size(302, 51);
            ProcessInterviewButton.TabIndex = 2;
            ProcessInterviewButton.Text = "Process Interview";
            ProcessInterviewButton.UseVisualStyleBackColor = true;
            ProcessInterviewButton.Click += button1_Click;
            // 
            // pictureBox1
            // 
            //pictureBox1.Image = Properties.Resources.NADRA_logo;
            //pictureBox1.Location = new Point(285, 12);
            //pictureBox1.Name = "pictureBox1";
            //pictureBox1.Size = new Size(217, 210);
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox1.TabIndex = 5;
            //pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(426, 363);
            button1.Name = "button1";
            button1.Size = new Size(302, 51);
            button1.TabIndex = 6;
            button1.Text = "View Cargo Progress";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(703, 12);
            button2.Name = "button2";
            button2.Size = new Size(85, 29);
            button2.TabIndex = 7;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(85, 29);
            button3.TabIndex = 8;
            button3.Text = "edit Info";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(ProcessInterviewButton);
            Controls.Add(AppointmentCalendar);
            Controls.Add(ApplicantListButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ApplicantListButton;
        private Button AppointmentCalendar;
        private Button ProcessInterviewButton;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}