using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzmenjavaBrav
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        bool bol = false;
        int oranz = 0;
        int vijol = 0;
        int zel = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bol= !bol;

            if (bol == true)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int barv = rnd.Next(3);
            if(barv == 0)
            {
                oranz++;
                panel1.BackColor = Color.Orange;
                oranzna.Text = "" + oranz;
            }
            if (barv == 1)
            {
                vijol++;
                panel1.BackColor = Color.Purple;
                vijola.Text = "" + vijol;
            }
            if (barv == 2)
            {
                zel++;
                panel1.BackColor = Color.Green;
                zelena.Text = "" + zel;
            }

        }
    }
}
