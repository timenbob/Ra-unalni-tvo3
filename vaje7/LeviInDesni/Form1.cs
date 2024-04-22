using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeviInDesni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Levi_MouseDown(object sender, MouseEventArgs e)
        {
            this.Besedilo.Text = "<-- pritisnjen";
        }

        private void ZbrisiNapis(object sender, MouseEventArgs e)
        {
            this.Besedilo.Text = "";
        }

        private void Desni_MouseDown(object sender, MouseEventArgs e)
        {
            this.Besedilo.Text = "pritisnjen-->";
        }
    }
}
