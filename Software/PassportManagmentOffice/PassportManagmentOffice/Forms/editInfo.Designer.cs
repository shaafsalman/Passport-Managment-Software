namespace PassportManagmentOffice.Forms
{
    partial class editInfo
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
            loadButton = new Button();
            SubmitButton = new Button();
            pictureBox = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            applicantID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // loadButton
            // 
            loadButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loadButton.Location = new Point(32, 321);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(356, 30);
            loadButton.TabIndex = 6;
            loadButton.Text = "Upload";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.Green;
            SubmitButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitButton.ForeColor = SystemColors.ButtonHighlight;
            SubmitButton.Location = new Point(156, 393);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(498, 45);
            SubmitButton.TabIndex = 7;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(32, -1);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(356, 326);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "uploadPictureForm";
            // 
            // applicantID
            // 
            applicantID.Location = new Point(457, 156);
            applicantID.Name = "applicantID";
            applicantID.Size = new Size(260, 23);
            applicantID.TabIndex = 8;
            // 
            // editInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(applicantID);
            Controls.Add(pictureBox);
            Controls.Add(SubmitButton);
            Controls.Add(loadButton);
            Name = "editInfo";
            Text = "editInfo";
            Load += editInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadButton;
        private Button SubmitButton;
        private PictureBox pictureBox;
        private OpenFileDialog openFileDialog1;
        private TextBox applicantID;
    }
}