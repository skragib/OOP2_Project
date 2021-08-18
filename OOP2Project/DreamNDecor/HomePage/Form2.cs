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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button4.Text = "       "+Session.sName;
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            homeDefault1.BringToFront();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            aboutUs1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            homeDefault1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            decoProfile1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Session.sName = "zzz";
            this.Hide();
            ((Form2)this.TopLevelControl).Hide();
            Form1 f7 = new Form1();
            f7.Show();
        }
    }
}
