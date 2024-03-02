using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Gremo_v_krog
{
    internal class gremo_v_krog
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi elemente tabele: ");
            string[] sez = Console.ReadLine().Split(' ');
            Console.Write("Vnesi pomik: ");
            int stevilo_ciklov = int.Parse(Console.ReadLine());

            Console.Write("Tabela pred pomikom: ");
            for (int i = 0; i < sez.Length; i++)
            {
                Console.Write($"{sez[i]} ");
            }
            Console.WriteLine("");

            if (stevilo_ciklov < 0)
            {
                while (stevilo_ciklov < 0)
                {
                    stevilo_ciklov += sez.Length;
                }
            }
            for (int i = 0; i < stevilo_ciklov; i++)
            {
                cikel(sez);
            }
            Console.Write("Tabela po premiku: ");
            for (int i = 0; i < sez.Length; i++)
            {
                Console.Write($"{sez[i]} ");
            }
            Console.WriteLine("");

        }
        /// <summary>
        /// funkcija naredi en cikel v pozitivno smer
        /// </summary>
        /// <param name="sez">vnesemo celoten cikel</param>
        static void cikel(string[] sez)
        {
           string zadnjiEl = sez[sez.Length - 1];
           for (int i = sez.Length - 1; i > 0; i--)
           {
               sez[i] = sez[i - 1];
           }
            sez[0] = zadnjiEl;
        }
    }
}
