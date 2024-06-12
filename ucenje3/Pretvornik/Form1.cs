using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pretvornik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (textBox1.Text != "")
            {
                textBox2.Text = $"{double.Parse(textBox1.Text) / 30.44}";
                textBox3.Text = $" {double.Parse(textBox1.Text) % 30.44}";
            }
            else if(textBox2.Text!="" || textBox3.Text != "")
            {
                textBox1.Text= $"{double.Parse(textBox2.Text) * 30.44d +double.Parse(textBox3.Text)}";
            }
            else
            {
                textBox1.Text = "ne zajebavaj";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            timer1.Stop();
        }
    }
}
