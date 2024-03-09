using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamenjava_elemetov
{
    internal class ZamenjavaElemetov
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 }; 
            int[] b = Kopija(ref a);
            Console.WriteLine("Prej: "); Izpisi("a", a); Izpisi("b", b);
            a[1] = b[2];
            a[2] = b[1];
            Console.WriteLine("Potem: "); Izpisi("a", a); Izpisi("b", b);
        }

        /// <summary>
        /// naredi kopijo seznama t
        /// </summary>
        /// <param name="t">seznam t</param>
        /// <returns></returns>
        static int[] Kopija(ref int[] t)
        {
            int[] a = new int[t.Length];
            Array.Copy(t, a, t.Length);

            return a;

        }

        /// <summary>
        /// izpiše ime (tabele) in vse njene elemente v eni vrstici
        /// </summary>
        /// <param name="ime">ime tabele</param>
        /// <param name="t">elementi v tabeli</param>
        static void Izpisi(string ime, int[] t) {
        Console.Write(ime+": ");
            foreach (var el in t)
            {
                Console.Write(el);
            }
        Console.WriteLine("");
        }
    }
}
