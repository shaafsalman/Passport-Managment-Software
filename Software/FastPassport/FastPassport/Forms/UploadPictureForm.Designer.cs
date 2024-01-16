namespace FastPassport.Forms
{
    partial class UploadPictureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadPictureForm));
            pictureBox = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            loadButton = new Button();
            SubmitButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(22, -2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(356, 326);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "uploadPictureForm";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // loadButton
            // 
            loadButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loadButton.Location = new Point(22, 294);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(356, 30);
            loadButton.TabIndex = 1;
            loadButton.Text = "Upload";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.Green;
            SubmitButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitButton.ForeColor = SystemColors.ButtonHighlight;
            SubmitButton.Location = new Point(187, 399);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(498, 45);
            SubmitButton.TabIndex = 2;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(399, 56);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(465, 268);
            textBox1.TabIndex = 3;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(550, 7);
            label1.Name = "label1";
            label1.Size = new Size(135, 28);
            label1.TabIndex = 4;
            label1.Text = "Guidelines";
            label1.Click += label1_Click;
            // 
            // UploadPictureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 513);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(SubmitButton);
            Controls.Add(loadButton);
            Controls.Add(pictureBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UploadPictureForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UploadPictureForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private OpenFileDialog openFileDialog1;
        private Button loadButton;
        private Button SubmitButton;
        private TextBox textBox1;
        private Label label1;
    }
}