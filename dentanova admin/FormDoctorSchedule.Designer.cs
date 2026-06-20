namespace dentanova_admin
{
    partial class FormDoctorSchedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.nameComboBx = new System.Windows.Forms.ComboBox();
            this.dayCheckListBx = new System.Windows.Forms.CheckedListBox();
            this.startDTP = new System.Windows.Forms.DateTimePicker();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            this.sttsGrpBx = new System.Windows.Forms.GroupBox();
            this.notAvailableRB = new System.Windows.Forms.RadioButton();
            this.availableRB = new System.Windows.Forms.RadioButton();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.scheduleDGV = new System.Windows.Forms.DataGridView();
            this.doctorScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentaNovaDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentaNovaDataset = new dentanova_admin.DentaNovaDataset();
            this.nextTest = new System.Windows.Forms.Button();
            this.doctorCB = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new dentanova_admin.DentaNovaDatasetTableAdapters.DoctorTableAdapter();
            this.sttsGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentaNovaDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentaNovaDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(809, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(846, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(36, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "Working \r\nDay:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(818, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "End Time:";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.backBtn.Location = new System.Drawing.Point(1036, 620);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(95, 38);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Home";
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // nameComboBx
            // 
            this.nameComboBx.FormattingEnabled = true;
            this.nameComboBx.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.nameComboBx.Location = new System.Drawing.Point(132, 49);
            this.nameComboBx.Name = "nameComboBx";
            this.nameComboBx.Size = new System.Drawing.Size(0, 33);
            this.nameComboBx.TabIndex = 2;
            // 
            // dayCheckListBx
            // 
            this.dayCheckListBx.FormattingEnabled = true;
            this.dayCheckListBx.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.dayCheckListBx.Location = new System.Drawing.Point(138, 98);
            this.dayCheckListBx.Name = "dayCheckListBx";
            this.dayCheckListBx.Size = new System.Drawing.Size(151, 200);
            this.dayCheckListBx.TabIndex = 3;
            this.dayCheckListBx.SelectedIndexChanged += new System.EventHandler(this.dayCheckListBx_SelectedIndexChanged);
            // 
            // startDTP
            // 
            this.startDTP.CustomFormat = "HH:mm ";
            this.startDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDTP.Location = new System.Drawing.Point(923, 44);
            this.startDTP.Name = "startDTP";
            this.startDTP.ShowUpDown = true;
            this.startDTP.Size = new System.Drawing.Size(208, 33);
            this.startDTP.TabIndex = 4;
            // 
            // endDTP
            // 
            this.endDTP.CustomFormat = "HH:mm";
            this.endDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDTP.Location = new System.Drawing.Point(923, 103);
            this.endDTP.Name = "endDTP";
            this.endDTP.ShowUpDown = true;
            this.endDTP.Size = new System.Drawing.Size(208, 33);
            this.endDTP.TabIndex = 4;
            // 
            // sttsGrpBx
            // 
            this.sttsGrpBx.Controls.Add(this.notAvailableRB);
            this.sttsGrpBx.Controls.Add(this.availableRB);
            this.sttsGrpBx.Location = new System.Drawing.Point(923, 151);
            this.sttsGrpBx.Name = "sttsGrpBx";
            this.sttsGrpBx.Size = new System.Drawing.Size(208, 91);
            this.sttsGrpBx.TabIndex = 5;
            this.sttsGrpBx.TabStop = false;
            // 
            // notAvailableRB
            // 
            this.notAvailableRB.AutoSize = true;
            this.notAvailableRB.Location = new System.Drawing.Point(7, 56);
            this.notAvailableRB.Name = "notAvailableRB";
            this.notAvailableRB.Size = new System.Drawing.Size(149, 29);
            this.notAvailableRB.TabIndex = 1;
            this.notAvailableRB.TabStop = true;
            this.notAvailableRB.Text = "Not Available";
            this.notAvailableRB.UseVisualStyleBackColor = true;
            // 
            // availableRB
            // 
            this.availableRB.AutoSize = true;
            this.availableRB.Location = new System.Drawing.Point(7, 21);
            this.availableRB.Name = "availableRB";
            this.availableRB.Size = new System.Drawing.Size(110, 29);
            this.availableRB.TabIndex = 0;
            this.availableRB.TabStop = true;
            this.availableRB.Text = "Available";
            this.availableRB.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(360, 286);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(104, 42);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(548, 286);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(104, 42);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(740, 286);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(104, 42);
            this.delBtn.TabIndex = 7;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // scheduleDGV
            // 
            this.scheduleDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scheduleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDGV.Location = new System.Drawing.Point(66, 334);
            this.scheduleDGV.Name = "scheduleDGV";
            this.scheduleDGV.Size = new System.Drawing.Size(1065, 271);
            this.scheduleDGV.TabIndex = 8;
            this.scheduleDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scheduleDGV_CellClick);
            // 
            // doctorScheduleBindingSource
            // 
            this.doctorScheduleBindingSource.DataMember = "DoctorSchedule";
            this.doctorScheduleBindingSource.DataSource = this.dentaNovaDatasetBindingSource;
            // 
            // dentaNovaDatasetBindingSource
            // 
            this.dentaNovaDatasetBindingSource.DataSource = this.dentaNovaDataset;
            this.dentaNovaDatasetBindingSource.Position = 0;
            // 
            // dentaNovaDataset
            // 
            this.dentaNovaDataset.DataSetName = "DentaNovaDataset";
            this.dentaNovaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nextTest
            // 
            this.nextTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(169)))));
            this.nextTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(153)))));
            this.nextTest.Location = new System.Drawing.Point(851, 620);
            this.nextTest.Name = "nextTest";
            this.nextTest.Size = new System.Drawing.Size(95, 38);
            this.nextTest.TabIndex = 1;
            this.nextTest.Text = "next";
            this.nextTest.UseVisualStyleBackColor = false;
            this.nextTest.Click += new System.EventHandler(this.nextTest_Click);
            // 
            // doctorCB
            // 
            this.doctorCB.DataSource = this.doctorBindingSource;
            this.doctorCB.DisplayMember = "doctorName";
            this.doctorCB.FormattingEnabled = true;
            this.doctorCB.Location = new System.Drawing.Point(138, 42);
            this.doctorCB.Name = "doctorCB";
            this.doctorCB.Size = new System.Drawing.Size(627, 33);
            this.doctorCB.TabIndex = 9;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.dentaNovaDatasetBindingSource;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // FormDoctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.doctorCB);
            this.Controls.Add(this.scheduleDGV);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.sttsGrpBx);
            this.Controls.Add(this.endDTP);
            this.Controls.Add(this.startDTP);
            this.Controls.Add(this.dayCheckListBx);
            this.Controls.Add(this.nameComboBx);
            this.Controls.Add(this.nextTest);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormDoctorSchedule";
            this.Text = "Admin - Doctor Schedule";
            this.Load += new System.EventHandler(this.FormDoctorSchedule_Load);
            this.sttsGrpBx.ResumeLayout(false);
            this.sttsGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentaNovaDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentaNovaDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox nameComboBx;
        private System.Windows.Forms.CheckedListBox dayCheckListBx;
        private System.Windows.Forms.DateTimePicker startDTP;
        private System.Windows.Forms.DateTimePicker endDTP;
        private System.Windows.Forms.GroupBox sttsGrpBx;
        private System.Windows.Forms.RadioButton notAvailableRB;
        private System.Windows.Forms.RadioButton availableRB;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.DataGridView scheduleDGV;
        private System.Windows.Forms.BindingSource dentaNovaDatasetBindingSource;
        private DentaNovaDataset dentaNovaDataset;
        private System.Windows.Forms.BindingSource doctorScheduleBindingSource;
        private System.Windows.Forms.Button nextTest;
        private System.Windows.Forms.ComboBox doctorCB;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private DentaNovaDatasetTableAdapters.DoctorTableAdapter doctorTableAdapter;
    }
}

