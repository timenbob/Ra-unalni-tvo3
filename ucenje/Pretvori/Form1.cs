using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pretvori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "") 
            {
               
                int cm=int.Parse(textBox1.Text);

                textBox2.Text = $"{cm/12}";
                textBox3.Text = $"{cm%12}";
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "") 
            {
                textBox1.Text = $"{int.Parse(textBox2.Text)+int.Parse(textBox3.Text)}";
            }

            else { textBox1.Text = "Pravilno izpolno"; }
            timer1.Start();

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
