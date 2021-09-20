namespace phatnguyen
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.productControl1 = new phatnguyen.ProductControl();
            this.billControl2 = new phatnguyen.BillControl();
            this.staffControl1 = new phatnguyen.StaffControl();
            this.customerControl1 = new phatnguyen.CustomerControl();
            this.fisrtCustomerControl1 = new phatnguyen.FisrtCustomerControl();
            this.btnHideForm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnBill);
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 601);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SidePanel.Location = new System.Drawing.Point(3, 112);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 10);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(819, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 19);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // productControl1
            // 
            this.productControl1.Location = new System.Drawing.Point(209, 149);
            this.productControl1.Margin = new System.Windows.Forms.Padding(4);
            this.productControl1.Name = "productControl1";
            this.productControl1.Size = new System.Drawing.Size(842, 452);
            this.productControl1.TabIndex = 15;
            // 
            // billControl2
            // 
            this.billControl2.Location = new System.Drawing.Point(209, 149);
            this.billControl2.Margin = new System.Windows.Forms.Padding(4);
            this.billControl2.Name = "billControl2";
            this.billControl2.Size = new System.Drawing.Size(842, 452);
            this.billControl2.TabIndex = 14;
            // 
            // staffControl1
            // 
            this.staffControl1.Location = new System.Drawing.Point(209, 149);
            this.staffControl1.Margin = new System.Windows.Forms.Padding(4);
            this.staffControl1.Name = "staffControl1";
            this.staffControl1.Size = new System.Drawing.Size(842, 452);
            this.staffControl1.TabIndex = 13;
            // 
            // customerControl1
            // 
            this.customerControl1.BackColor = System.Drawing.Color.White;
            this.customerControl1.Location = new System.Drawing.Point(209, 149);
            this.customerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.customerControl1.Name = "customerControl1";
            this.customerControl1.Size = new System.Drawing.Size(842, 452);
            this.customerControl1.TabIndex = 12;
            // 
            // fisrtCustomerControl1
            // 
            this.fisrtCustomerControl1.BackColor = System.Drawing.Color.White;
            this.fisrtCustomerControl1.Location = new System.Drawing.Point(209, 149);
            this.fisrtCustomerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.fisrtCustomerControl1.Name = "fisrtCustomerControl1";
            this.fisrtCustomerControl1.Size = new System.Drawing.Size(842, 452);
            this.fisrtCustomerControl1.TabIndex = 11;
            // 
            // btnHideForm
            // 
            this.btnHideForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHideForm.FlatAppearance.BorderSize = 0;
            this.btnHideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideForm.Image = ((System.Drawing.Image)(resources.GetObject("btnHideForm.Image")));
            this.btnHideForm.Location = new System.Drawing.Point(969, 18);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(32, 25);
            this.btnHideForm.TabIndex = 20;
            this.btnHideForm.UseVisualStyleBackColor = false;
            this.btnHideForm.Click += new System.EventHandler(this.btnHideForm_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1007, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(209, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(842, 187);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::phatnguyen.Properties.Resources.icons8_sneaker_128;
            this.pictureBox2.Location = new System.Drawing.Point(0, 452);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Gray;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::phatnguyen.Properties.Resources.icons8_product_30;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(12, 352);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(197, 54);
            this.btnProduct.TabIndex = 7;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnBill
            // 
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::phatnguyen.Properties.Resources.icons8_bill_30;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(3, 292);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(206, 54);
            this.btnBill.TabIndex = 6;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.Gray;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::phatnguyen.Properties.Resources.icons8_staff_30;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(3, 232);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(206, 54);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::phatnguyen.Properties.Resources.icons8_customer_30;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(12, 172);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(197, 54);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Gray;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::phatnguyen.Properties.Resources.icons8_home_30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 112);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(197, 54);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "         Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 601);
            this.Controls.Add(this.btnHideForm);
            this.Controls.Add(this.productControl1);
            this.Controls.Add(this.billControl2);
            this.Controls.Add(this.staffControl1);
            this.Controls.Add(this.customerControl1);
            this.Controls.Add(this.fisrtCustomerControl1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnStaff;
        private FisrtCustomerControl fisrtCustomerControl1;
        private CustomerControl customerControl1;
        private StaffControl staffControl1;
        private BillControl billControl2;
        private ProductControl productControl1;
        private System.Windows.Forms.Button btnHideForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
    }
}