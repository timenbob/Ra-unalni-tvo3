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
            String a = Console.ReadLine();
            String b = Console.ReadLine();
            String c = Console.ReadLine();
            int ia = int.Parse(a);
            int ib = int.Parse(b);
            int ic = int.Parse(c);
            Console.WriteLine("Za števila a, b in c seveda velja a+(b+c)=(a+b)+c, saj je " + (ia + (ib + ic)) + "="+ ((ia + ib) + ic) + ".");
        }
    }
}
