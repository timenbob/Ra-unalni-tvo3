using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piton_na_obisku
{
    internal class Piton
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi prvo s: ");
            string s = Console.ReadLine();
            Console.Write("Vnesi t: ");
            string t = Console.ReadLine();

            Console.WriteLine($"{najvecPonovitev(s, t)}");
        }

        private static string najvecPonovitev(string s, string t)
        {
            int[] nizC = new int[t.Length];
            int m = 0;
            for (int i = 0; i < t.Length; i++)
            {
                int stevec = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (t[i] == s[j]) stevec++;
                }
                if (stevec >= m)
                {
                    nizC[i] = stevec;
                    m = stevec;
                    stevec = 0;
                }
            }

            string[] U = new string[t.Length];
            for (int i = 0; i < t.Length; i++)
            {
                if (nizC[i] == m)
                {
                    U[i] = "" + t[i];
                }
                else { U[i] = ""; }
            }

            string resitev = "";
            for (int i = 0; i < U.Length; i++)
            {
                if (U[i] != "")
                {
                    
                    resitev = resitev + U[i];
                }
            }

            return resitev;
        }
        }
}
