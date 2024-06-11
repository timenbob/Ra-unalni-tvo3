using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Obracamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static void Obrni(string imeVhod, string imeIzhod)
        {
            //potrebujemo povezovalni niz ter nato ustvariti povezave
            string vhod = imeVhod;
            string izhod = imeIzhod;
            StreamReader sr = File.OpenText(vhod); // sedaj jo bomo prebrali
            StreamWriter dat = File.CreateText(izhod); // ustvarimo datoteko

            string vrsta = sr.ReadLine(); // preberemo prvo vrstico
            while (vrsta != null)
            {
                StringBuilder novaVrstica = new StringBuilder();
                string[] posamezne = vrsta.Split(' ');

                for (int i = 0; i < posamezne.Length; i++)
                {
                    if (posamezne[i].StartsWith("-")) novaVrstica.Append($"{NovaBeseda(posamezne[i])} ");
                    else if (!string.IsNullOrWhiteSpace(posamezne[i])) novaVrstica.Append($"{posamezne[i]} ");
                }
                dat.WriteLine(novaVrstica.ToString().TrimEnd());//trim da se znebis zadjega presledka

            }






            sr.Close();
            dat.Close();




        }
        private static string NovaBeseda(string beseda)
        {
            beseda = beseda.Substring(1);
            string nova = "";
            for (int i = beseda.Length - 1; i >= 0; i--)
            {
                nova += beseda[i];
            }
            return nova;
        }
    }
    
}
