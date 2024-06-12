using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naloga5
{
    public partial class Form1 : Form
    {
        public static Random ran = new Random();
        int rezultat = 0;
        int zmage = 0;
        int porazi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rez;
            if( int.TryParse(textBox2.Text,out rez))
            {
                if (rez == rezultat) { zmage++; }
            }
            else { porazi++; }
            noviPrimer();
              
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            porazi++;
            timer1.Stop();
            noviPrimer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            noviPrimer();
        }

        private void noviPrimer()
        {
            int a = ran.Next(0, 100);
            int b = ran.Next(0, 100);
            pravilno.Text = "" + zmage;
            napacno.Text = "" + porazi;
            rezultat = a + b;
            label1.Text = $"{a}+{b}";
            timer1.Start();
            
        }
    }
}
