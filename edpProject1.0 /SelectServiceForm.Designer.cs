namespace edpProject2
{
    partial class SelectServiceForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.groupBoxServices = new System.Windows.Forms.GroupBox();
            this.rbBraces = new System.Windows.Forms.RadioButton();
            this.rbWisdom = new System.Windows.Forms.RadioButton();
            this.rbVeneers = new System.Windows.Forms.RadioButton();
            this.rbTooth = new System.Windows.Forms.RadioButton();
            this.rbWhitening = new System.Windows.Forms.RadioButton();
            this.rbFilling = new System.Windows.Forms.RadioButton();
            this.rbCleaning = new System.Windows.Forms.RadioButton();
            this.rbConsultation = new System.Windows.Forms.RadioButton();
            this.groupBoxServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F);
            this.lblWelcome.Location = new System.Drawing.Point(430, 89);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(210, 44);
            this.lblWelcome.TabIndex = 30;
            this.lblWelcome.Text = "Welcome,";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.btnBack.Location = new System.Drawing.Point(80, 548);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(195, 60);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.btnProceed.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnProceed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.btnProceed.Location = new System.Drawing.Point(918, 548);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(195, 60);
            this.btnProceed.TabIndex = 28;
            this.btnProceed.Text = "Proceed to Doctor";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // groupBoxServices
            // 
            this.groupBoxServices.Controls.Add(this.rbBraces);
            this.groupBoxServices.Controls.Add(this.rbWisdom);
            this.groupBoxServices.Controls.Add(this.rbVeneers);
            this.groupBoxServices.Controls.Add(this.rbTooth);
            this.groupBoxServices.Controls.Add(this.rbWhitening);
            this.groupBoxServices.Controls.Add(this.rbFilling);
            this.groupBoxServices.Controls.Add(this.rbCleaning);
            this.groupBoxServices.Controls.Add(this.rbConsultation);
            this.groupBoxServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxServices.Location = new System.Drawing.Point(173, 187);
            this.groupBoxServices.Name = "groupBoxServices";
            this.groupBoxServices.Size = new System.Drawing.Size(839, 290);
            this.groupBoxServices.TabIndex = 31;
            this.groupBoxServices.TabStop = false;
            this.groupBoxServices.Text = "Please select a dental service: ";
            // 
            // rbBraces
            // 
            this.rbBraces.AutoSize = true;
            this.rbBraces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbBraces.Location = new System.Drawing.Point(530, 224);
            this.rbBraces.Name = "rbBraces";
            this.rbBraces.Size = new System.Drawing.Size(86, 28);
            this.rbBraces.TabIndex = 37;
            this.rbBraces.TabStop = true;
            this.rbBraces.Text = "Braces";
            this.rbBraces.UseVisualStyleBackColor = true;
            // 
            // rbWisdom
            // 
            this.rbWisdom.AutoSize = true;
            this.rbWisdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbWisdom.Location = new System.Drawing.Point(530, 118);
            this.rbWisdom.Name = "rbWisdom";
            this.rbWisdom.Size = new System.Drawing.Size(185, 28);
            this.rbWisdom.TabIndex = 35;
            this.rbWisdom.TabStop = true;
            this.rbWisdom.Text = "Wisdom Extraction";
            this.rbWisdom.UseVisualStyleBackColor = true;
            // 
            // rbVeneers
            // 
            this.rbVeneers.AutoSize = true;
            this.rbVeneers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbVeneers.Location = new System.Drawing.Point(530, 174);
            this.rbVeneers.Name = "rbVeneers";
            this.rbVeneers.Size = new System.Drawing.Size(100, 28);
            this.rbVeneers.TabIndex = 36;
            this.rbVeneers.TabStop = true;
            this.rbVeneers.Text = "Veneers";
            this.rbVeneers.UseVisualStyleBackColor = true;
            // 
            // rbTooth
            // 
            this.rbTooth.AutoSize = true;
            this.rbTooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbTooth.Location = new System.Drawing.Point(530, 62);
            this.rbTooth.Name = "rbTooth";
            this.rbTooth.Size = new System.Drawing.Size(165, 28);
            this.rbTooth.TabIndex = 34;
            this.rbTooth.TabStop = true;
            this.rbTooth.Text = "Tooth Extraction";
            this.rbTooth.UseVisualStyleBackColor = true;
            // 
            // rbWhitening
            // 
            this.rbWhitening.AutoSize = true;
            this.rbWhitening.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbWhitening.Location = new System.Drawing.Point(115, 224);
            this.rbWhitening.Name = "rbWhitening";
            this.rbWhitening.Size = new System.Drawing.Size(167, 28);
            this.rbWhitening.TabIndex = 33;
            this.rbWhitening.TabStop = true;
            this.rbWhitening.Text = "Teeth Whitening";
            this.rbWhitening.UseVisualStyleBackColor = true;
            // 
            // rbFilling
            // 
            this.rbFilling.AutoSize = true;
            this.rbFilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbFilling.Location = new System.Drawing.Point(115, 118);
            this.rbFilling.Name = "rbFilling";
            this.rbFilling.Size = new System.Drawing.Size(136, 28);
            this.rbFilling.TabIndex = 28;
            this.rbFilling.TabStop = true;
            this.rbFilling.Text = "Dental Filling";
            this.rbFilling.UseVisualStyleBackColor = true;
            // 
            // rbCleaning
            // 
            this.rbCleaning.AutoSize = true;
            this.rbCleaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbCleaning.Location = new System.Drawing.Point(115, 174);
            this.rbCleaning.Name = "rbCleaning";
            this.rbCleaning.Size = new System.Drawing.Size(336, 28);
            this.rbCleaning.TabIndex = 32;
            this.rbCleaning.TabStop = true;
            this.rbCleaning.Text = "Teeth Cleaning (Scalling | Polishing )";
            this.rbCleaning.UseVisualStyleBackColor = true;
            // 
            // rbConsultation
            // 
            this.rbConsultation.AutoSize = true;
            this.rbConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbConsultation.Location = new System.Drawing.Point(115, 62);
            this.rbConsultation.Name = "rbConsultation";
            this.rbConsultation.Size = new System.Drawing.Size(189, 28);
            this.rbConsultation.TabIndex = 27;
            this.rbConsultation.TabStop = true;
            this.rbConsultation.Text = "Dental Consultation";
            this.rbConsultation.UseVisualStyleBackColor = true;
            // 
            // SelectServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.groupBoxServices);
            this.Name = "SelectServiceForm";
            this.Load += new System.EventHandler(this.SelectServiceForm_Load);
            this.groupBoxServices.ResumeLayout(false);
            this.groupBoxServices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.GroupBox groupBoxServices;
        private System.Windows.Forms.RadioButton rbWhitening;
        private System.Windows.Forms.RadioButton rbFilling;
        private System.Windows.Forms.RadioButton rbCleaning;
        private System.Windows.Forms.RadioButton rbConsultation;
        private System.Windows.Forms.RadioButton rbBraces;
        private System.Windows.Forms.RadioButton rbWisdom;
        private System.Windows.Forms.RadioButton rbVeneers;
        private System.Windows.Forms.RadioButton rbTooth;
    }
}

