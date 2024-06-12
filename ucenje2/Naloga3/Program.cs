using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            metoda("vnos.txt", "izhod.txt");
        }

        public static void metoda(string vhod, string izhod)
        {


            using (StreamReader sr = new StreamReader(vhod))
            {
                
                string[] naslovi= sr.ReadLine().Split(',');//preberemmo prvo
                using (StreamWriter sw = new StreamWriter(izhod))
                {
   
                    string vrstica;
                    while ((vrstica = sr.ReadLine()) != null)
                    {
                        string[] kosi = vrstica.Split(',');
                        //gremo brat ostale in pisat
                        string ustvari = "[";
                        for (int i=0;i<kosi.Length; i++)
                        {
                            ustvari += $"({naslovi[i]},{kosi[i]}),";
                        }
                        ustvari = ustvari.Substring(0, ustvari.Length - 1);
                        ustvari += "]";
                        sw.WriteLine(ustvari);

                    }


                }
            }
        }
    }
}
