namespace PassportManagmentOffice.Forms
{
    partial class ViewAppointmentCalendar
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
            appointmentsDataGridView = new DataGridView();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // appointmentsDataGridView
            // 
            appointmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsDataGridView.Location = new Point(12, 93);
            appointmentsDataGridView.Name = "appointmentsDataGridView";
            appointmentsDataGridView.RowTemplate.Height = 25;
            appointmentsDataGridView.Size = new Size(895, 412);
            appointmentsDataGridView.TabIndex = 0;
            appointmentsDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 53;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ViewAppointmentCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 517);
            Controls.Add(BackButton);
            Controls.Add(appointmentsDataGridView);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ViewAppointmentCalendar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewAppointmentCalendar";
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView appointmentsDataGridView;
        private Button BackButton;
    }
}