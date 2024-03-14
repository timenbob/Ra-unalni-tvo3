using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lovljenjenapak1
{
    internal class Program
    {
        /// <summary>
        /// definirana funkcija
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static int F(int i)
        {
            try
            {
                return 100 / (i % 3);
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }

        /// <summary>
        /// tabelira funkcijo
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static List<int> Tabeliraj(int n)
        {
            List<int> tabela = new List<int>();
            for (int i = 0; i < n; i++)
            {
                tabela.Add(F(i));
            }
            return tabela;
        }

        static void Main()
        {
            Console.Write("Napisi celo stevil: ");
            Console.ReadLine();
            List<int> rezultat = Tabeliraj(11);
            Console.WriteLine("[{0}]", string.Join(", ", rezultat));
        }
    }
}
