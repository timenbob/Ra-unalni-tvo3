using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace tets
{
    internal class Program
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
}
