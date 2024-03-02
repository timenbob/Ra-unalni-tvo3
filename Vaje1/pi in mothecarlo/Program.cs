using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_in_mothecarlo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Stevilo_tock= ");
            double n = int.Parse(Console.ReadLine());
            Random randdom= new Random();
            double stevec = 0;
            for (int i=0; i<n; i++)
            {
                double x = randdom.NextDouble();
                double y = randdom.NextDouble();
                //Console.WriteLine("" + x + "," + y);
                if (Math.Pow(x,2) + Math.Pow(y,2) <=1) {
                    stevec=stevec+1;
                }
            }
            //Console.WriteLine("" + stevec + "," + n + ",");
            double pi = 4 * stevec / n;
            Console.WriteLine("pi = " + pi);

        }
    }
}
