using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrizciKrozci
{
    public partial class Form1 : Form
    {
        Button[,] polje;

        public Form1()
        {
            InitializeComponent();
            Ustvaripolje();
        }

        public void Ustvaripolje()
        {
            polje = new Button[3, 3];
            velikost

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    polje[i,j]= new Button();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
