using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semaforPlusPlus
{
    public partial class Form1 : Form
    {
        int stevec = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void rdeca_Click(object sender, EventArgs e)
        {
            this.semafor.BackColor = Color.Red;
            stevec = 0;
            this.semafor.Text = "" + stevec;
        }

        private void Rumena_Click(object sender, EventArgs e)
        {
            this.semafor.BackColor = Color.Yellow;
        }

        private void Zelena_Click(object sender, EventArgs e)
        {
            this.semafor.BackColor = Color.Green;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            stevec += 1;
            this.semafor.Text = ""+ stevec;
        }
    }
}
