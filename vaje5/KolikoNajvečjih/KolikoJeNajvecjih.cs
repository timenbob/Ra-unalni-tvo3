using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolikoNajvečjih
{
    internal class KolikoJeNajvecjih
    {
        static void Main(string[] args)
        {
            int[] tabela1 = { };
            int kolikoNajvecjih= KolikoJeNajvecjihFun(tabela1);
            Console.WriteLine(kolikoNajvecjih);

            int[] tabela2 = {1, 1, 2, 2, 3, 3 };
            int kolikoNajvecjih2 = KolikoJeNajvecjihFun(tabela2);
            Console.WriteLine(kolikoNajvecjih2);

        }

        /// <summary>
        /// Vrne število pojavitev največjega elementa
        /// </summary>
        /// <typeparam name="T">tip tabele</typeparam>
        /// <param name="tabela">tabela podatkov</param>
        /// <returns>Vrne število pojavitev največjega elementa</returns>
        static int KolikoJeNajvecjihFun<T>(T[] tabela) where T : IComparable<T>
        {   
            if (tabela.Length == 0) return 0;

            int StevecPojavitevNajvecjega = 0;
            T NajvecjiElement = tabela[0];
            foreach (T trenutniElement in tabela)
            {
                if (NajvecjiElement.CompareTo(trenutniElement)<0)
                {   
                    NajvecjiElement = trenutniElement;
                    StevecPojavitevNajvecjega = 0;
                    
                }
                
                if (NajvecjiElement.CompareTo(trenutniElement) == 0)
                {
                    StevecPojavitevNajvecjega++;
                }
            }
            return StevecPojavitevNajvecjega;  
        }
    }
}
