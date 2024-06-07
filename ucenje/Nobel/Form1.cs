using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nobel
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
            string leto =textBox1.Text;
            string subjects = "";

            foreach (object item in checkedListBox1.CheckedItems)
            {
                subjects=subjects + "'"+item.ToString()+"',";
            }
            subjects=subjects.Substring(0, subjects.Length-1);

            string povNiz = "Server= baza.fmf.uni-lj.si; User Id= student11; Password= student; Database= nobel2012;";
            // Povezava s pomočjo Npgsql 
            NpgsqlConnection pov = new NpgsqlConnection(povNiz);
            pov.Open();
            // ustrezen ukaz v SQL
            string sql = $"SELECT winner FROM nobel where yr={leto} AND subject IN ({subjects})";
            NpgsqlCommand ukaz = new NpgsqlCommand();
            ukaz.Connection = pov;
            ukaz.CommandType = CommandType.Text;
            ukaz.CommandText = sql;
            NpgsqlDataReader rez = ukaz.ExecuteReader();
            while (rez.Read())
            {
                label2.Text=label2.Text + rez[0].ToString() + "\n";
                

            }
            if (label2.Text == "") { label2.Text = "Ni najdena nobena oseba"; };

            


            pov.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Moramo ugotoviti katera vsa področja so, da jih lahko vstavimo v CheckedListBox

            string povNiz = "Server= baza.fmf.uni-lj.si; User Id= student11; Password= student; Database= nobel2012;";
            // Povezava s pomočjo Npgsql 
            NpgsqlConnection pov = new NpgsqlConnection(povNiz);
            pov.Open();
            // ustrezen ukaz v SQL
            string sql = "SELECT subject FROM nobel group by subject";
            NpgsqlCommand ukaz = new NpgsqlCommand();
            ukaz.Connection = pov;
            ukaz.CommandType = CommandType.Text;
            ukaz.CommandText = sql;
            NpgsqlDataReader rez = ukaz.ExecuteReader();
            string[] subject = new string[8];//ker je 8 področji(vem da ni najboljše tako )
            int index = 0;
            while (rez.Read())
            {
                
                subject[index]=rez[0].ToString();
                index++;
                    
            }
                
            checkedListBox1.Items.AddRange(subject);
            

            pov.Close();
            

        }

        /// <summary>
        /// Skrbimo za konsistentnost podatkov
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label2.Text = "";
        }
    }
}
