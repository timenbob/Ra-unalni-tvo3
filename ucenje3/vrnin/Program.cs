using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrnin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 20, 30, 40, 10 };
            Console.WriteLine(vrniN(tab,3));
        }
        public static T vrniN<T>(T[]tab, int n) where T : IComparable<T>
        {
            if(Math.Abs(n)>tab.Length || n==0) { throw new ArgumentException("joh"); }
            Array.Sort(tab);
            if (n < 0)
            {
                return tab[tab.Length + n];
            }
            else
            {
                return tab[n-1];
            }
        }
    }
}
