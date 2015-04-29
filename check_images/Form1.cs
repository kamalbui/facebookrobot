using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace check_images
{
    public partial class Form1 : Form
    {
        string[] s;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void pics()
        {
            pictureBox1.ImageLocation = s[count];
            label1.Text = (59 - count).ToString();
            label2.Text = (count).ToString();
            count++;
            if (count == 58)
            {
                count = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = Directory.GetFiles(@"D:\kamal_ahmed\kamal bahria\1\fun\hu\random", "*", SearchOption.AllDirectories);
            int k = s.Length;
            if (k > 0)
            {
                timer1.Enabled = true;
            }
            else
                timer1.Enabled = false;         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pics();
        }
    }
}
