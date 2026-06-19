namespace DITP2123_DentaNovaClinic
{
    partial class FormServices
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServices));
            this.lblServices = new System.Windows.Forms.Label();
            this.picBox_listServices = new System.Windows.Forms.PictureBox();
            this.imageListServices = new System.Windows.Forms.ImageList(this.components);
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbl_ServicesName = new System.Windows.Forms.Label();
            this.lbl_WorkingHours = new System.Windows.Forms.Label();
            this.lbl_TimeDay = new System.Windows.Forms.Label();
            this.btnTo_Appointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_listServices)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(195, 25);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(339, 56);
            this.lblServices.TabIndex = 0;
            this.lblServices.Text = "Our Services";
            // 
            // picBox_listServices
            // 
            this.picBox_listServices.Location = new System.Drawing.Point(153, 95);
            this.picBox_listServices.Name = "picBox_listServices";
            this.picBox_listServices.Size = new System.Drawing.Size(425, 389);
            this.picBox_listServices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_listServices.TabIndex = 1;
            this.picBox_listServices.TabStop = false;
            // 
            // imageListServices
            // 
            this.imageListServices.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListServices.ImageStream")));
            this.imageListServices.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListServices.Images.SetKeyName(0, "braces.jpg");
            this.imageListServices.Images.SetKeyName(1, "dental_Consultation.jpeg");
            this.imageListServices.Images.SetKeyName(2, "dental_filling.jpg");
            this.imageListServices.Images.SetKeyName(3, "teeth_cleaning.jpg");
            this.imageListServices.Images.SetKeyName(4, "teeth_whitening.jpg");
            this.imageListServices.Images.SetKeyName(5, "tooth_Extraction.jpg");
            this.imageListServices.Images.SetKeyName(6, "veneers.jpg");
            this.imageListServices.Images.SetKeyName(7, "wisdom_extraction.jpg");
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btnPrevious.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(49, 513);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(145, 68);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btnNext.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(541, 513);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(145, 68);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbl_ServicesName
            // 
            this.lbl_ServicesName.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServicesName.ForeColor = System.Drawing.Color.Black;
            this.lbl_ServicesName.Location = new System.Drawing.Point(271, 503);
            this.lbl_ServicesName.Name = "lbl_ServicesName";
            this.lbl_ServicesName.Size = new System.Drawing.Size(185, 82);
            this.lbl_ServicesName.TabIndex = 4;
            this.lbl_ServicesName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_WorkingHours
            // 
            this.lbl_WorkingHours.AutoSize = true;
            this.lbl_WorkingHours.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WorkingHours.Location = new System.Drawing.Point(680, 162);
            this.lbl_WorkingHours.Name = "lbl_WorkingHours";
            this.lbl_WorkingHours.Size = new System.Drawing.Size(404, 56);
            this.lbl_WorkingHours.TabIndex = 5;
            this.lbl_WorkingHours.Text = "Working Hours";
            // 
            // lbl_TimeDay
            // 
            this.lbl_TimeDay.AutoSize = true;
            this.lbl_TimeDay.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeDay.Location = new System.Drawing.Point(694, 236);
            this.lbl_TimeDay.Name = "lbl_TimeDay";
            this.lbl_TimeDay.Size = new System.Drawing.Size(376, 186);
            this.lbl_TimeDay.TabIndex = 7;
            this.lbl_TimeDay.Text = "Monday: Friday: 9:00 AM – 6:00 PM \r\n(Lunch Hour: 1.00 PM - 2.00 PM)\r\n\r\nSaturday: " +
    "9:00 AM – 1:00 PM\r\n\r\nSunday: Closed\r\n";
            this.lbl_TimeDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTo_Appointment
            // 
            this.btnTo_Appointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.btnTo_Appointment.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTo_Appointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.btnTo_Appointment.Location = new System.Drawing.Point(942, 547);
            this.btnTo_Appointment.Name = "btnTo_Appointment";
            this.btnTo_Appointment.Size = new System.Drawing.Size(191, 82);
            this.btnTo_Appointment.TabIndex = 8;
            this.btnTo_Appointment.Text = "Make an Appointment";
            this.btnTo_Appointment.UseVisualStyleBackColor = false;
            // 
            // FormServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btnTo_Appointment);
            this.Controls.Add(this.lbl_TimeDay);
            this.Controls.Add(this.lbl_WorkingHours);
            this.Controls.Add(this.lbl_ServicesName);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.picBox_listServices);
            this.Controls.Add(this.lblServices);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Services";
            this.Load += new System.EventHandler(this.FormServices_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_listServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.PictureBox picBox_listServices;
        private System.Windows.Forms.ImageList imageListServices;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbl_ServicesName;
        private System.Windows.Forms.Label lbl_WorkingHours;
        private System.Windows.Forms.Label lbl_TimeDay;
        private System.Windows.Forms.Button btnTo_Appointment;
    }
}