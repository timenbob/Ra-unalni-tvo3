using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnjiznicaMetod
{
    internal class KnjiznicaMetod
    {
        static void Main(string[] args)
        {


            int[] tabela = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Izvorna tabela: " + TabelaKotNiz(tabela));

            PodvojiVelikost(ref tabela);
            Console.WriteLine("Podvojena tabela: " + TabelaKotNiz(tabela));

            int[] nakljucnaTabela = NakljucnaTabela(5, 10);
            Console.WriteLine("Naključna tabela: " + TabelaKotNiz(nakljucnaTabela));

            string niz = "6 7 8 9 10";
            tabela = NizKotTabela(niz);
            Console.WriteLine("Tabela iz niza: " + TabelaKotNiz(tabela));
        }

        /// <summary>
        /// Tabelo podaljša za *2
        /// </summary>
        /// <param name="tabela">tabela celih stevil</param>
        static void PodvojiVelikost(ref int[] tabela)
        {
            int novaDolzina = tabela.Length * 2;
            int[] novaTabela = new int[novaDolzina];

            for (int i = 0; i < tabela.Length; i++)
            {
                novaTabela[i] = tabela[i];
            }

            tabela= novaTabela;
        }

        static int[] NakljucnaTabela(int dolzina, int maksimalnaVrednost)
        {
            Random random = new Random();
            int[] tabela = new int[dolzina];

            for (int i = 0; i < dolzina; i++)
            {
                tabela[i] = random.Next(1, maksimalnaVrednost + 1);
            }

            return tabela;
        }

        /// <summary>
        /// Pretvori tabelo celih števil v niz.
        /// </summary>
        /// <param name="tabela">Tabela celih števil.</param>
        /// <returns></returns>
        static string TabelaKotNiz(int[] tabela)
        {
            return string.Join(" ", tabela);
        }

        /// <summary>
        /// Pretvori niz v tabelo celih števil.
        /// </summary>
        /// <param name="niz">Niz s števili</param>
        /// <returns></returns>
        static int[] NizKotTabela(string niz)
        {
            string[] del = niz.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] tabela = new int[del.Length];

            for (int i = 0; i < del.Length; i++)
            {
                tabela[i] = int.Parse(del[i]);
            }

            return tabela;
        }

      
    }
}

