namespace PassportManagmentOffice.Forms
{
    partial class ViewCargoProgressForms
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            OfficerNameDisplay = new Label();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 275);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(650, 130);
            button1.Name = "button1";
            button1.Size = new Size(138, 27);
            button1.TabIndex = 1;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 2;
            label1.Text = "Officer Username :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(292, 9);
            label2.Name = "label2";
            label2.Size = new Size(182, 23);
            label2.TabIndex = 3;
            label2.Text = "Officer Credentials";
            // 
            // OfficerNameDisplay
            // 
            OfficerNameDisplay.AutoSize = true;
            OfficerNameDisplay.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            OfficerNameDisplay.Location = new Point(179, 117);
            OfficerNameDisplay.Name = "OfficerNameDisplay";
            OfficerNameDisplay.Size = new Size(12, 17);
            OfficerNameDisplay.TabIndex = 4;
            OfficerNameDisplay.Text = ".";
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 54;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ViewCargoProgressForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackButton);
            Controls.Add(OfficerNameDisplay);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ViewCargoProgressForms";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewCargoProgressForms";
            Load += ViewCargoProgressForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label OfficerNameDisplay;
        private Button BackButton;
    }
}