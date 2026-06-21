namespace DITP2123_DentaNovaClinic
{
    partial class ServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.lbl_ourService = new System.Windows.Forms.Label();
            this.pictureBox_service = new System.Windows.Forms.PictureBox();
            this.imageListService = new System.Windows.Forms.ImageList(this.components);
            this.button_Prev = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.label_Service = new System.Windows.Forms.Label();
            this.label_WorkingHours = new System.Windows.Forms.Label();
            this.label_timeWorking = new System.Windows.Forms.Label();
            this.btn_makeAppoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_service)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ourService
            // 
            this.lbl_ourService.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ourService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.lbl_ourService.Location = new System.Drawing.Point(124, 29);
            this.lbl_ourService.Name = "lbl_ourService";
            this.lbl_ourService.Size = new System.Drawing.Size(414, 58);
            this.lbl_ourService.TabIndex = 2;
            this.lbl_ourService.Text = "Our Services\r\n";
            this.lbl_ourService.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox_service
            // 
            this.pictureBox_service.Location = new System.Drawing.Point(134, 110);
            this.pictureBox_service.Name = "pictureBox_service";
            this.pictureBox_service.Size = new System.Drawing.Size(400, 400);
            this.pictureBox_service.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_service.TabIndex = 3;
            this.pictureBox_service.TabStop = false;
            // 
            // imageListService
            // 
            this.imageListService.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListService.ImageStream")));
            this.imageListService.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListService.Images.SetKeyName(0, "checkup.jpg");
            this.imageListService.Images.SetKeyName(1, "dental cleaning.jpg");
            this.imageListService.Images.SetKeyName(2, "tooth filling.jpg");
            this.imageListService.Images.SetKeyName(3, "tooth extraction.jpg");
            this.imageListService.Images.SetKeyName(4, "wisdom extraction.png");
            this.imageListService.Images.SetKeyName(5, "teeth whitening.jpg");
            this.imageListService.Images.SetKeyName(6, "braces.jpg");
            this.imageListService.Images.SetKeyName(7, "veneers.jpg");
            // 
            // button_Prev
            // 
            this.button_Prev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.button_Prev.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Prev.ForeColor = System.Drawing.Color.White;
            this.button_Prev.Location = new System.Drawing.Point(58, 537);
            this.button_Prev.Name = "button_Prev";
            this.button_Prev.Size = new System.Drawing.Size(131, 74);
            this.button_Prev.TabIndex = 4;
            this.button_Prev.Text = "Previous";
            this.button_Prev.UseVisualStyleBackColor = false;
            this.button_Prev.Click += new System.EventHandler(this.button_Prev_Click);
            // 
            // button_Next
            // 
            this.button_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.button_Next.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Next.ForeColor = System.Drawing.Color.White;
            this.button_Next.Location = new System.Drawing.Point(466, 537);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(131, 74);
            this.button_Next.TabIndex = 5;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = false;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // label_Service
            // 
            this.label_Service.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Service.Location = new System.Drawing.Point(228, 552);
            this.label_Service.Name = "label_Service";
            this.label_Service.Size = new System.Drawing.Size(205, 92);
            this.label_Service.TabIndex = 6;
            this.label_Service.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_WorkingHours
            // 
            this.label_WorkingHours.AutoSize = true;
            this.label_WorkingHours.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WorkingHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.label_WorkingHours.Location = new System.Drawing.Point(656, 171);
            this.label_WorkingHours.Name = "label_WorkingHours";
            this.label_WorkingHours.Size = new System.Drawing.Size(433, 60);
            this.label_WorkingHours.TabIndex = 7;
            this.label_WorkingHours.Text = "Working Hours";
            this.label_WorkingHours.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_timeWorking
            // 
            this.label_timeWorking.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timeWorking.Location = new System.Drawing.Point(679, 253);
            this.label_timeWorking.Name = "label_timeWorking";
            this.label_timeWorking.Size = new System.Drawing.Size(383, 196);
            this.label_timeWorking.TabIndex = 8;
            this.label_timeWorking.Text = "Monday : Friday : 9 AM - 6 PM\r\n( Lunch Hour : 1 PM - 2 PM )\r\n\r\nSaturday : 9 AM - " +
    "1 PM\r\n\r\nSunday : CLOSE";
            this.label_timeWorking.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_makeAppoint
            // 
            this.btn_makeAppoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.btn_makeAppoint.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_makeAppoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.btn_makeAppoint.Location = new System.Drawing.Point(861, 567);
            this.btn_makeAppoint.Name = "btn_makeAppoint";
            this.btn_makeAppoint.Size = new System.Drawing.Size(300, 74);
            this.btn_makeAppoint.TabIndex = 9;
            this.btn_makeAppoint.Text = "Make an Appointment";
            this.btn_makeAppoint.UseVisualStyleBackColor = false;
            this.btn_makeAppoint.Click += new System.EventHandler(this.btn_makeAppoint_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btn_makeAppoint);
            this.Controls.Add(this.label_timeWorking);
            this.Controls.Add(this.label_WorkingHours);
            this.Controls.Add(this.label_Service);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Prev);
            this.Controls.Add(this.pictureBox_service);
            this.Controls.Add(this.lbl_ourService);
            this.Name = "ServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services & Woring Hours";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_service)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ourService;
        private System.Windows.Forms.PictureBox pictureBox_service;
        private System.Windows.Forms.ImageList imageListService;
        private System.Windows.Forms.Button button_Prev;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Label label_Service;
        private System.Windows.Forms.Label label_WorkingHours;
        private System.Windows.Forms.Label label_timeWorking;
        private System.Windows.Forms.Button btn_makeAppoint;
    }
}