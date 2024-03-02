using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katis_R2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int r1 = int.Parse(Console.ReadLine());
            string myStr = Console.ReadLine();
            string[] tokens = myStr.Split(' ');
            int r1 = Convert.ToInt32(tokens[0].Trim());
            int s = Convert.ToInt32(tokens[1].Trim());


            //int s= int.Parse(Console.ReadLine());
            int r2 = 2 * s - r1;
            Console.WriteLine(""+r2);

        }
    }
}
