using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datoteke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hocemo odpret in neki vzet vn

            String povezavaLink = @"Data Source = C:\Users\HP\source\repos\Programiranje_3\ucenje\datoteke\filmi (1).sqlite";
            SQLiteConnection povezava = new SQLiteConnection(povezavaLink);

            povezava.Open();

            SQLiteCommand ukaz = new SQLiteCommand();
            ukaz.Connection= povezava;
            ukaz.CommandType = System.Data.CommandType.Text;
            ukaz.CommandText = "SELECT * FROM filmi";

            SQLiteDataReader rez = ukaz.ExecuteReader();


            while (rez.Read())
            {
                for (int i = 0; i < rez.FieldCount; i++)
                {
                    Console.Write(rez.GetValue(i) + "\t");
                }
                Console.WriteLine();
            }

            povezava.Close();
        }
    }
}
