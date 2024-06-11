using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace NobelovciFilme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string povezava = "Server= baza.fmf.uni-lj.si; User Id= student11; Password= student; Database= nobel2012;";
            NpgsqlConnection conn= new NpgsqlConnection(povezava);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select * from Nobel Limit 10",conn);
            NpgsqlDataReader rez= cmd.ExecuteReader();
            while(rez.Read())
            {
                Console.WriteLine($"{rez[0]} {rez[1]} {rez[2]}");
            }

            conn.Close();

        }


    }
}
