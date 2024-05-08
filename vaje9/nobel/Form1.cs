using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;

namespace nobel
{

    class Nobel_osnova
    {
        static void Main(string[] args)
        {   
            
            string povNiz = "Server= C:\\Users\\tb9218\\source\\repos\\Programiranje_3\\vaje9\\nobelDB.db;";
            SQLiteConnection pov = new SQLiteConnection(povNiz);
            pov.Open();
            string sql = "SELECT yr FROM nobel GROUP BY yr";
            SQLiteCommand ukaz = new SQLiteCommand();
            ukaz.Connection = pov;
            ukaz.CommandType = CommandType.Text;
            ukaz.CommandText = sql;
            SQLiteDataReader rez = ukaz.ExecuteReader();
            while (rez.Read()) 
            {
                string izp = rez[0].ToString();
                Console.Write(izp + " : ");
            }
            pov.Close();
        } 
    }


    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
