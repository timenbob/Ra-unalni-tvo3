using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace N1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      

        
        

        /// <summary>
        /// za vnos v polju pogleda filme v tistem letu in vrne 10 filmov in "skupni čas"
        /// de deluje pravilno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // za podano leto poiščemo filme
            string ime = vnosimena.Text;
            string povezavaLink = @"Data Source = C:\Users\tb9218\source\repos\Programiranje_3\TimenBobnar_2Izpit_2023_24\N1\filmiIzpit.sqlite";
            SQLiteConnection povezava = new SQLiteConnection(povezavaLink);

            povezava.Open();

            SQLiteCommand ukaz = new SQLiteCommand();
            ukaz.Connection = povezava;
            ukaz.CommandType = System.Data.CommandType.Text;
            ukaz.CommandText = "SELECT naslov FROM Filmi" +
                "Where leto=ime";

            SQLiteDataReader rez = ukaz.ExecuteReader();
            int stevec = 1;
            while (rez.Read() || stevec != 10)
            {
                label3.Text = "" + rez.GetValue(0);
                stevec++;
            }

            povezava.Close();



            povezava.Open();

            SQLiteCommand ukaz2 = new SQLiteCommand();
            ukaz.Connection = povezava;
            ukaz.CommandType = System.Data.CommandType.Text;
            ukaz.CommandText = "SELECT sum(dolzin) FROM Filmi" +
                "Where leto=ime";

            SQLiteDataReader rez2 = ukaz.ExecuteReader();

            label4.Text = "" + rez.Read();
        }
    }
}
