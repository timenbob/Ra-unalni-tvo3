using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steviloHlebcev, stevecNapacnih;
            kruh(out steviloHlebcev, out stevecNapacnih);
            //računamo ali bo pek pil vodo
            odlocitev(steviloHlebcev, stevecNapacnih);
        }

        private static void odlocitev(int steviloHlebcev, int stevecNapacnih)
        {
            if (stevecNapacnih > steviloHlebcev * 0.15)
                Console.WriteLine("Peka v vodo takoj!!!!");
            else
                Console.WriteLine("Pek ima dobro mero");
        }

        private static void kruh(out int steviloHlebcev, out int stevecNapacnih)
        {
            Console.Write("Vnesi predpisano tezo hlebca: ");
            double tezaPredpis = double.Parse(Console.ReadLine());
            Console.Write("Vnesi stevilo hlebcev v pekarni: ");
            steviloHlebcev = int.Parse(Console.ReadLine());
            stevecNapacnih = 0;
            double minTeza = tezaPredpis * 0.8;
            double maxTeza = tezaPredpis * 1.2;
            for (int i = 1; i < steviloHlebcev; i++)
            {
                Console.Write("Vnesi tezo: " + i + ". hlebca ");
                double dejanskaTeza = double.Parse(Console.ReadLine());
                //Če je teža hlebca 20% manjša od predpisa, ga štej med napačne hlebce
                if ((dejanskaTeza < minTeza) || (dejanskaTeza > maxTeza))
                    stevecNapacnih++;
            }
        }

    }
}
