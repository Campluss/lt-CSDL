using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phatnguyen
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //DialogResult tb = MessageBox.Show("")
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Form2 frm = new Form2();
            frm.Show();*/
           //

            SqlConnection conn = new SqlConnection(@"Data Source=165068-NMNHAT\SQLEXPRESS;Initial Catalog=PNPdata;Integrated Security=True");
             try
             {
                 conn.Open();
                 string tk = txtUsername.Text;
                 string mk = txtPassword.Text;
                 string sql = "select *from tbLogin where Username= '" + tk + "' and Password='" + mk + "'";
                 SqlCommand cmd = new SqlCommand(sql, conn);
                 SqlDataReader dta = cmd.ExecuteReader();
                 if(dta.Read()== true)
                 {
                     this.Hide();                 
                     MessageBox.Show("Logged in successfully", "Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
                     frmHome frm = new frmHome();
                     frm.HelloName = txtUsername.Text;
                     frm.ShowDialog();

                 }
                 else
                 {
                     MessageBox.Show("Login failed", "Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
                     txtUsername.Text = "";
                     txtPassword.Text = "";
                     txtUsername.Focus();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("connection errors!,Xin thu lai?\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
        }
    }
}
