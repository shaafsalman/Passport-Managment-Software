namespace FastPassport.Forms
{
    partial class ProcessAppointment
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
            AcceptButton = new Button();
            RejectButton = new Button();
            CNICDisplay = new Label();
            nameDisplay = new Label();
            ApplicantCnicheader = new Label();
            ApplicantNameHeader = new Label();
            IDtextBox = new TextBox();
            label4 = new Label();
            button1 = new Button();
            BackButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AcceptButton
            // 
            AcceptButton.BackColor = Color.Green;
            AcceptButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AcceptButton.ForeColor = SystemColors.ControlLightLight;
            AcceptButton.Location = new Point(554, 65);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(213, 43);
            AcceptButton.TabIndex = 0;
            AcceptButton.Text = "Accept";
            AcceptButton.UseVisualStyleBackColor = false;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // RejectButton
            // 
            RejectButton.BackColor = Color.Red;
            RejectButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RejectButton.ForeColor = SystemColors.ControlLightLight;
            RejectButton.Location = new Point(554, 141);
            RejectButton.Name = "RejectButton";
            RejectButton.Size = new Size(215, 43);
            RejectButton.TabIndex = 1;
            RejectButton.Text = "Reject";
            RejectButton.UseVisualStyleBackColor = false;
            RejectButton.Click += RejectButton_Click;
            // 
            // CNICDisplay
            // 
            CNICDisplay.AutoSize = true;
            CNICDisplay.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CNICDisplay.Location = new Point(171, 167);
            CNICDisplay.Name = "CNICDisplay";
            CNICDisplay.Size = new Size(38, 17);
            CNICDisplay.TabIndex = 11;
            CNICDisplay.Text = "NULL";
            // 
            // nameDisplay
            // 
            nameDisplay.AutoSize = true;
            nameDisplay.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameDisplay.Location = new Point(171, 124);
            nameDisplay.Name = "nameDisplay";
            nameDisplay.Size = new Size(38, 17);
            nameDisplay.TabIndex = 10;
            nameDisplay.Text = "NULL";
            // 
            // ApplicantCnicheader
            // 
            ApplicantCnicheader.AutoSize = true;
            ApplicantCnicheader.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ApplicantCnicheader.Location = new Point(12, 168);
            ApplicantCnicheader.Name = "ApplicantCnicheader";
            ApplicantCnicheader.Size = new Size(110, 16);
            ApplicantCnicheader.TabIndex = 9;
            ApplicantCnicheader.Text = "Applicant CNIC";
            // 
            // ApplicantNameHeader
            // 
            ApplicantNameHeader.AutoSize = true;
            ApplicantNameHeader.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ApplicantNameHeader.Location = new Point(12, 125);
            ApplicantNameHeader.Name = "ApplicantNameHeader";
            ApplicantNameHeader.Size = new Size(115, 16);
            ApplicantNameHeader.TabIndex = 8;
            ApplicantNameHeader.Text = "Applicant Name";
            // 
            // IDtextBox
            // 
            IDtextBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IDtextBox.Location = new Point(12, 82);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(467, 22);
            IDtextBox.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 61);
            label4.Name = "label4";
            label4.Size = new Size(163, 18);
            label4.TabIndex = 41;
            label4.Text = "Enter CNIC / Bayform";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(334, 110);
            button1.Name = "button1";
            button1.Size = new Size(145, 31);
            button1.TabIndex = 43;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 52;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 212);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(815, 276);
            dataGridView1.TabIndex = 53;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProcessAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 500);
            Controls.Add(dataGridView1);
            Controls.Add(BackButton);
            Controls.Add(button1);
            Controls.Add(IDtextBox);
            Controls.Add(label4);
            Controls.Add(CNICDisplay);
            Controls.Add(nameDisplay);
            Controls.Add(ApplicantCnicheader);
            Controls.Add(ApplicantNameHeader);
            Controls.Add(RejectButton);
            Controls.Add(AcceptButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProcessAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProcessAppointment";
            Load += ProcessAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AcceptButton;
        private Button RejectButton;
        public Label CNICDisplay;
        public Label nameDisplay;
        public Label ApplicantCnicheader;
        public Label ApplicantNameHeader;
        private TextBox IDtextBox;
        private Label label4;
        private Button button1;
        private Button BackButton;
        private DataGridView dataGridView1;
    }
}