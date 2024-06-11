using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casovnik
{
    public partial class Form1 : Form
    {
        double cas = 0;
        bool gumb = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gumb == false) { timer1.Stop(); gumb = true; }
            else { timer1.Start(); gumb = false; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cas += 0.1;
            label1.Text = $"{cas}";
        }
    }
}
