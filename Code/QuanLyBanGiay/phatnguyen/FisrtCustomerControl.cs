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
    public partial class FisrtCustomerControl : UserControl
    {
        public FisrtCustomerControl()
        {
            InitializeComponent();
        }

        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void slidePic_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
