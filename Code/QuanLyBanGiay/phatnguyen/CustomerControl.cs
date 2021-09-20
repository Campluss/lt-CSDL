using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phatnguyen
{
    public partial class CustomerControl : UserControl
    {
        public CustomerControl()
        {
            InitializeComponent();
        }

        private void btnManageInforProduct_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.Show();
        }
    }
}
