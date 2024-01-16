namespace FastPassport.Forms
{
    partial class ApplyforLostPassport
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
            BackButton = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            PassportNumberDisplay = new Label();
            label1 = new Label();
            button1 = new Button();
            IDtextBox = new TextBox();
            label4 = new Label();
            CNICDisplay = new Label();
            nameDisplay = new Label();
            ApplicantCnicheader = new Label();
            ApplicantNameHeader = new Label();
            button4 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(22, 26);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 139;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(453, 382);
            button3.Name = "button3";
            button3.Size = new Size(293, 45);
            button3.TabIndex = 151;
            button3.Text = "Renew With New Information";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(46, 382);
            button2.Name = "button2";
            button2.Size = new Size(293, 45);
            button2.TabIndex = 150;
            button2.Text = "Extend with Same Information";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(275, 148);
            label2.Name = "label2";
            label2.Size = new Size(234, 25);
            label2.TabIndex = 149;
            label2.Text = "Applicant Information";
            // 
            // PassportNumberDisplay
            // 
            PassportNumberDisplay.AutoSize = true;
            PassportNumberDisplay.Location = new Point(233, 274);
            PassportNumberDisplay.Name = "PassportNumberDisplay";
            PassportNumberDisplay.Size = new Size(36, 15);
            PassportNumberDisplay.TabIndex = 148;
            PassportNumberDisplay.Text = "NULL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 274);
            label1.Name = "label1";
            label1.Size = new Size(113, 16);
            label1.TabIndex = 147;
            label1.Text = "PassportNumber";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(215, 114);
            button1.Name = "button1";
            button1.Size = new Size(145, 31);
            button1.TabIndex = 146;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // IDtextBox
            // 
            IDtextBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IDtextBox.Location = new Point(22, 86);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(338, 22);
            IDtextBox.TabIndex = 145;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 65);
            label4.Name = "label4";
            label4.Size = new Size(159, 18);
            label4.TabIndex = 144;
            label4.Text = "Enter CNIC/ Bayform";
            // 
            // CNICDisplay
            // 
            CNICDisplay.AutoSize = true;
            CNICDisplay.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CNICDisplay.Location = new Point(233, 237);
            CNICDisplay.Name = "CNICDisplay";
            CNICDisplay.Size = new Size(38, 17);
            CNICDisplay.TabIndex = 143;
            CNICDisplay.Text = "NULL";
            // 
            // nameDisplay
            // 
            nameDisplay.AutoSize = true;
            nameDisplay.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameDisplay.Location = new Point(233, 194);
            nameDisplay.Name = "nameDisplay";
            nameDisplay.Size = new Size(38, 17);
            nameDisplay.TabIndex = 142;
            nameDisplay.Text = "NULL";
            // 
            // ApplicantCnicheader
            // 
            ApplicantCnicheader.AutoSize = true;
            ApplicantCnicheader.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ApplicantCnicheader.Location = new Point(46, 238);
            ApplicantCnicheader.Name = "ApplicantCnicheader";
            ApplicantCnicheader.Size = new Size(110, 16);
            ApplicantCnicheader.TabIndex = 141;
            ApplicantCnicheader.Text = "Applicant CNIC";
            // 
            // ApplicantNameHeader
            // 
            ApplicantNameHeader.AutoSize = true;
            ApplicantNameHeader.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ApplicantNameHeader.Location = new Point(46, 195);
            ApplicantNameHeader.Name = "ApplicantNameHeader";
            ApplicantNameHeader.Size = new Size(115, 16);
            ApplicantNameHeader.TabIndex = 140;
            ApplicantNameHeader.Text = "Applicant Name";
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(601, 114);
            button4.Name = "button4";
            button4.Size = new Size(145, 31);
            button4.TabIndex = 154;
            button4.Text = "Verify";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(408, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 22);
            textBox1.TabIndex = 153;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(408, 65);
            label3.Name = "label3";
            label3.Size = new Size(162, 18);
            label3.TabIndex = 152;
            label3.Text = "Enter FIR report Code";
            label3.Click += label3_Click;
            // 
            // ApplyforLostPassport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label3);
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
            Controls.Add(BackButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ApplyforLostPassport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApplyforLostPassport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Button button3;
        private Button button2;
        private Label label2;
        private Label PassportNumberDisplay;
        private Label label1;
        private Button button1;
        private TextBox IDtextBox;
        private Label label4;
        public Label CNICDisplay;
        public Label nameDisplay;
        public Label ApplicantCnicheader;
        public Label ApplicantNameHeader;
        private Button button4;
        private TextBox textBox1;
        private Label label3;
    }
}