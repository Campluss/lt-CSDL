namespace phatnguyen
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gbxIPIFStaff = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxSearchStaff = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.txtAddressStaff = new System.Windows.Forms.TextBox();
            this.txtPhoneStaff = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxStaffList = new System.Windows.Forms.GroupBox();
            this.dgvwStaff = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHideForm = new System.Windows.Forms.Button();
            this.btnOffStaff = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxIPIFStaff.SuspendLayout();
            this.gbxStaffList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(689, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAFF";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(967, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 17);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // gbxIPIFStaff
            // 
            this.gbxIPIFStaff.Controls.Add(this.btnSearch);
            this.gbxIPIFStaff.Controls.Add(this.txtSearch);
            this.gbxIPIFStaff.Controls.Add(this.cbxSearchStaff);
            this.gbxIPIFStaff.Controls.Add(this.label8);
            this.gbxIPIFStaff.Controls.Add(this.btnUpdate);
            this.gbxIPIFStaff.Controls.Add(this.btnClose);
            this.gbxIPIFStaff.Controls.Add(this.btnDelete);
            this.gbxIPIFStaff.Controls.Add(this.btnSave);
            this.gbxIPIFStaff.Controls.Add(this.dtpDOB);
            this.gbxIPIFStaff.Controls.Add(this.cbxGender);
            this.gbxIPIFStaff.Controls.Add(this.txtAddressStaff);
            this.gbxIPIFStaff.Controls.Add(this.txtPhoneStaff);
            this.gbxIPIFStaff.Controls.Add(this.txtStaffName);
            this.gbxIPIFStaff.Controls.Add(this.txtStaffCode);
            this.gbxIPIFStaff.Controls.Add(this.label7);
            this.gbxIPIFStaff.Controls.Add(this.label6);
            this.gbxIPIFStaff.Controls.Add(this.label5);
            this.gbxIPIFStaff.Controls.Add(this.label4);
            this.gbxIPIFStaff.Controls.Add(this.label3);
            this.gbxIPIFStaff.Controls.Add(this.label2);
            this.gbxIPIFStaff.Location = new System.Drawing.Point(0, 372);
            this.gbxIPIFStaff.Name = "gbxIPIFStaff";
            this.gbxIPIFStaff.Size = new System.Drawing.Size(1067, 209);
            this.gbxIPIFStaff.TabIndex = 2;
            this.gbxIPIFStaff.TabStop = false;
            this.gbxIPIFStaff.Text = "Input Information";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(231, 175);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(208, 20);
            this.txtSearch.TabIndex = 18;
            // 
            // cbxSearchStaff
            // 
            this.cbxSearchStaff.FormattingEnabled = true;
            this.cbxSearchStaff.Location = new System.Drawing.Point(95, 174);
            this.cbxSearchStaff.Name = "cbxSearchStaff";
            this.cbxSearchStaff.Size = new System.Drawing.Size(121, 21);
            this.cbxSearchStaff.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Search:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(818, 186);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(927, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(709, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(600, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(675, 34);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(263, 20);
            this.dtpDOB.TabIndex = 9;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(176, 125);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(263, 21);
            this.cbxGender.TabIndex = 8;
            // 
            // txtAddressStaff
            // 
            this.txtAddressStaff.Location = new System.Drawing.Point(675, 146);
            this.txtAddressStaff.Name = "txtAddressStaff";
            this.txtAddressStaff.Size = new System.Drawing.Size(263, 20);
            this.txtAddressStaff.TabIndex = 11;
            // 
            // txtPhoneStaff
            // 
            this.txtPhoneStaff.Location = new System.Drawing.Point(675, 88);
            this.txtPhoneStaff.Name = "txtPhoneStaff";
            this.txtPhoneStaff.Size = new System.Drawing.Size(263, 20);
            this.txtPhoneStaff.TabIndex = 10;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(176, 78);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(263, 20);
            this.txtStaffName.TabIndex = 7;
            // 
            // txtStaffCode
            // 
            this.txtStaffCode.Location = new System.Drawing.Point(176, 31);
            this.txtStaffCode.Name = "txtStaffCode";
            this.txtStaffCode.Size = new System.Drawing.Size(263, 20);
            this.txtStaffCode.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staff Code:";
            // 
            // gbxStaffList
            // 
            this.gbxStaffList.Controls.Add(this.dgvwStaff);
            this.gbxStaffList.Location = new System.Drawing.Point(0, 587);
            this.gbxStaffList.Name = "gbxStaffList";
            this.gbxStaffList.Size = new System.Drawing.Size(1069, 290);
            this.gbxStaffList.TabIndex = 3;
            this.gbxStaffList.TabStop = false;
            this.gbxStaffList.Text = "Staff List";
            // 
            // dgvwStaff
            // 
            this.dgvwStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvwStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwStaff.Location = new System.Drawing.Point(0, 19);
            this.dgvwStaff.Name = "dgvwStaff";
            this.dgvwStaff.RowHeadersWidth = 62;
            this.dgvwStaff.Size = new System.Drawing.Size(1069, 271);
            this.dgvwStaff.TabIndex = 0;
            this.dgvwStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwStaff_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 10);
            this.panel2.TabIndex = 4;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::phatnguyen.Properties.Resources._122506333_204844561035484_2054085289668446746_o;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 337);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnHideForm
            // 
            this.btnHideForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnHideForm.FlatAppearance.BorderSize = 0;
            this.btnHideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideForm.Image = ((System.Drawing.Image)(resources.GetObject("btnHideForm.Image")));
            this.btnHideForm.Location = new System.Drawing.Point(1008, 12);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(32, 25);
            this.btnHideForm.TabIndex = 20;
            this.btnHideForm.UseVisualStyleBackColor = false;
            this.btnHideForm.Click += new System.EventHandler(this.btnHideForm_Click);
            // 
            // btnOffStaff
            // 
            this.btnOffStaff.FlatAppearance.BorderSize = 0;
            this.btnOffStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffStaff.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffStaff.ForeColor = System.Drawing.Color.White;
            this.btnOffStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnOffStaff.Image")));
            this.btnOffStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffStaff.Location = new System.Drawing.Point(1037, 12);
            this.btnOffStaff.Name = "btnOffStaff";
            this.btnOffStaff.Size = new System.Drawing.Size(32, 25);
            this.btnOffStaff.TabIndex = 21;
            this.btnOffStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOffStaff.UseVisualStyleBackColor = true;
            this.btnOffStaff.Click += new System.EventHandler(this.btnOffStaff_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(449, 175);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1069, 890);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHideForm);
            this.Controls.Add(this.btnOffStaff);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbxStaffList);
            this.Controls.Add(this.gbxIPIFStaff);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.gbxIPIFStaff.ResumeLayout(false);
            this.gbxIPIFStaff.PerformLayout();
            this.gbxStaffList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbxIPIFStaff;
        private System.Windows.Forms.GroupBox gbxStaffList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.TextBox txtAddressStaff;
        private System.Windows.Forms.TextBox txtPhoneStaff;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvwStaff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOffStaff;
        private System.Windows.Forms.Button btnHideForm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxSearchStaff;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}