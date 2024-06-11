using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisekcija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 1, 3, 3, 4, 5, 6, 7 };
            int el = 2;
            bool rez = Bisekcija(tab,  el);
            Console.WriteLine(rez);
        }

        public static bool Bisekcija<T>(T[] obj, T el) where T : IComparable<T>
        {
            // Osnovni primer: če je seznam prazen, vrni false
            if (obj.Length == 0)
            {
                return false;
            }

            // Poišči srednji indeks
            int midIndex = obj.Length / 2;
            T srednjiEl = obj[midIndex];

            int vr = el.CompareTo(srednjiEl);

            // Če je element enak srednjemu, vrni true
            if (vr == 0)
            {
                return true;
            }
            // Če je element večji od srednjega, poišči v desni polovici
            else if (vr > 0)
            {
                // Ustvari novo polje za desno polovico
                T[] desnaPolovica = new T[obj.Length - midIndex - 1];
                // Kopiraj desno polovico iz originalnega polja
                Array.Copy(obj, midIndex + 1, desnaPolovica, 0, desnaPolovica.Length);
                // Rekurzivno poišči v desni polovici
                return Bisekcija(desnaPolovica, el);
            }
            // Če je element manjši od srednjega, poišči v levi polovici
            else
            {
                // Ustvari novo polje za levo polovico
                T[] levaPolovica = new T[midIndex];
                // Kopiraj levo polovico iz originalnega polja
                Array.Copy(obj, 0, levaPolovica, 0, midIndex);
                // Rekurzivno poišči v levi polovici
                return Bisekcija(levaPolovica, el);
            }
        }


    }
}
