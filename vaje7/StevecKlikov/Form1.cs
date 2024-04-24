using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StevecKlikov
{
    public partial class Form1 : Form
    {
        int stevec = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            stevec += 1;
            this.stevecKlikov.Text = "Števec Klikov  " + stevec;
        }
    }
}
