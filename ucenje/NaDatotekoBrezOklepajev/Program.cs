using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaDatotekoBrezOklepajev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrezOklepajev("dat.txt", "fil1.txt");
        }

        public static void BrezOklepajev(string imeVhod, string imeIzhod)
        {
            //potrebujemo povezovalni niz ter nato ustvariti povezave
            string vhod = imeVhod;
            string izhod = imeIzhod;
            StreamReader sr = File.OpenText(vhod); // sedaj jo bomo prebrali
            StreamWriter dat = File.CreateText(izhod); // ustvarimo datoteko

            string vrst = sr.ReadLine(); // preberemo prvo vrstico
            bool stevec = false;
            bool res = true;
            while(vrst!=null)
            {
                if (!PravilniOklepaji(vrst)) dat.WriteLine("NAPAKA");
                else dat.WriteLine($"{OdstraniBesedo(vrst)}");
                vrst =sr.ReadLine();
            }
            

            



            sr.Close();
            dat.Close();


            

        }

        public static bool PravilniOklepaji(string vrstica)
        {
            int oklepaj = 0;
            int zaklepaj = 0;

            foreach (char znak in vrstica)
            {
                if (zaklepaj < 0 && oklepaj == 0) return false;
                else if (znak == '(') oklepaj++;
                else if (znak == ')') zaklepaj--;
            }

            if (oklepaj + zaklepaj == 0) return true;
            else return false;
        }

        public static string OdstraniBesedo(string vrstica)
        {
            string novaVrstica = "";
            bool pavza = false;
            foreach (char znak in vrstica)
            {
                if (znak == '(') pavza = true;
                if (znak == ')') pavza = false;
                else if (pavza is false)
                {
                    novaVrstica += znak;
                }

            }
            return novaVrstica;
        }
    }
}
