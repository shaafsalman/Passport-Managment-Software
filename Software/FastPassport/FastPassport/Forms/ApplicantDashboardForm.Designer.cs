namespace FastPassport.Forms
{
    partial class ApplicantDashboardForm
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(37, 269);
            button1.Name = "button1";
            button1.Size = new Size(319, 46);
            button1.TabIndex = 0;
            button1.Text = "Apply For New Passport";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(431, 269);
            button2.Name = "button2";
            button2.Size = new Size(319, 46);
            button2.TabIndex = 1;
            button2.Text = "Renew Exisitng Passport";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(37, 349);
            button3.Name = "button3";
            button3.Size = new Size(319, 46);
            button3.TabIndex = 2;
            button3.Text = "Apply for Lost Passport";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(431, 349);
            button4.Name = "button4";
            button4.Size = new Size(319, 46);
            button4.TabIndex = 3;
            button4.Text = "View Application Status";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.NADRA_logo;
            pictureBox1.Location = new Point(298, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(703, 12);
            button5.Name = "button5";
            button5.Size = new Size(85, 29);
            button5.TabIndex = 8;
            button5.Text = "Log out";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ApplicantDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ApplicantDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApplicantDashboardForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Button button5;
    }
}