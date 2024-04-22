using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semafor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdeca_Click(object sender, EventArgs e)
        {
            this.semafor.BackColor=Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rumena_Click(object sender, EventArgs e)
        {
            this.semafor.BackColor = Color.Yellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.semafor.BackColor = Color.Green;
        }
    }
}
