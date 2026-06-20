namespace dentanova_admin
{
    partial class FormManageAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.appointmentDGV = new System.Windows.Forms.DataGridView();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.completeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.nextTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active Appointments List :\r\n";
            // 
            // appointmentDGV
            // 
            this.appointmentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDGV.Location = new System.Drawing.Point(67, 107);
            this.appointmentDGV.Name = "appointmentDGV";
            this.appointmentDGV.Size = new System.Drawing.Size(1041, 245);
            this.appointmentDGV.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(196, 461);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(331, 32);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel Appointment";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // completeBtn
            // 
            this.completeBtn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeBtn.Location = new System.Drawing.Point(660, 461);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(295, 32);
            this.completeBtn.TabIndex = 2;
            this.completeBtn.Text = "Mark As Complete";
            this.completeBtn.UseVisualStyleBackColor = true;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.backBtn.Location = new System.Drawing.Point(1013, 569);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(95, 38);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Home";
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // nextTest
            // 
            this.nextTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.nextTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.nextTest.Location = new System.Drawing.Point(873, 569);
            this.nextTest.Name = "nextTest";
            this.nextTest.Size = new System.Drawing.Size(95, 38);
            this.nextTest.TabIndex = 6;
            this.nextTest.Text = "next";
            this.nextTest.UseVisualStyleBackColor = false;
            this.nextTest.Click += new System.EventHandler(this.nextTest_Click);
            // 
            // FormManageAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.nextTest);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.completeBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.appointmentDGV);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormManageAppointment";
            this.Text = "Admin- Manage Appointment";
            this.Load += new System.EventHandler(this.FormManageAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView appointmentDGV;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button completeBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button nextTest;
    }
}