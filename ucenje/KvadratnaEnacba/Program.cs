using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnaEnacba
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static double[] ničleKvEnačbe(int a,int  b,int c)
        {
            double[] nicle=new double[2];
            double D = b * b - 4 * a * c;
            if (D < 0) { throw new ArgumentException("kompleksne nicle"); }
            if (D == 0) { throw new Exception("dvojan nicla"); }
            else
            {
                nicle[0] = (-b + Math.Sqrt(D)) / (2 * a);
                nicle[1] = (-b - Math.Sqrt(D)) / (2 * a);
            }

            return nicle;
        }
    }
}
