using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pretvornik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.vpis_ft.Text=this.vpis_cm.Text;
            if (!string.IsNullOrWhiteSpace(this.vpis_cm.Text) )
            {
                if (double.TryParse(this.vpis_cm.Text, out double cm))
                {
                    double ft = cm / 30.48;
                    double inch = (cm % 30.48) / 2.54;

                    this.vpis_ft.Text = ft.ToString();
                    this.vpis_inch.Text = inch.ToString();
                }
                else
                {
                    MessageBox.Show("Vnesite veljavno število za centimetre.");
                }
            }

            else
            {
                MessageBox.Show("Vnesite vrednost.");
            }

        }
    }
}
