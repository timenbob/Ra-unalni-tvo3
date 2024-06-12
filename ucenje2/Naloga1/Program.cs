using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,2,3};
            int[]b= { 1, 2, 3 }; 
            int[]c=cela(a,b);
            foreach(int el in c)
            {
                Console.Write(el+" ");
            }
        }

        public static int[] cela(int[] a, int[] b)
        {
            int[] tabela = new int[a.Length + b.Length];
            for (int i = 0; i < a.Length; i++)
            {
                tabela[i] = a[i];
            }
            for (int j = a.Length; j < b.Length + a.Length; j++)
            {
                tabela[j] = b[j - a.Length];
            }

            return tabela;
        }

        public static T[] funA<T>(T[] a, T[] b)
        {
            T[] tabela = new T[a.Length + b.Length];
            for (int i = 0; i < a.Length; i++)
            {
                tabela[i] = a[i];
            }
            for (int j = a.Length; j < b.Length + a.Length; j++)
            {
                tabela[j] = b[j - a.Length];
            }

            return tabela;
        }
    }
}
