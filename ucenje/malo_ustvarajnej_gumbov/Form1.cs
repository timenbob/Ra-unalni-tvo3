using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malo_ustvarajnej_gumbov
{
    public partial class Form1 : Form
    {

        Button[,] polje=new Button[3,3];
        bool poteza = true;


        public Form1()
        {
            InitializeComponent();
            
        }


        private void ustavri()
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    polje[i, j] = new Button();
                    polje[i, j].Size = new Size(100, 100); // velikost gumba
                    polje[i, j].Location = new Point(i * 100, j * 100); // postavitev gumba
                    polje[i, j].Font = new Font("Arial", 24, FontStyle.Bold); // velikost pisave
                    polje[i, j].Click += new EventHandler(Gumb_Click); // dodelimo klik dogodek
                    this.Controls.Add(polje[i, j]);

                }
            }

        }

        private void Gumb_Click(object sender, EventArgs e)
        {
            Button gumb = sender as Button;
            if (gumb.Text == "")
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void klik(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            button1.Text = "Pašteta"; 
        }

        public void fun()
        {
            Button button2 = new System.Windows.Forms.Button();
            button2.Location = new System.Drawing.Point(138, 136);
            button2.Name = "button1";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(klik);
            this.Controls.Add(button2);
        }

        
    }
}
