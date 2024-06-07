using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sez = new int[] { 12, 5, 6, 78, 3, 5, 6, 21, 434, 56, 42, 7 };
            IzpsTabele(sez, 5, ":");
        }

        public static void IzpsTabele<T>(T[] sez,int n,string med)
        {
            int stevec = 0;
            foreach (T t in sez) 
            {
                stevec++;
                if(stevec == n) { Console.WriteLine($"{t}\n");stevec = 0; } 
                else { Console.Write($"{t} {med} "); };
            }
        }
    }
}
