using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnozimoSe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\tb9218\source\repos\Programiranje_3\vaje5\stevila.txt";
            Console.WriteLine(MnozimoDatoteko(path)); 
        }

        /// <summary>
        /// stevila ki so v datoteki s potjo path pomnozimo in vrnemo v obliki ulomka
        /// </summary>
        /// <param name="path">pot do datoteke</param>
        /// <returns></returns>
        static string MnozimoDatoteko(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                int imenovale = 1;
                int stevec = 1;
                string vrstica = "";
                while ((vrstica= sr.ReadLine()) != null)
                {
                    
                    string[] raskosanaStevila = vrstica.Split('/');
                    if (raskosanaStevila.Length == 2)
                    {
                        imenovale *= int.Parse(raskosanaStevila[0]);
                        stevec *= int.Parse(raskosanaStevila[1]);
                    }
                    if (raskosanaStevila.Length == 1)
                    {
                        imenovale *= int.Parse(raskosanaStevila[0]);
                    }
                    if (raskosanaStevila.Length == 0) { return "0"; }
                }
                return $"{imenovale}/{stevec}";
            }
        }
    }
}
