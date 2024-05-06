using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nemogoce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        public static Boolean gibanje = false;
        public static int hitrost = 1;
        public int[] vektor = new int[] { 1, -1 };
        private void timer1_Tick(object sender, EventArgs e)
        {   
            if((this.button1.Location.Y + this.button1.Height == this.ClientSize.Height && this.button1.Location.X == 0)||
                (this.button1.Location.Y + this.button1.Height == this.ClientSize.Height && this.button1.Location.X + this.button1.Width == this.ClientSize.Width) ||
                (this.button1.Location.Y ==0 && this.button1.Location.X == 0) ||
                (this.button1.Location.Y ==0 && this.button1.Location.X + this.button1.Width == this.ClientSize.Width) 
                )
            {
                this.timer1.Stop();
                this.button1.Location = new Point(10, 10);
                this.button1.BackColor = Color.Red;
                this.button1.Hide();
                this.BackColor = Color.Red;
            }
            if(this.button1.Location.X == 0)
            {
                vektor[0] = 1;
            }

            if (this.button1.Location.X+ this.button1.Width == this.ClientSize.Width)
            {
                vektor[0] = -1;
            }

            if (this.button1.Location.Y == 0)
            {
                vektor[1] = 1;
            }

            if (this.button1.Location.Y + this.button1.Height == this.ClientSize.Height)
            {
                vektor[1] = -1;

            }

            

            else { button1.Location = new Point(button1.Location.X + vektor[0], button1.Location.Y + vektor[1]); }

            
        }
    }
}
