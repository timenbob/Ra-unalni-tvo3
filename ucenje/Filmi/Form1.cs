using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            string min_dolzina = textBox2.Text;

            // Ustvari seznam za shranjevanje označenih elementov iz CheckedListBox
            List<int> list = new List<int>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                list.Add(int.Parse(item.ToString()));
            }
            int max_ocena = 0;
            if (list.Count > 0)
            {
                max_ocena = list[0];
                foreach (int ocena in list)
                {
                    if (ocena > max_ocena)
                    {
                        max_ocena = ocena;
                    }
                }
            }

            String pov = @"Data Source = filmi.sqlite;Version=3;";
            SQLiteConnection povezava = new SQLiteConnection(pov);
            povezava.Open();
            SQLiteCommand ukaz = new SQLiteCommand($"SELECT naslov, leto FROM filmi WHERE dolzina > {min_dolzina} AND ocena > {max_ocena} Limit 10", povezava);
            SQLiteDataReader dat=ukaz.ExecuteReader();
            while (dat.Read())
            {
                label2.Text = label2.Text + dat[0].ToString()+";"+ dat[1].ToString()+"\n";
            }
            povezava.Close();

        }

        /// <summary>
        /// Skrbimo da so podatki konsistentni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label2.Text = "";
        }
    }
}
