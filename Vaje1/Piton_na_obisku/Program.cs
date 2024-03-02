using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piton_na_obisku
{
    internal class Program
    
    {
        static int Piton(int n, int k)
            {
            int odg = 0;
                for (int i = 0;i<n;i++)
                {
                odg += (int)Math.Pow(i, k);
                }
            return odg; 
            }
        static void Main(string[] args)
        {
            Console.WriteLine(Piton(3, 2));
        }

        

    }

    
}
