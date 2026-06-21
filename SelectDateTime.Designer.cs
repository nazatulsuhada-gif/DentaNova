namespace DentaNova2
{
    partial class SelectDateTime
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
            this.lblChooseDate = new System.Windows.Forms.Label();
            this.lblAvailableSlots = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.flowTimeSlots = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseDate
            // 
            this.lblChooseDate.AutoSize = true;
            this.lblChooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseDate.Location = new System.Drawing.Point(102, 73);
            this.lblChooseDate.Name = "lblChooseDate";
            this.lblChooseDate.Size = new System.Drawing.Size(138, 25);
            this.lblChooseDate.TabIndex = 0;
            this.lblChooseDate.Text = "Choose Date :";
            // 
            // lblAvailableSlots
            // 
            this.lblAvailableSlots.AutoSize = true;
            this.lblAvailableSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableSlots.Location = new System.Drawing.Point(705, 73);
            this.lblAvailableSlots.Name = "lblAvailableSlots";
            this.lblAvailableSlots.Size = new System.Drawing.Size(152, 25);
            this.lblAvailableSlots.TabIndex = 1;
            this.lblAvailableSlots.Text = "Available Slots :";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(107, 156);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // flowTimeSlots
            // 
            this.flowTimeSlots.AutoScroll = true;
            this.flowTimeSlots.Location = new System.Drawing.Point(646, 176);
            this.flowTimeSlots.Name = "flowTimeSlots";
            this.flowTimeSlots.Size = new System.Drawing.Size(311, 164);
            this.flowTimeSlots.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.btnBack.Location = new System.Drawing.Point(27, 564);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 43);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.btnNext.Font = new System.Drawing.Font("Nirmala UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.btnNext.Location = new System.Drawing.Point(1001, 564);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 43);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // SelectDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.flowTimeSlots);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblAvailableSlots);
            this.Controls.Add(this.lblChooseDate);
            this.Name = "SelectDateTime";
            this.Text = "Date & Time";
            this.Load += new System.EventHandler(this.SelectDateTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseDate;
        private System.Windows.Forms.Label lblAvailableSlots;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.FlowLayoutPanel flowTimeSlots;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
    }
}