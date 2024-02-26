using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hisne_stevilke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi prvo številko: ");
            int prvoStevilo = int.Parse(Console.ReadLine());
            Console.Write("Vnesi zadnjo številko: ");
            int zadnjeStevilo = int.Parse(Console.ReadLine());

            int[] stevke=new int[10];

            while (prvoStevilo<=zadnjeStevilo) {
                if (prvoStevilo == 0) { stevke[0]++; }
                int ost = prvoStevilo;
                int st = prvoStevilo;
                while (ost != 0)
                {
                    int stev = ost % 10;
                    ost = (int)ost / 10;
                    if (stev == 0) { stevke[0]++; }
                    if (stev == 1) { stevke[1]++; }
                    if (stev == 2) { stevke[2]++; }
                    if (stev == 3) { stevke[3]++; }
                    if (stev == 4) { stevke[4]++; }
                    if (stev == 5) { stevke[5]++; }
                    if (stev == 6) { stevke[6]++; }
                    if (stev == 7) { stevke[7]++; }
                    if (stev == 7) { stevke[8]++; }
                    if (stev == 7) { stevke[9]++; }
                }
                

                prvoStevilo++;            
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}: {stevke[i]}x");
            }
        }
    }
}
