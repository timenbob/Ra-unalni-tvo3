using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semafor
{
    public partial class Form1 : Form
    {
        int stevec = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.BackColor = Color.White;
            label2.BackColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stevec % 2 != 0)
            {
                label1.BackColor = Color.White;
                label2.BackColor = Color.Red;
            }
            else
            {
                label1.BackColor = Color.Red;
                label2.BackColor = Color.White;
            }

            stevec++;
        }
    }
}
