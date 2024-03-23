using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromskaStevila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            palind(90, 130);
            palind(12, 21);
            palind(0, 0);
            palind(120, 21);
        }

        static void palind(int zacetek, int konec)
        {
            string palindromi = "";

            for (int i = zacetek; i <= konec; i++)
            {
                string stevilo = "" + i;
                int obratno = int.Parse(Reverse(stevilo));
                if (i - obratno == 0)
                {
                    palindromi += i + ", ";
                }
            }

            if (palindromi.Length > 0)
            {
                string result = palindromi.Substring(0, palindromi.Length - 2);
                Console.WriteLine($"Palindromska števila med {zacetek} in {konec} so " + result + ".");
            }
            else
            {
                Console.WriteLine($"Med {zacetek} in {konec} ni palindromskih števil.");
            }
        
        }



        /// <summary>
        /// Obrnse stringa
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string Reverse(string str)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }
            return reversed.ToString();
        }
    }
}
