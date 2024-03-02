using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand_stevilo = new Random();
            int x = rand_stevilo.Next(100,1000);


            Console.WriteLine("Naše naključno število=" + x);
        

    }
    }
}
