namespace FastPassport.Forms
{
    partial class SighnUp
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
            IDHeader = new Label();
            CNICInput = new TextBox();
            UseernameInput = new TextBox();
            UsernameHeader = new Label();
            PasswordInput = new TextBox();
            PasswordHeader = new Label();
            RegisterTittle = new Label();
            RegisterButton = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // IDHeader
            // 
            IDHeader.AutoSize = true;
            IDHeader.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IDHeader.Location = new Point(118, 292);
            IDHeader.Name = "IDHeader";
            IDHeader.Size = new Size(38, 17);
            IDHeader.TabIndex = 0;
            IDHeader.Text = "CNIC";
            IDHeader.Click += IDHeader_Click;
            // 
            // CNICInput
            // 
            CNICInput.Location = new Point(118, 310);
            CNICInput.Name = "CNICInput";
            CNICInput.Size = new Size(434, 23);
            CNICInput.TabIndex = 1;
            CNICInput.TextChanged += CNICInput_TextChanged;
            // 
            // UseernameInput
            // 
            UseernameInput.Location = new Point(118, 390);
            UseernameInput.Name = "UseernameInput";
            UseernameInput.Size = new Size(434, 23);
            UseernameInput.TabIndex = 3;
            UseernameInput.TextChanged += UseernameInput_TextChanged;
            // 
            // UsernameHeader
            // 
            UsernameHeader.AutoSize = true;
            UsernameHeader.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameHeader.Location = new Point(118, 363);
            UsernameHeader.Name = "UsernameHeader";
            UsernameHeader.Size = new Size(67, 17);
            UsernameHeader.TabIndex = 2;
            UsernameHeader.Text = "Username";
            UsernameHeader.Click += UsernameHeader_Click;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(118, 459);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(434, 23);
            PasswordInput.TabIndex = 5;
            PasswordInput.TextChanged += PasswordInput_TextChanged;
            // 
            // PasswordHeader
            // 
            PasswordHeader.AutoSize = true;
            PasswordHeader.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordHeader.Location = new Point(118, 441);
            PasswordHeader.Name = "PasswordHeader";
            PasswordHeader.Size = new Size(63, 17);
            PasswordHeader.TabIndex = 4;
            PasswordHeader.Text = "Password";
            PasswordHeader.Click += PasswordHeader_Click;
            // 
            // RegisterTittle
            // 
            RegisterTittle.AutoSize = true;
            RegisterTittle.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterTittle.ForeColor = Color.ForestGreen;
            RegisterTittle.Location = new Point(278, 260);
            RegisterTittle.Name = "RegisterTittle";
            RegisterTittle.Size = new Size(127, 36);
            RegisterTittle.TabIndex = 6;
            RegisterTittle.Text = "Register";
            RegisterTittle.Click += RegisterTittle_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.Green;
            RegisterButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterButton.ForeColor = SystemColors.ControlLightLight;
            RegisterButton.Location = new Point(365, 513);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(226, 40);
            RegisterButton.TabIndex = 7;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.NADRA_logo;
            pictureBox1.Location = new Point(223, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(91, 513);
            button1.Name = "button1";
            button1.Size = new Size(226, 40);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SighnUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(684, 661);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(RegisterButton);
            Controls.Add(RegisterTittle);
            Controls.Add(PasswordInput);
            Controls.Add(PasswordHeader);
            Controls.Add(UseernameInput);
            Controls.Add(UsernameHeader);
            Controls.Add(CNICInput);
            Controls.Add(IDHeader);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SighnUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SighnUp";
            Load += SighnUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDHeader;
        private TextBox CNICInput;
        private TextBox UseernameInput;
        private Label UsernameHeader;
        private TextBox PasswordInput;
        private Label PasswordHeader;
        private Label RegisterTittle;
        private Button RegisterButton;
        private PictureBox pictureBox1;
        private Button button1;
    }
}