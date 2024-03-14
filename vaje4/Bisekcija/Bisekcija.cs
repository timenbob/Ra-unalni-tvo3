using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisekcija
{
    internal class Bisekcija
    {
        /// <summary>
        /// Z bisekcijo poisčemo ali je podatek v tabeli
        /// </summary>
        /// <typeparam name="T">generični tip ki se lahko primerja</typeparam>
        /// <param name="tabela">tabela nekih podatkov iste vrste</param>
        /// <param name="podatek">podatek istega tipa kot tabela</param>
        /// <returns></returns>
        static bool Iskanje<T>(T[] tabela, T podatek) where T : IComparable<T>//dodamo ICompareble da imamo tip ki se ga lahko primerja
        {
            int zacetek = 0;
            int konec = tabela.Length - 1;

            while (zacetek <= konec)
            {
                int sredina = (zacetek + konec) / 2;
                int primerjava = podatek.CompareTo(tabela[sredina]);//0 če sta podatka enaka, podatek>tabela..negativno, podatek<tabela..pozitivno

                if (primerjava == 0)
                {
                    return true; // Podatek je najden
                }
                else if (primerjava < 0)
                {
                    konec = sredina - 1; // Iskanje v levi polovici
                }
                else
                {
                    zacetek = sredina + 1; // Iskanje v desni polovici
                }
            }

            return false; // Podatek ni najden
        }

        static void Main(string[] args)
        {
            int[] tabela = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            int iskaniPodatek = 7;
            bool najden = Iskanje(tabela, iskaniPodatek);
            Console.WriteLine($"Ali tabela vsebuje podatek {iskaniPodatek}? {najden}");

            iskaniPodatek = 8;
            najden = Iskanje(tabela, iskaniPodatek);
            Console.WriteLine($"Ali tabela vsebuje podatek {iskaniPodatek}? {najden}");
        }
    }
}
