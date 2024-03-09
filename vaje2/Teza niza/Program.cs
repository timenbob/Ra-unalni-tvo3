using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teza_niza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi niz: ");
            string s = Console.ReadLine();
            Console.Write("Tehtnica: ");
            string t = Console.ReadLine();

            if (t == "slovenska") {
                Console.WriteLine($"{tezaSlo(s)}");
            }
            else
            {
                Console.WriteLine($"{tezaEng(s)}");
            }
        }

        static int tezaSlo( string s )
        {
            int teza = 0;
            foreach (char crka in s)
            {
                if (char.IsLower(crka)) {teza += (int)crka - (int)'a' + 1;}
                    
                else if (char.IsUpper(crka)) {teza += (int)crka - (int)'A' + 51;}
                    
            }
            return teza;
        }

        static int tezaEng(string s)
        {
            int teza = 0;
            foreach (char crka in s)
            {
                if (char.IsLetter(crka))
                    teza += (int)crka;
            }
            return teza;
        }
    }
}
