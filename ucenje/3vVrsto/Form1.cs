using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3vVrsto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ustvari();
        }

        private Button[,] mreza =new Button[3,3];
        private Boolean aliX=true;

        private void ustvari()
        {
            this.Text = "igra";
            int velikost = this.Height-20;
            int sirina =velikost/3;

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {

                    if (mreza[i, j] == null)
                    {
                        mreza[i, j] = new Button();
                        mreza[i, j].Click += new EventHandler(gumb_Click);
                        this.Controls.Add(mreza[i, j]);
                    }

                    Button gumb = mreza[i, j];
                    
                    gumb.Width = sirina;
                    gumb.Height = sirina;
                    gumb.Location = new Point(i * sirina, j * sirina);
                    
                }
            }

        }
        private void gumb_Click(object sender, EventArgs e)
        {
            Button gumb = sender as Button;
            if (gumb.Text == "")
            {
                if (aliX)
                {
                    gumb.Text = "X";
                }
                else
                {
                    gumb.Text = "O";
                }
                aliX = !aliX;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int maxi = Math.Max(this.Width, this.Height);
            this.Width = maxi;
            this.Height = maxi;
            ustvari();
        }
       

        private void Form1_ResizeEnd_1(object sender, EventArgs e)
        {
            int maxi = Math.Max(this.Width, this.Height);
            this.Width = maxi;
            this.Height = maxi;

            ustvari();
        }
    }
}

