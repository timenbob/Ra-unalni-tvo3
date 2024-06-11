using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odstevalnik
{
    public partial class Form1 : Form
    {

        int stevec = 9;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stevec--;
            if (stevec == 0)
            {
                timer1.Stop();
                button2.Enabled = false;
                button3.Enabled = false;
            }
            label1.Text = "" + stevec;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Enabled = true;
            button3.Enabled = true;
            stevec = 9;
            label1.Text = "" + stevec;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
