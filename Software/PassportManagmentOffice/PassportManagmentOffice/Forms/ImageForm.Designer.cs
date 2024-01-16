namespace PassportManagmentOffice.Forms
{
    partial class ImageForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ApplicantNameHeader = new Label();
            ApplicantCnicheader = new Label();
            StatusHeader = new Label();
            StatusDisplay = new Label();
            CNICDisplay = new Label();
            nameDisplay = new Label();
            button1 = new Button();
            button2 = new Button();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(447, 77);
            label1.Name = "label1";
            label1.Size = new Size(211, 28);
            label1.TabIndex = 1;
            label1.Text = "Applicant Details";
            // 
            // ApplicantNameHeader
            // 
            ApplicantNameHeader.AutoSize = true;
            ApplicantNameHeader.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ApplicantNameHeader.Location = new Point(414, 189);
            ApplicantNameHeader.Name = "ApplicantNameHeader";
            ApplicantNameHeader.Size = new Size(115, 16);
            ApplicantNameHeader.TabIndex = 2;
            ApplicantNameHeader.Text = "Applicant Name";
            // 
            // ApplicantCnicheader
            // 
            ApplicantCnicheader.AutoSize = true;
            ApplicantCnicheader.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ApplicantCnicheader.Location = new Point(414, 232);
            ApplicantCnicheader.Name = "ApplicantCnicheader";
            ApplicantCnicheader.Size = new Size(110, 16);
            ApplicantCnicheader.TabIndex = 3;
            ApplicantCnicheader.Text = "Applicant CNIC";
            // 
            // StatusHeader
            // 
            StatusHeader.AutoSize = true;
            StatusHeader.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            StatusHeader.Location = new Point(414, 279);
            StatusHeader.Name = "StatusHeader";
            StatusHeader.Size = new Size(126, 16);
            StatusHeader.TabIndex = 4;
            StatusHeader.Text = "Application Status";
            // 
            // StatusDisplay
            // 
            StatusDisplay.AutoSize = true;
            StatusDisplay.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            StatusDisplay.Location = new Point(573, 278);
            StatusDisplay.Name = "StatusDisplay";
            StatusDisplay.Size = new Size(125, 17);
            StatusDisplay.TabIndex = 8;
            StatusDisplay.Text = "Application Status";
            // 
            // CNICDisplay
            // 
            CNICDisplay.AutoSize = true;
            CNICDisplay.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CNICDisplay.Location = new Point(573, 231);
            CNICDisplay.Name = "CNICDisplay";
            CNICDisplay.Size = new Size(110, 17);
            CNICDisplay.TabIndex = 7;
            CNICDisplay.Text = "Applicant CNIC";
            // 
            // nameDisplay
            // 
            nameDisplay.AutoSize = true;
            nameDisplay.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameDisplay.Location = new Point(573, 188);
            nameDisplay.Name = "nameDisplay";
            nameDisplay.Size = new Size(115, 17);
            nameDisplay.TabIndex = 6;
            nameDisplay.Text = "Applicant Name";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(370, 365);
            button1.Name = "button1";
            button1.Size = new Size(210, 38);
            button1.TabIndex = 9;
            button1.Text = "Verify Details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(586, 365);
            button2.Name = "button2";
            button2.Size = new Size(210, 38);
            button2.TabIndex = 10;
            button2.Text = "Reject";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(12, 29);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 139;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ImageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(StatusDisplay);
            Controls.Add(CNICDisplay);
            Controls.Add(nameDisplay);
            Controls.Add(StatusHeader);
            Controls.Add(ApplicantCnicheader);
            Controls.Add(ApplicantNameHeader);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ImageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ImageForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pictureBox1;
        public Label label1;
        public Label ApplicantNameHeader;
        public Label ApplicantCnicheader;
        public Label StatusHeader;
        public Label StatusDisplay;
        public Label CNICDisplay;
        public Label nameDisplay;
        private Button button1;
        private Button button2;
        private Button BackButton;
    }
}