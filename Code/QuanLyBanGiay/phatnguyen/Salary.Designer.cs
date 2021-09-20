namespace phatnguyen
{
    partial class frmSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalary));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxInfoSalary = new System.Windows.Forms.GroupBox();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkProbation = new System.Windows.Forms.CheckBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.cbxStaffCode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvwSalary = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalSalayList = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHideForm = new System.Windows.Forms.Button();
            this.btnOffStaff = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gbxInfoSalary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 10);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(755, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 17);
            this.lblID.TabIndex = 24;
            this.lblID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(369, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "SALARY";
            // 
            // gbxInfoSalary
            // 
            this.gbxInfoSalary.Controls.Add(this.txtTotalSalary);
            this.gbxInfoSalary.Controls.Add(this.label7);
            this.gbxInfoSalary.Controls.Add(this.btnClose);
            this.gbxInfoSalary.Controls.Add(this.btnDelete);
            this.gbxInfoSalary.Controls.Add(this.btnUpdate);
            this.gbxInfoSalary.Controls.Add(this.btnSave);
            this.gbxInfoSalary.Controls.Add(this.txtBonus);
            this.gbxInfoSalary.Controls.Add(this.label5);
            this.gbxInfoSalary.Controls.Add(this.txtHours);
            this.gbxInfoSalary.Controls.Add(this.label4);
            this.gbxInfoSalary.Controls.Add(this.chkProbation);
            this.gbxInfoSalary.Controls.Add(this.txtStaffName);
            this.gbxInfoSalary.Controls.Add(this.cbxStaffCode);
            this.gbxInfoSalary.Controls.Add(this.label3);
            this.gbxInfoSalary.Controls.Add(this.label2);
            this.gbxInfoSalary.Location = new System.Drawing.Point(12, 182);
            this.gbxInfoSalary.Name = "gbxInfoSalary";
            this.gbxInfoSalary.Size = new System.Drawing.Size(847, 175);
            this.gbxInfoSalary.TabIndex = 26;
            this.gbxInfoSalary.TabStop = false;
            this.gbxInfoSalary.Text = "Salary Information";
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.Location = new System.Drawing.Point(720, 79);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.Size = new System.Drawing.Size(89, 20);
            this.txtTotalSalary.TabIndex = 14;
            this.txtTotalSalary.TextChanged += new System.EventHandler(this.txtTotalSalary_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(648, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Salary:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Location = new System.Drawing.Point(746, 134);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(665, 134);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(584, 134);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(503, 134);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(396, 75);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(180, 20);
            this.txtBonus.TabIndex = 8;
            this.txtBonus.TextChanged += new System.EventHandler(this.txtBonus_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bonus:";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(720, 37);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(89, 20);
            this.txtHours.TabIndex = 6;
            this.txtHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hours Work:";
            // 
            // chkProbation
            // 
            this.chkProbation.AutoSize = true;
            this.chkProbation.Location = new System.Drawing.Point(89, 78);
            this.chkProbation.Name = "chkProbation";
            this.chkProbation.Size = new System.Drawing.Size(71, 17);
            this.chkProbation.TabIndex = 4;
            this.chkProbation.Text = "Probation";
            this.chkProbation.UseVisualStyleBackColor = true;
            this.chkProbation.CheckedChanged += new System.EventHandler(this.chkProbation_CheckedChanged);
            // 
            // txtStaffName
            // 
            this.txtStaffName.Enabled = false;
            this.txtStaffName.Location = new System.Drawing.Point(398, 36);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(180, 20);
            this.txtStaffName.TabIndex = 3;
            // 
            // cbxStaffCode
            // 
            this.cbxStaffCode.FormattingEnabled = true;
            this.cbxStaffCode.Location = new System.Drawing.Point(89, 36);
            this.cbxStaffCode.Name = "cbxStaffCode";
            this.cbxStaffCode.Size = new System.Drawing.Size(167, 21);
            this.cbxStaffCode.TabIndex = 2;
            this.cbxStaffCode.SelectedValueChanged += new System.EventHandler(this.cbxStaffCode_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Staff Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staff Code:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvwSalary);
            this.groupBox1.Location = new System.Drawing.Point(12, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 268);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Salary";
            // 
            // dgvwSalary
            // 
            this.dgvwSalary.BackgroundColor = System.Drawing.Color.White;
            this.dgvwSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwSalary.Location = new System.Drawing.Point(6, 19);
            this.dgvwSalary.Name = "dgvwSalary";
            this.dgvwSalary.RowHeadersWidth = 62;
            this.dgvwSalary.Size = new System.Drawing.Size(835, 243);
            this.dgvwSalary.TabIndex = 0;
            this.dgvwSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwSalary_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 659);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Salary expenses in this week:";
            // 
            // txtTotalSalayList
            // 
            this.txtTotalSalayList.Enabled = false;
            this.txtTotalSalayList.Location = new System.Drawing.Point(679, 656);
            this.txtTotalSalayList.Name = "txtTotalSalayList";
            this.txtTotalSalayList.Size = new System.Drawing.Size(174, 20);
            this.txtTotalSalayList.TabIndex = 29;
            this.txtTotalSalayList.TextChanged += new System.EventHandler(this.txtTotalSalayList_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::phatnguyen.Properties.Resources.brand1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(36, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 89);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btnHideForm
            // 
            this.btnHideForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnHideForm.FlatAppearance.BorderSize = 0;
            this.btnHideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideForm.Image = ((System.Drawing.Image)(resources.GetObject("btnHideForm.Image")));
            this.btnHideForm.Location = new System.Drawing.Point(789, 12);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(32, 25);
            this.btnHideForm.TabIndex = 23;
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
            this.btnOffStaff.Location = new System.Drawing.Point(827, 12);
            this.btnOffStaff.Name = "btnOffStaff";
            this.btnOffStaff.Size = new System.Drawing.Size(32, 25);
            this.btnOffStaff.TabIndex = 22;
            this.btnOffStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOffStaff.UseVisualStyleBackColor = true;
            this.btnOffStaff.Click += new System.EventHandler(this.btnOffStaff_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::phatnguyen.Properties.Resources.brand2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(188, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 89);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::phatnguyen.Properties.Resources.brand3;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(348, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 89);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::phatnguyen.Properties.Resources.brand4;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(510, 68);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(119, 89);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::phatnguyen.Properties.Resources.brand5;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(677, 68);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(119, 89);
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(873, 705);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTotalSalayList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxInfoSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnHideForm);
            this.Controls.Add(this.btnOffStaff);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.frmSalary_Load);
            this.gbxInfoSalary.ResumeLayout(false);
            this.gbxInfoSalary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOffStaff;
        private System.Windows.Forms.Button btnHideForm;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxInfoSalary;
        private System.Windows.Forms.ComboBox cbxStaffCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkProbation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvwSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalSalayList;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}