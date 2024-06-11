using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrizciInKrozci
{
    public partial class Form1 : Form
    {
        private bool Jekrizec = true;
        Button[,] polje = new Button[3,3];

        public Form1()
        {
            InitializeComponent();

            polje[0, 0] = button1;
            polje[0, 1] = button2;
            polje[0, 2] = button3;
            polje[1, 0] = button4;
            polje[1, 1] = button5;
            polje[1, 2] = button6;
            polje[2, 0] = button7;
            polje[2, 1] = button8;
            polje[2, 2] = button9;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button trenutniGumb = (Button)sender;
            
            if (trenutniGumb.Text == string.Empty)
            {
                if (Jekrizec)
                {
                    trenutniGumb.Text = "X";

                }
                else
                {
                    trenutniGumb.Text = "O";

                }

                Jekrizec = !Jekrizec;
            }
        }

        private bool konecIgre(string znak)
        {
            for (int i = 0; i < polje.Length; i++)
            {
                // po vrsticah
                if (polje[i,0].Text == znak  && polje[i, 1].Text == znak && polje[i, 2].Text == znak)
                {
                    return true;
                }
                // po stolpcih
                if (polje[0, i].Text == znak && polje[1, i].Text == znak && polje[2, i].Text == znak)
                {
                    return true;
                }
            }

            // po diagonalah
            if (polje[0, 0].Text == znak && polje[1, 1].Text == znak && polje[2, 2].Text == znak)
            {
                return true;
            }
            if (polje[0, 2].Text == znak && polje[1, 1].Text == znak && polje[2, 0].Text == znak)
            {
                return true;
            }

            // če ni konec
            return false;
        }
    }
}
