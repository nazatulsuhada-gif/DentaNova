namespace DITP2123_DentaNovaClinic
{
    partial class LogInForm
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
            this.lblServices = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbl_firstTimeUser = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(444, 86);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(241, 85);
            this.lblServices.TabIndex = 1;
            this.lblServices.Text = "Login";
            this.lblServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.btnLogin.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.btnLogin.Location = new System.Drawing.Point(778, 423);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(146, 61);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbl_firstTimeUser
            // 
            this.lbl_firstTimeUser.AutoSize = true;
            this.lbl_firstTimeUser.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstTimeUser.Location = new System.Drawing.Point(412, 570);
            this.lbl_firstTimeUser.Name = "lbl_firstTimeUser";
            this.lbl_firstTimeUser.Size = new System.Drawing.Size(168, 31);
            this.lbl_firstTimeUser.TabIndex = 8;
            this.lbl_firstTimeUser.Text = "First time user?";
            this.lbl_firstTimeUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btnRegister.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(586, 558);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(213, 55);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register Now";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(476, 207);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(336, 22);
            this.textBoxEmail.TabIndex = 10;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbl_firstTimeUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblServices);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbl_firstTimeUser;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}