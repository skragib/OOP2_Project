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
    }
}
