namespace DITP2123_DentaNovaClinic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBxLogo = new System.Windows.Forms.PictureBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.btnTo_Services = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBxLogo
            // 
            this.picBxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBxLogo.Image")));
            this.picBxLogo.Location = new System.Drawing.Point(69, 124);
            this.picBxLogo.Name = "picBxLogo";
            this.picBxLogo.Size = new System.Drawing.Size(403, 406);
            this.picBxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxLogo.TabIndex = 0;
            this.picBxLogo.TabStop = false;
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.Black;
            this.lblSlogan.Location = new System.Drawing.Point(189, 32);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(872, 67);
            this.lblSlogan.TabIndex = 1;
            this.lblSlogan.Text = "Because Every Smile Matters";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIntro
            // 
            this.lblIntro.Font = new System.Drawing.Font("Nirmala Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(93)))), ((int)(((byte)(78)))));
            this.lblIntro.Location = new System.Drawing.Point(545, 179);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(588, 318);
            this.lblIntro.TabIndex = 2;
            this.lblIntro.Text = resources.GetString("lblIntro.Text");
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTo_Services
            // 
            this.btnTo_Services.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.btnTo_Services.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTo_Services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.btnTo_Services.Location = new System.Drawing.Point(942, 547);
            this.btnTo_Services.Name = "btnTo_Services";
            this.btnTo_Services.Size = new System.Drawing.Size(191, 66);
            this.btnTo_Services.TabIndex = 3;
            this.btnTo_Services.Text = "Our Services";
            this.btnTo_Services.UseVisualStyleBackColor = false;
            this.btnTo_Services.Click += new System.EventHandler(this.btnTo_Services_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btnTo_Services);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.picBxLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBxLogo;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Button btnTo_Services;
    }
}

