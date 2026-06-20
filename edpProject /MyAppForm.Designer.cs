namespace DentaNova
{
    partial class MyAppForm
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
            this.lblPatientName = new System.Windows.Forms.Label();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.coName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "MY APPOINTMENT";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(147, 153);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(161, 16);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Your Appointment History:";
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coName,
            this.colService,
            this.colDoctor,
            this.colTime,
            this.colStatus});
            this.dgvAppointment.Location = new System.Drawing.Point(150, 208);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.RowHeadersWidth = 51;
            this.dgvAppointment.RowTemplate.Height = 24;
            this.dgvAppointment.Size = new System.Drawing.Size(666, 150);
            this.dgvAppointment.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(150, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 79);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Appointment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(352, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 79);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // coName
            // 
            this.coName.HeaderText = "Name";
            this.coName.MinimumWidth = 6;
            this.coName.Name = "coName";
            this.coName.Width = 125;
            // 
            // colService
            // 
            this.colService.HeaderText = "Service";
            this.colService.MinimumWidth = 6;
            this.colService.Name = "colService";
            this.colService.Width = 125;
            // 
            // colDoctor
            // 
            this.colDoctor.HeaderText = "Doctor";
            this.colDoctor.MinimumWidth = 6;
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.Width = 125;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Time";
            this.colTime.MinimumWidth = 6;
            this.colTime.Name = "colTime";
            this.colTime.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 125;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(719, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 79);
            this.button3.TabIndex = 5;
            this.button3.Text = "Done";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MyAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1099, 545);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.label1);
            this.Name = "MyAppForm";
            this.Text = "My Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Button button3;
    }
}
