using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class AdminProfile : UserControl
    {
        public AdminProfile()
        {
            InitializeComponent();
        }
        AdminAddPanel aap = new AdminAddPanel();
        int aapf = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (aapf == 0)
            {
                this.Controls.Add(aap);
                aap.BringToFront();
                aapf = 1;
            }
            else
            {
                aap.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        AdminOwnerUpdate aou = new AdminOwnerUpdate();
        int aouf = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (aouf == 0)
            {
                this.Controls.Add(aou);
                aou.BringToFront();
                aouf = 1;
            }
            else
            {
                aou.Show();
            }
        }
        AdminDecoUpdate adu = new AdminDecoUpdate();
        int aduf = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (aduf == 0)
            {
                this.Controls.Add(adu);
                adu.BringToFront();
                aduf = 1;
            }
            else
            {
                adu.Show();
            }
        }
    }
}
