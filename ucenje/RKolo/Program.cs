using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pov = "BicycleDataSlo.txt";
            Kolo[] kolesa= Kolo.ImportKolesa(pov);
            Dictionary<string,int> map = new Dictionary<string,int>();
            foreach (var k in kolesa)
            {
                string barva = k.Barva;
                if (map.ContainsKey(barva))
                {
                    // Povečamo število koles te barve
                    map[barva]++;
                }
                else
                {
                    // Dodamo novo barvo v slovar
                    map[barva] = 1;
                }


            }

            foreach (var entry in map)
            {
                Console.WriteLine($"Barva: {entry.Key}, Število koles: {entry.Value}");
            }
            Console.WriteLine();

            foreach (var entry in kolesa)
            {
                if (entry.Barva == "rumena") { entry.Barva = "rdeca"; }
            }
            //foreach (var entry in kolesa)
            //{
            //    Console.WriteLine($"Barva: {entry.Barva}");
            //}
            for (var i = 0; i < kolesa.Length; i++)
            {
                if (kolesa[i].Leto > 12) { kolesa[i] = null; }
            }






        }
    }

    public class Kolo
    {
        static int stKoles = 0;

        int steviloPrestav;
        string barva;
        string tip;
        int leto;
        int steviloLjudi;
        public int SteviloPrestav { get; set; }
        public string Barva { get; set; }
        public string Tip { get; set; }
        public int Leto { get; set; }
        public int SteviloLjudi { get; set; }

        public Kolo(int steviloPrestav, string barva, string tip, int leto, int steviloLjudi)
        {
            stKoles += 1;
            SteviloPrestav = steviloPrestav;
            Barva = barva;
            Tip = tip;
            Leto = leto;
            SteviloLjudi = steviloLjudi;
        }


        public void Napisi()
        {

            using (StreamWriter sw = new StreamWriter("shramba.txt"))
            {
                sw.WriteLine($"{this.Tip},{this.Barva},{this.Leto},{this.SteviloPrestav},{this.SteviloLjudi}");

            }

        }

        public static Kolo Ustvari(string vnos)
        {
            string[] vnossi = vnos.Split(',');
            
            
            return new Kolo(int.Parse(vnossi[3]), vnossi[1], vnossi[0], int.Parse(vnossi[2]), int.Parse(vnossi[4]));
        }

        public static Kolo[] ImportKolesa(string pot)
        {
            string[] lines = File.ReadAllLines(pot);//kul

            Kolo[] kolesa = new Kolo[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                kolesa[i] = Ustvari(lines[i]);
            }

            return kolesa;
        }

        





    }
}
