using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrniNtiNajmanjši
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] blebet = { "bla", "blo", "bli" };
            int[] tja = { 20, 30, 60, 10 };
            string niz1 = VrniNtiNajmanjsi(blebet, 2); // dobimo "bli"
            string niz2 = VrniNtiNajmanjsi(blebet, -3); // dobimo "bla"
            //string niz3 = VrniNtiNajmanjsi(blebet, -4); // sproži se izjema
            int tam = VrniNtiNajmanjsi(tja, 1); // dobimo 10
            int tu = VrniNtiNajmanjsi(tja, 0); // sproži se izjema
            int tuk = VrniNtiNajmanjsi(tja, 5); // sproži se izjema
            int tik = VrniNtiNajmanjsi(tja, 3); // dobimo 30

        }

        public static T VrniNtiNajmanjsi<T>(T[] tab, int n) where T : IComparable
        {
            if (Math.Abs(n) > tab.Length) { throw new Exception("urbouecb"); }

            Array.Sort(tab);
            Console.WriteLine(tab);
            if (n == 0) { throw new Exception("Aj ne zajebavaj"); }
            if (n>0) { return tab[n - 1];}
            else { return tab[tab.Length+n];}
       
        }
    }
}
