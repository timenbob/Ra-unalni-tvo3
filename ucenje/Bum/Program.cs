using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Od kod naj štejem?");
            int a =int.Parse(Console.ReadLine());
            Console.Write("Do kod naj štejem?");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(fun(a, b));
        }
        public static string fun(int a, int b)
        {
            string niz = "";
            for (int i=a; i <= b; i++)
            {
                if (i % 3 == 0 || i.ToString().Contains("3"))
                {
                    niz += " BOM! ";
                }
                else { niz += " " + i + " "; };
            }
            return niz;
        }
    }
}
