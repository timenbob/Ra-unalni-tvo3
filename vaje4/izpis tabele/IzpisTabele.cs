using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpis_tabele
{
    internal class IzpisTabele
    {
        /// <summary>
        /// Naredi lep izpis tabele
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tab">podatki</param>
        /// <param name="n">st elementov v vrstici</param>
        /// <param name="vmes">ločilo med elementi</param>
        static void IzpisTabelef<T>(T[] tab, int n, string vmes)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]);
                if ((i + 1) % n == 0 || i == tab.Length - 1)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(vmes);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] tabela1 = { 12, 5, 6, 78, 3, 5, 6, 21, 434, 56, 42, 7 };
            Console.WriteLine("Prva tabela:");
            IzpisTabelef(tabela1, 5, " : ");

            char[] tabela2 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l' };
            Console.WriteLine("Druga tabela:");
            IzpisTabelef(tabela2, 4, " | ");

            
        }
    }
}
