namespace FastPassport.Forms
{
    partial class RenewPassport
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
            button1 = new Button();
            IDtextBox = new TextBox();
            label4 = new Label();
            CNICDisplay = new Label();
            nameDisplay = new Label();
            ApplicantCnicheader = new Label();
            ApplicantNameHeader = new Label();
            label1 = new Label();
            PassportNumberDisplay = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(635, 126);
            button1.Name = "button1";
            button1.Size = new Size(145, 31);
            button1.TabIndex = 50;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // IDtextBox
            // 
            IDtextBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IDtextBox.Location = new Point(38, 98);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(742, 22);
            IDtextBox.TabIndex = 49;
            IDtextBox.TextChanged += IDtextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(38, 77);
            label4.Name = "label4";
            label4.Size = new Size(163, 18);
            label4.TabIndex = 48;
            label4.Text = "Enter CNIC / Bayform";
            label4.Click += label4_Click;
            // 
            // CNICDisplay
            // 
            CNICDisplay.AutoSize = true;
            CNICDisplay.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CNICDisplay.Location = new Point(249, 249);
            CNICDisplay.Name = "CNICDisplay";
            CNICDisplay.Size = new Size(38, 17);
            CNICDisplay.TabIndex = 47;
            CNICDisplay.Text = "NULL";
            CNICDisplay.Click += CNICDisplay_Click;
            // 
            // nameDisplay
            // 
            nameDisplay.AutoSize = true;
            nameDisplay.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameDisplay.Location = new Point(249, 206);
            nameDisplay.Name = "nameDisplay";
            nameDisplay.Size = new Size(38, 17);
            nameDisplay.TabIndex = 46;
            nameDisplay.Text = "NULL";
            nameDisplay.Click += nameDisplay_Click;
            // 
            // ApplicantCnicheader
            // 
            ApplicantCnicheader.AutoSize = true;
            ApplicantCnicheader.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ApplicantCnicheader.Location = new Point(62, 250);
            ApplicantCnicheader.Name = "ApplicantCnicheader";
            ApplicantCnicheader.Size = new Size(110, 16);
            ApplicantCnicheader.TabIndex = 45;
            ApplicantCnicheader.Text = "Applicant CNIC";
            ApplicantCnicheader.Click += ApplicantCnicheader_Click;
            // 
            // ApplicantNameHeader
            // 
            ApplicantNameHeader.AutoSize = true;
            ApplicantNameHeader.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ApplicantNameHeader.Location = new Point(62, 207);
            ApplicantNameHeader.Name = "ApplicantNameHeader";
            ApplicantNameHeader.Size = new Size(115, 16);
            ApplicantNameHeader.TabIndex = 44;
            ApplicantNameHeader.Text = "Applicant Name";
            ApplicantNameHeader.Click += ApplicantNameHeader_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 286);
            label1.Name = "label1";
            label1.Size = new Size(113, 16);
            label1.TabIndex = 51;
            label1.Text = "PassportNumber";
            label1.Click += label1_Click;
            // 
            // PassportNumberDisplay
            // 
            PassportNumberDisplay.AutoSize = true;
            PassportNumberDisplay.Location = new Point(249, 286);
            PassportNumberDisplay.Name = "PassportNumberDisplay";
            PassportNumberDisplay.Size = new Size(36, 15);
            PassportNumberDisplay.TabIndex = 52;
            PassportNumberDisplay.Text = "NULL";
            PassportNumberDisplay.Click += PassportNumberDisplay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(252, 150);
            label2.Name = "label2";
            label2.Size = new Size(234, 25);
            label2.TabIndex = 53;
            label2.Text = "Applicant Information";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(62, 394);
            button2.Name = "button2";
            button2.Size = new Size(293, 45);
            button2.TabIndex = 54;
            button2.Text = "Extend with Same Information";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(469, 394);
            button3.Name = "button3";
            button3.Size = new Size(293, 45);
            button3.TabIndex = 55;
            button3.Text = "Renew With New Information";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(38, 26);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 138;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // RenewPassport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 493);
            Controls.Add(BackButton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(PassportNumberDisplay);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(IDtextBox);
            Controls.Add(label4);
            Controls.Add(CNICDisplay);
            Controls.Add(nameDisplay);
            Controls.Add(ApplicantCnicheader);
            Controls.Add(ApplicantNameHeader);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RenewPassport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RenewPassport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox IDtextBox;
        private Label label4;
        public Label CNICDisplay;
        public Label nameDisplay;
        public Label ApplicantCnicheader;
        public Label ApplicantNameHeader;
        private Label label1;
        private Label PassportNumberDisplay;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button BackButton;
    }
}