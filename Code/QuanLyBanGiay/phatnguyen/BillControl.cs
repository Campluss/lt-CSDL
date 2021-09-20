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
    public partial class BillControl : UserControl
    {
        public BillControl()
        {
            InitializeComponent();
        }

        private void btnManageInforProduct_Click(object sender, EventArgs e)
        {
            frmBill frm = new frmBill();
            frm.Show();
        }
    }
}
