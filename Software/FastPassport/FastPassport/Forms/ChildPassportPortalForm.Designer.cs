namespace FastPassport.Forms
{
    partial class ChildPassportPortalForm
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
            AppointmentButton = new Button();
            label12 = new Label();
            checkBoxFemale = new CheckBox();
            checkBoxMale = new CheckBox();
            checkBox100 = new CheckBox();
            checkBox72 = new CheckBox();
            checkBox36 = new CheckBox();
            DOBInput = new DateTimePicker();
            AddressInput = new TextBox();
            AddressLabel = new Label();
            DOBLabel = new Label();
            PageCountLabel = new Label();
            GaurdianPhoneNumberInput = new TextBox();
            GaurdianPhoneNumberLabel = new Label();
            GaurdianEmailInput = new TextBox();
            GaurdianEmailLabel = new Label();
            GenderLabel = new Label();
            FirstNameInput = new TextBox();
            LastNameLabel = new Label();
            LastNameInput = new TextBox();
            FirstNameLabel = new Label();
            BayformtextBox = new TextBox();
            BayformLabel = new Label();
            FathersNameInput = new TextBox();
            FathersLastNameLabel = new Label();
            FathersLastNameInput = new TextBox();
            FathersFirstNameLabel = new Label();
            MothersFirstNameInput = new TextBox();
            MothersLastNameLabel = new Label();
            MothersLastNameInput = new TextBox();
            MotherFirstNameLabel = new Label();
            FathersCNICInput = new TextBox();
            FathersCNICLabel = new Label();
            MothersCNICInput = new TextBox();
            MothersCNICLabel = new Label();
            CheckboxUrgent = new CheckBox();
            CheckboxRegular = new CheckBox();
            TypeLabel = new Label();
            BackButton = new Button();
            SuspendLayout();
            // 
            // AppointmentButton
            // 
            AppointmentButton.BackColor = Color.Green;
            AppointmentButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AppointmentButton.ForeColor = SystemColors.ButtonHighlight;
            AppointmentButton.Location = new Point(276, 441);
            AppointmentButton.Name = "AppointmentButton";
            AppointmentButton.Size = new Size(246, 42);
            AppointmentButton.TabIndex = 79;
            AppointmentButton.Text = "Apply For Appointment";
            AppointmentButton.UseVisualStyleBackColor = false;
            AppointmentButton.Click += AppointmentButton_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(168, 21);
            label12.Name = "label12";
            label12.Size = new Size(481, 32);
            label12.TabIndex = 77;
            label12.Text = "New Passport Child Applicant Foam";
            // 
            // checkBoxFemale
            // 
            checkBoxFemale.AutoSize = true;
            checkBoxFemale.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxFemale.Location = new Point(582, 228);
            checkBoxFemale.Name = "checkBoxFemale";
            checkBoxFemale.Size = new Size(71, 21);
            checkBoxFemale.TabIndex = 76;
            checkBoxFemale.Text = "Female";
            checkBoxFemale.UseVisualStyleBackColor = true;
            checkBoxFemale.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBoxMale
            // 
            checkBoxMale.AutoSize = true;
            checkBoxMale.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxMale.Location = new Point(471, 229);
            checkBoxMale.Name = "checkBoxMale";
            checkBoxMale.Size = new Size(57, 21);
            checkBoxMale.TabIndex = 75;
            checkBoxMale.Text = "Male";
            checkBoxMale.UseVisualStyleBackColor = true;
            checkBoxMale.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox100
            // 
            checkBox100.AutoSize = true;
            checkBox100.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox100.Location = new Point(619, 173);
            checkBox100.Name = "checkBox100";
            checkBox100.Size = new Size(48, 21);
            checkBox100.TabIndex = 74;
            checkBox100.Text = "100";
            checkBox100.UseVisualStyleBackColor = true;
            checkBox100.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox72
            // 
            checkBox72.AutoSize = true;
            checkBox72.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox72.Location = new Point(547, 173);
            checkBox72.Name = "checkBox72";
            checkBox72.Size = new Size(41, 21);
            checkBox72.TabIndex = 71;
            checkBox72.Text = "72";
            checkBox72.UseVisualStyleBackColor = true;
            checkBox72.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox36
            // 
            checkBox36.AutoSize = true;
            checkBox36.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox36.Location = new Point(471, 173);
            checkBox36.Name = "checkBox36";
            checkBox36.Size = new Size(41, 21);
            checkBox36.TabIndex = 70;
            checkBox36.Text = "36";
            checkBox36.UseVisualStyleBackColor = true;
            checkBox36.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // DOBInput
            // 
            DOBInput.Location = new Point(473, 121);
            DOBInput.Name = "DOBInput";
            DOBInput.Size = new Size(200, 23);
            DOBInput.TabIndex = 69;
            DOBInput.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // AddressInput
            // 
            AddressInput.Location = new Point(29, 306);
            AddressInput.Name = "AddressInput";
            AddressInput.Size = new Size(689, 23);
            AddressInput.TabIndex = 68;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddressLabel.Location = new Point(29, 288);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(57, 17);
            AddressLabel.TabIndex = 67;
            AddressLabel.Text = "Address";
            // 
            // DOBLabel
            // 
            DOBLabel.AutoSize = true;
            DOBLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DOBLabel.Location = new Point(471, 101);
            DOBLabel.Name = "DOBLabel";
            DOBLabel.Size = new Size(88, 17);
            DOBLabel.TabIndex = 66;
            DOBLabel.Text = "Date of Birth";
            DOBLabel.Click += label10_Click;
            // 
            // PageCountLabel
            // 
            PageCountLabel.AutoSize = true;
            PageCountLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PageCountLabel.Location = new Point(469, 153);
            PageCountLabel.Name = "PageCountLabel";
            PageCountLabel.Size = new Size(87, 17);
            PageCountLabel.TabIndex = 64;
            PageCountLabel.Text = "Page Count";
            PageCountLabel.Click += label8_Click;
            // 
            // GaurdianPhoneNumberInput
            // 
            GaurdianPhoneNumberInput.Location = new Point(240, 251);
            GaurdianPhoneNumberInput.Name = "GaurdianPhoneNumberInput";
            GaurdianPhoneNumberInput.Size = new Size(185, 23);
            GaurdianPhoneNumberInput.TabIndex = 61;
            // 
            // GaurdianPhoneNumberLabel
            // 
            GaurdianPhoneNumberLabel.AutoSize = true;
            GaurdianPhoneNumberLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            GaurdianPhoneNumberLabel.Location = new Point(240, 233);
            GaurdianPhoneNumberLabel.Name = "GaurdianPhoneNumberLabel";
            GaurdianPhoneNumberLabel.Size = new Size(170, 17);
            GaurdianPhoneNumberLabel.TabIndex = 60;
            GaurdianPhoneNumberLabel.Text = "Gaurdian Phone Number";
            // 
            // GaurdianEmailInput
            // 
            GaurdianEmailInput.Location = new Point(29, 251);
            GaurdianEmailInput.Name = "GaurdianEmailInput";
            GaurdianEmailInput.Size = new Size(185, 23);
            GaurdianEmailInput.TabIndex = 59;
            // 
            // GaurdianEmailLabel
            // 
            GaurdianEmailLabel.AutoSize = true;
            GaurdianEmailLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            GaurdianEmailLabel.Location = new Point(29, 233);
            GaurdianEmailLabel.Name = "GaurdianEmailLabel";
            GaurdianEmailLabel.Size = new Size(108, 17);
            GaurdianEmailLabel.TabIndex = 58;
            GaurdianEmailLabel.Text = "Gaurdian Email";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            GenderLabel.Location = new Point(471, 209);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(56, 17);
            GenderLabel.TabIndex = 57;
            GenderLabel.Text = "Gender";
            GenderLabel.Click += label4_Click;
            // 
            // FirstNameInput
            // 
            FirstNameInput.Location = new Point(29, 173);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(185, 23);
            FirstNameInput.TabIndex = 56;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.Location = new Point(240, 155);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(77, 17);
            LastNameLabel.TabIndex = 55;
            LastNameLabel.Text = "Last Name";
            // 
            // LastNameInput
            // 
            LastNameInput.Location = new Point(240, 173);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(185, 23);
            LastNameInput.TabIndex = 54;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(29, 155);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(75, 17);
            FirstNameLabel.TabIndex = 53;
            FirstNameLabel.Text = "First Name";
            // 
            // BayformtextBox
            // 
            BayformtextBox.Location = new Point(29, 121);
            BayformtextBox.Name = "BayformtextBox";
            BayformtextBox.Size = new Size(396, 23);
            BayformtextBox.TabIndex = 52;
            // 
            // BayformLabel
            // 
            BayformLabel.AutoSize = true;
            BayformLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BayformLabel.Location = new Point(29, 103);
            BayformLabel.Name = "BayformLabel";
            BayformLabel.Size = new Size(60, 17);
            BayformLabel.TabIndex = 51;
            BayformLabel.Text = "Bayform";
            BayformLabel.Click += label1_Click;
            // 
            // FathersNameInput
            // 
            FathersNameInput.Location = new Point(29, 354);
            FathersNameInput.Name = "FathersNameInput";
            FathersNameInput.Size = new Size(185, 23);
            FathersNameInput.TabIndex = 83;
            // 
            // FathersLastNameLabel
            // 
            FathersLastNameLabel.AutoSize = true;
            FathersLastNameLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FathersLastNameLabel.Location = new Point(240, 336);
            FathersLastNameLabel.Name = "FathersLastNameLabel";
            FathersLastNameLabel.Size = new Size(129, 17);
            FathersLastNameLabel.TabIndex = 82;
            FathersLastNameLabel.Text = "Father's Last Name";
            // 
            // FathersLastNameInput
            // 
            FathersLastNameInput.Location = new Point(240, 354);
            FathersLastNameInput.Name = "FathersLastNameInput";
            FathersLastNameInput.Size = new Size(185, 23);
            FathersLastNameInput.TabIndex = 81;
            // 
            // FathersFirstNameLabel
            // 
            FathersFirstNameLabel.AutoSize = true;
            FathersFirstNameLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FathersFirstNameLabel.Location = new Point(29, 336);
            FathersFirstNameLabel.Name = "FathersFirstNameLabel";
            FathersFirstNameLabel.Size = new Size(127, 17);
            FathersFirstNameLabel.TabIndex = 80;
            FathersFirstNameLabel.Text = "Father's First Name";
            // 
            // MothersFirstNameInput
            // 
            MothersFirstNameInput.Location = new Point(29, 404);
            MothersFirstNameInput.Name = "MothersFirstNameInput";
            MothersFirstNameInput.Size = new Size(185, 23);
            MothersFirstNameInput.TabIndex = 87;
            // 
            // MothersLastNameLabel
            // 
            MothersLastNameLabel.AutoSize = true;
            MothersLastNameLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MothersLastNameLabel.Location = new Point(240, 386);
            MothersLastNameLabel.Name = "MothersLastNameLabel";
            MothersLastNameLabel.Size = new Size(134, 17);
            MothersLastNameLabel.TabIndex = 86;
            MothersLastNameLabel.Text = "Mother's Last Name";
            // 
            // MothersLastNameInput
            // 
            MothersLastNameInput.Location = new Point(240, 404);
            MothersLastNameInput.Name = "MothersLastNameInput";
            MothersLastNameInput.Size = new Size(185, 23);
            MothersLastNameInput.TabIndex = 85;
            // 
            // MotherFirstNameLabel
            // 
            MotherFirstNameLabel.AutoSize = true;
            MotherFirstNameLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MotherFirstNameLabel.Location = new Point(29, 386);
            MotherFirstNameLabel.Name = "MotherFirstNameLabel";
            MotherFirstNameLabel.Size = new Size(132, 17);
            MotherFirstNameLabel.TabIndex = 84;
            MotherFirstNameLabel.Text = "Mother's First Name";
            // 
            // FathersCNICInput
            // 
            FathersCNICInput.Location = new Point(464, 354);
            FathersCNICInput.Name = "FathersCNICInput";
            FathersCNICInput.Size = new Size(254, 23);
            FathersCNICInput.TabIndex = 89;
            // 
            // FathersCNICLabel
            // 
            FathersCNICLabel.AutoSize = true;
            FathersCNICLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FathersCNICLabel.Location = new Point(464, 336);
            FathersCNICLabel.Name = "FathersCNICLabel";
            FathersCNICLabel.Size = new Size(99, 17);
            FathersCNICLabel.TabIndex = 88;
            FathersCNICLabel.Text = "Father's  CNIC";
            // 
            // MothersCNICInput
            // 
            MothersCNICInput.Location = new Point(464, 404);
            MothersCNICInput.Name = "MothersCNICInput";
            MothersCNICInput.Size = new Size(254, 23);
            MothersCNICInput.TabIndex = 91;
            // 
            // MothersCNICLabel
            // 
            MothersCNICLabel.AutoSize = true;
            MothersCNICLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MothersCNICLabel.Location = new Point(464, 386);
            MothersCNICLabel.Name = "MothersCNICLabel";
            MothersCNICLabel.Size = new Size(100, 17);
            MothersCNICLabel.TabIndex = 90;
            MothersCNICLabel.Text = "Mother's CNIC";
            // 
            // CheckboxUrgent
            // 
            CheckboxUrgent.AutoSize = true;
            CheckboxUrgent.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CheckboxUrgent.Location = new Point(582, 277);
            CheckboxUrgent.Name = "CheckboxUrgent";
            CheckboxUrgent.Size = new Size(67, 21);
            CheckboxUrgent.TabIndex = 94;
            CheckboxUrgent.Text = "Urgent";
            CheckboxUrgent.UseVisualStyleBackColor = true;
            // 
            // CheckboxRegular
            // 
            CheckboxRegular.AutoSize = true;
            CheckboxRegular.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CheckboxRegular.Location = new Point(471, 277);
            CheckboxRegular.Name = "CheckboxRegular";
            CheckboxRegular.Size = new Size(72, 21);
            CheckboxRegular.TabIndex = 93;
            CheckboxRegular.Text = "Regular";
            CheckboxRegular.UseVisualStyleBackColor = true;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TypeLabel.Location = new Point(471, 257);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(36, 17);
            TypeLabel.TabIndex = 92;
            TypeLabel.Text = "Type";
            TypeLabel.Click += label1_Click_1;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(29, 30);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 138;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ChildPassportPortalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 513);
            Controls.Add(BackButton);
            Controls.Add(CheckboxUrgent);
            Controls.Add(CheckboxRegular);
            Controls.Add(TypeLabel);
            Controls.Add(MothersCNICInput);
            Controls.Add(MothersCNICLabel);
            Controls.Add(FathersCNICInput);
            Controls.Add(FathersCNICLabel);
            Controls.Add(MothersFirstNameInput);
            Controls.Add(MothersLastNameLabel);
            Controls.Add(MothersLastNameInput);
            Controls.Add(MotherFirstNameLabel);
            Controls.Add(FathersNameInput);
            Controls.Add(FathersLastNameLabel);
            Controls.Add(FathersLastNameInput);
            Controls.Add(FathersFirstNameLabel);
            Controls.Add(AppointmentButton);
            Controls.Add(label12);
            Controls.Add(checkBoxFemale);
            Controls.Add(checkBoxMale);
            Controls.Add(checkBox100);
            Controls.Add(checkBox72);
            Controls.Add(checkBox36);
            Controls.Add(DOBInput);
            Controls.Add(AddressInput);
            Controls.Add(AddressLabel);
            Controls.Add(DOBLabel);
            Controls.Add(PageCountLabel);
            Controls.Add(GaurdianPhoneNumberInput);
            Controls.Add(GaurdianPhoneNumberLabel);
            Controls.Add(GaurdianEmailInput);
            Controls.Add(GaurdianEmailLabel);
            Controls.Add(GenderLabel);
            Controls.Add(FirstNameInput);
            Controls.Add(LastNameLabel);
            Controls.Add(LastNameInput);
            Controls.Add(FirstNameLabel);
            Controls.Add(BayformtextBox);
            Controls.Add(BayformLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ChildPassportPortalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChildPassportPortalForm";
            Load += ChildPassportPortalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AppointmentButton;
        private Label label12;
        private CheckBox checkBoxFemale;
        private CheckBox checkBoxMale;
        private CheckBox checkBox100;
        private CheckBox checkBox72;
        private CheckBox checkBox36;
        private DateTimePicker DOBInput;
        private TextBox AddressInput;
        private Label AddressLabel;
        private Label DOBLabel;
        private Label PageCountLabel;
        private TextBox GaurdianPhoneNumberInput;
        private Label GaurdianPhoneNumberLabel;
        private TextBox GaurdianEmailInput;
        private Label GaurdianEmailLabel;
        private Label GenderLabel;
        private TextBox FirstNameInput;
        private Label LastNameLabel;
        private TextBox LastNameInput;
        private Label FirstNameLabel;
        private TextBox BayformtextBox;
        private Label BayformLabel;
        private TextBox FathersNameInput;
        private Label FathersLastNameLabel;
        private TextBox FathersLastNameInput;
        private Label FathersFirstNameLabel;
        private TextBox MothersFirstNameInput;
        private Label MothersLastNameLabel;
        private TextBox MothersLastNameInput;
        private Label MotherFirstNameLabel;
        private TextBox FathersCNICInput;
        private Label FathersCNICLabel;
        private TextBox MothersCNICInput;
        private Label MothersCNICLabel;
        private CheckBox CheckboxUrgent;
        private CheckBox CheckboxRegular;
        private Label TypeLabel;
        private Button BackButton;
    }
}