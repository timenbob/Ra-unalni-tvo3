using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ploscadPlus
{
    public partial class Form1 : Form
    {
        public static Boolean gumbkliki = false;
        public static Boolean gibanje = false;
        public static int hitrost = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void gumb_Click(object sender, EventArgs e)
        {
            if (!gumbkliki)
            {
                gumbkliki = true;
                this.gumb.Text = "Ustavi";
                this.timer1.Start();

            }
            else
            {
                gumbkliki = false;
                this.gumb.Text = "Gibanje";
                this.timer1.Stop();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (this.button1.Location.X + this.button1.Width >= 300)
            {
                gibanje = true;
            }

            if (this.button1.Location.X <= 10)
            {
                gibanje = false;
            }

            if (this.button1.Location.X + this.button1.Width <= 300 && !gibanje)
            {
                button1.Location = new Point(button1.Location.X + hitrost, button1.Location.Y);
            }

            if (this.button1.Location.X >= 10 && gibanje)
            {
                button1.Location = new Point(button1.Location.X - hitrost, button1.Location.Y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hitrost += 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
