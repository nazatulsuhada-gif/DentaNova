namespace DentaNova2
{
    partial class ManageDoctors
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
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.DoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(67, 136);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 16);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone :";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Location = new System.Drawing.Point(446, 51);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(50, 16);
            this.lblDoctorName.TabIndex = 2;
            this.lblDoctorName.Text = "Name :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(446, 136);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email : ";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Location = new System.Drawing.Point(810, 102);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(97, 16);
            this.lblSpecialization.TabIndex = 4;
            this.lblSpecialization.Text = "Specialization :";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Location = new System.Drawing.Point(70, 50);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(69, 16);
            this.lblDoctorID.TabIndex = 5;
            this.lblDoctorID.Text = "Doctor ID :";
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(155, 48);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(167, 22);
            this.txtDoctorID.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(155, 133);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(167, 22);
            this.txtPhone.TabIndex = 7;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(538, 51);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(167, 22);
            this.txtDoctorName.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(538, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.Location = new System.Drawing.Point(913, 96);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(167, 22);
            this.txtSpecialization.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.btnAdd.Location = new System.Drawing.Point(206, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 43);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Doctor";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.btnUpdate.Location = new System.Drawing.Point(469, 253);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(189, 43);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update Doctor";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.btnDelete.Location = new System.Drawing.Point(718, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 43);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorID,
            this.DoctorName,
            this.Specialization,
            this.Phone,
            this.Email});
            this.dgvDoctors.Location = new System.Drawing.Point(218, 315);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersWidth = 51;
            this.dgvDoctors.RowTemplate.Height = 24;
            this.dgvDoctors.Size = new System.Drawing.Size(674, 211);
            this.dgvDoctors.TabIndex = 14;
            // 
            // DoctorID
            // 
            this.DoctorID.HeaderText = "Doctor ID";
            this.DoctorID.MinimumWidth = 6;
            this.DoctorID.Name = "DoctorID";
            this.DoctorID.ReadOnly = true;
            this.DoctorID.Width = 125;
            // 
            // DoctorName
            // 
            this.DoctorName.HeaderText = "Doctor Name";
            this.DoctorName.MinimumWidth = 6;
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.ReadOnly = true;
            this.DoctorName.Width = 125;
            // 
            // Specialization
            // 
            this.Specialization.HeaderText = "Specialization";
            this.Specialization.MinimumWidth = 6;
            this.Specialization.Name = "Specialization";
            this.Specialization.ReadOnly = true;
            this.Specialization.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // ManageDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.dgvDoctors);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSpecialization);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.lblDoctorID);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.lblPhone);
            this.Name = "ManageDoctors";
            this.Text = "ManageDoctors";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

