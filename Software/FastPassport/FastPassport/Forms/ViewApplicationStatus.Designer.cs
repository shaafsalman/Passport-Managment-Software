namespace FastPassport.Forms
{
    partial class ViewApplicationStatus
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
            label13 = new Label();
            label12 = new Label();
            progressBar1 = new ProgressBar();
            DisplayAppointmentDate = new Label();
            label11 = new Label();
            deliverystatusDisplay = new Label();
            label9 = new Label();
            DisplayButton = new Button();
            DisplayAppointmentStatus = new Label();
            label7 = new Label();
            IDtextBox = new TextBox();
            pictureBox1 = new PictureBox();
            DisplayVerification = new Label();
            label5 = new Label();
            label4 = new Label();
            DisplayApplicant = new Label();
            label1 = new Label();
            BackButton = new Button();
            deliverydatedisplay = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(488, 9);
            label13.Name = "label13";
            label13.Size = new Size(100, 32);
            label13.TabIndex = 50;
            label13.Text = "Details";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(384, 373);
            label12.Name = "label12";
            label12.Size = new Size(68, 18);
            label12.TabIndex = 49;
            label12.Text = "Progress";
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Green;
            progressBar1.Location = new Point(384, 394);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(404, 23);
            progressBar1.TabIndex = 48;
            // 
            // DisplayAppointmentDate
            // 
            DisplayAppointmentDate.AutoSize = true;
            DisplayAppointmentDate.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayAppointmentDate.Location = new Point(567, 233);
            DisplayAppointmentDate.Name = "DisplayAppointmentDate";
            DisplayAppointmentDate.Size = new Size(38, 17);
            DisplayAppointmentDate.TabIndex = 47;
            DisplayAppointmentDate.Text = "NULL";
            DisplayAppointmentDate.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(399, 232);
            label11.Name = "label11";
            label11.Size = new Size(142, 18);
            label11.TabIndex = 46;
            label11.Text = "Appointment Date";
            // 
            // deliverystatusDisplay
            // 
            deliverystatusDisplay.AutoSize = true;
            deliverystatusDisplay.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deliverystatusDisplay.Location = new Point(567, 286);
            deliverystatusDisplay.Name = "deliverystatusDisplay";
            deliverystatusDisplay.Size = new Size(38, 17);
            deliverystatusDisplay.TabIndex = 45;
            deliverystatusDisplay.Text = "NULL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(399, 286);
            label9.Name = "label9";
            label9.Size = new Size(114, 18);
            label9.TabIndex = 44;
            label9.Text = "Delivery Status";
            // 
            // DisplayButton
            // 
            DisplayButton.BackColor = Color.Green;
            DisplayButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayButton.ForeColor = SystemColors.ControlLightLight;
            DisplayButton.Location = new Point(56, 434);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(207, 43);
            DisplayButton.TabIndex = 43;
            DisplayButton.Text = "Display Details";
            DisplayButton.UseVisualStyleBackColor = false;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // DisplayAppointmentStatus
            // 
            DisplayAppointmentStatus.AutoSize = true;
            DisplayAppointmentStatus.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayAppointmentStatus.Location = new Point(567, 174);
            DisplayAppointmentStatus.Name = "DisplayAppointmentStatus";
            DisplayAppointmentStatus.Size = new Size(38, 17);
            DisplayAppointmentStatus.TabIndex = 42;
            DisplayAppointmentStatus.Text = "NULL";
            DisplayAppointmentStatus.Click += DisplayAppointmentStatus_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(399, 174);
            label7.Name = "label7";
            label7.Size = new Size(148, 18);
            label7.TabIndex = 41;
            label7.Text = "Appointment Status";
            // 
            // IDtextBox
            // 
            IDtextBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IDtextBox.Location = new Point(12, 394);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(333, 22);
            IDtextBox.TabIndex = 40;
            IDtextBox.TextChanged += IDtextBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 291);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // DisplayVerification
            // 
            DisplayVerification.AutoSize = true;
            DisplayVerification.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayVerification.Location = new Point(567, 119);
            DisplayVerification.Name = "DisplayVerification";
            DisplayVerification.Size = new Size(38, 17);
            DisplayVerification.TabIndex = 38;
            DisplayVerification.Text = "NULL";
            DisplayVerification.Click += DisplayVerification_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(399, 119);
            label5.Name = "label5";
            label5.Size = new Size(138, 18);
            label5.TabIndex = 37;
            label5.Text = "Verification Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 373);
            label4.Name = "label4";
            label4.Size = new Size(163, 18);
            label4.TabIndex = 36;
            label4.Text = "Enter CNIC / Bayform";
            label4.Click += label4_Click;
            // 
            // DisplayApplicant
            // 
            DisplayApplicant.AutoSize = true;
            DisplayApplicant.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayApplicant.Location = new Point(567, 71);
            DisplayApplicant.Name = "DisplayApplicant";
            DisplayApplicant.Size = new Size(38, 17);
            DisplayApplicant.TabIndex = 35;
            DisplayApplicant.Text = "NULL";
            DisplayApplicant.Click += DisplayApplicant_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(399, 71);
            label1.Name = "label1";
            label1.Size = new Size(129, 18);
            label1.TabIndex = 34;
            label1.Text = "Applicant Name";
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(12, 18);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 51;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += button1_Click;
            // 
            // deliverydatedisplay
            // 
            deliverydatedisplay.AutoSize = true;
            deliverydatedisplay.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deliverydatedisplay.Location = new Point(567, 332);
            deliverydatedisplay.Name = "deliverydatedisplay";
            deliverydatedisplay.Size = new Size(38, 17);
            deliverydatedisplay.TabIndex = 53;
            deliverydatedisplay.Text = "NULL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(399, 332);
            label3.Name = "label3";
            label3.Size = new Size(108, 18);
            label3.TabIndex = 52;
            label3.Text = "Delivery Date";
            // 
            // ViewApplicationStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(deliverydatedisplay);
            Controls.Add(label3);
            Controls.Add(BackButton);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(progressBar1);
            Controls.Add(DisplayAppointmentDate);
            Controls.Add(label11);
            Controls.Add(deliverystatusDisplay);
            Controls.Add(label9);
            Controls.Add(DisplayButton);
            Controls.Add(DisplayAppointmentStatus);
            Controls.Add(label7);
            Controls.Add(IDtextBox);
            Controls.Add(pictureBox1);
            Controls.Add(DisplayVerification);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(DisplayApplicant);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ViewApplicationStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewApplicationStatus";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private Label label12;
        private ProgressBar progressBar1;
        private Label DisplayAppointmentDate;
        private Label label11;
        private Label deliverystatusDisplay;
        private Label label9;
        private Button DisplayButton;
        private Label DisplayAppointmentStatus;
        private Label label7;
        private TextBox IDtextBox;
        private PictureBox pictureBox1;
        private Label DisplayVerification;
        private Label label5;
        private Label label4;
        private Label DisplayApplicant;
        private Label label1;
        private Button BackButton;
        private Label deliverydatedisplay;
        private Label label3;
    }
}