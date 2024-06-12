using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NalogaA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] taba= { 1, 2, 3, 4, 5, 6 };
            int[] tabb = { 1, 2, 3, 4 };
            int[]skupi =funA(taba, tabb);
            foreach(int i in skupi) { Console.WriteLine(i); }
        }

        public static T[] funA<T>(T[] a, T[] b)
        {
            T[] tabela=new T[a.Length+b.Length];
            for(int i=0; i<a.Length; i++)
            {
                tabela[i] = a[i];
            }
            for(int j=a.Length; j < b.Length + a.Length; j++)
            {
                tabela[j] = b[j-a.Length];
            }

            return tabela;
        }
    }
}
