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
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
        }

        private void btnManageInforProduct_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.Show();
        }
    }
}
