namespace DITP2123_DentaNovaClinic
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.label_slogan = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_abtUs = new System.Windows.Forms.Label();
            this.button_Services = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_slogan
            // 
            this.label_slogan.AutoSize = true;
            this.label_slogan.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_slogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.label_slogan.Location = new System.Drawing.Point(44, 25);
            this.label_slogan.Name = "label_slogan";
            this.label_slogan.Size = new System.Drawing.Size(1091, 78);
            this.label_slogan.TabIndex = 0;
            this.label_slogan.Text = "Because Every Smiles Matters";
            this.label_slogan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_logo.Image = global::DITP2123_DentaNovaClinic.Properties.Resources.DentaNova_Logo__1_;
            this.pictureBox_logo.Location = new System.Drawing.Point(12, 124);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(543, 460);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 1;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_abtUs
            // 
            this.label_abtUs.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_abtUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.label_abtUs.Location = new System.Drawing.Point(561, 173);
            this.label_abtUs.Name = "label_abtUs";
            this.label_abtUs.Size = new System.Drawing.Size(550, 368);
            this.label_abtUs.TabIndex = 2;
            this.label_abtUs.Text = resources.GetString("label_abtUs.Text");
            this.label_abtUs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_Services
            // 
            this.button_Services.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.button_Services.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.button_Services.Location = new System.Drawing.Point(971, 553);
            this.button_Services.Name = "button_Services";
            this.button_Services.Size = new System.Drawing.Size(186, 79);
            this.button_Services.TabIndex = 10;
            this.button_Services.Text = "Our Services";
            this.button_Services.UseVisualStyleBackColor = false;
            this.button_Services.Click += new System.EventHandler(this.button_OurServices_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.button_Services);
            this.Controls.Add(this.label_abtUs);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.label_slogan);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome To DentaNova";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_slogan;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_abtUs;
        private System.Windows.Forms.Button button_Services;
    }
}