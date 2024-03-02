using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace caramo_s_celimi_stevili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("stevec= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("imenovalec= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("st_decimalk= ");
            int de = int.Parse(Console.ReadLine());
            int d = a % b;
            int k = 0;
            int del = a / b;
            string r = ""+del+".";
            while (k <= de-1)
            {
                d = d * 10;
                int nd = (int)d / b;
                r = r + nd;
                k++;
                d = d % b;
            }
            Console.WriteLine(""+a+"/"+b+  "="+ r);
            
        }
    }
}
