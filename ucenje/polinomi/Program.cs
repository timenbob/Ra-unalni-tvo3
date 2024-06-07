using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polinomi
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Polinom : IComparable<Polinom>  
    {
        int[] koef;

        public int[] Koef
        {
            get { return this.koef; }
            set
            {
                if (value[0]==0) { throw new Exception("napačna stopnja polinoma"); }
                else {  koef = value; }
            }
        }
        public override string ToString()
        {
            return string.Join(" ", Koef);
        }
        public Polinom(int[] koef)
        {
            Koef = koef;
        }

        public int CompareTo(Polinom other)
        {
            if (other == null) return 1; // Null je vedno večji od ne-null.

            // Primerjaj dolžino koeficientov polinomov.
            return this.Koef[0] - other.Koef[0];
        }

      

        public static Polinom operator + (Polinom a, Polinom b)
        {
            
            int dolzina = Math.Max(a.Koef.Length, b.Koef.Length);
            int[] elementi=new int[] { 1, 2, 3, 4, 5 };
            return new Polinom(elementi);
           
        }

            
    }
}
