using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lovljenjenapak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static int[] tabeliraj(int t){
            int[] result = new int[t];
            for(int i = 0; i < t;i++) {
                result[i] = f(t);
            }
            return result;
        }

        public static int f(int i)
        {
            return 100 / (i % 3);}
    }
}
