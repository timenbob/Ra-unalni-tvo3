using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_je_moja_datoteka
{
    internal class ToJeMojaDatoteka
    {
        static void Main(string[] args)
        {
            string f = @"C:\Users\HP\source\repos\Programiranje_3\vaje3\vaje3\to je moja datoteka\vaja.txt";

            Console.Write("Napiši ime datoteke: ");
            String imeDat= Console.ReadLine();

            StreamWriter pisanje = File.CreateText(f);
            pisanje.WriteLine(imeDat);
            pisanje.Close();

            StreamReader branje = File.OpenText(f);
            string vrstica = branje.ReadLine();
            Console.WriteLine(vrstica);
            branje.Close(); 

            //pisanje.WriteLine(vrstica);
            StreamWriter dodajanje = File.AppendText(f);
            Console.Write("Vnesi ime: ");
            string ime = Console.ReadLine();
            dodajanje.WriteLine(ime);
            dodajanje.Close();

            StreamReader novobranje = File.OpenText(f);
            int i = 1;
            while ((vrstica = novobranje.ReadLine()) != null)
            {
                Console.WriteLine(i + ": " + vrstica);
                i++;
            }
            novobranje.Close();
        }
    }
}
