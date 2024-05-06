using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefleksiFormule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int cas = 0;
        public int stevec = 0;
        public bool smo = false;

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (smo) {this.timer2.Stop();
            this.label1.Text = "" + cas; }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stevec++;
            int st =1+ stevec / 10 ;
            string imagePath = @"C:\Users\HP\source\repos\Programiranje_3\vaje7\RefleksiFormule\Slike\slika"+st+".png"; // Provide the path to your image file
            pictureBox1.Image = Image.FromFile(imagePath);
            
            // Add the PictureBox to the form
            this.Controls.Add(pictureBox1);
            if (st == 6) { this.timer1.Stop();this.timer2.Start();smo = true; }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cas++;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.timer2.Stop();
            cas = 0;
            stevec = 0;
            smo = false;
            this.label1.Text = "";
        }
    }
    
}
