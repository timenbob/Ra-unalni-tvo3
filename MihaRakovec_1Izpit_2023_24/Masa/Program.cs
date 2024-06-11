using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masa
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            // točka 1
            Masa[] tabelaMas = new Masa[20];

            for (int i = 0; i < 10; i++)
            {
                Masa nova = new Masa(random.Next(100), Masa.dovoljeneEnote[random.Next(Masa.dovoljeneEnote.Length)]);
                tabelaMas[i] = nova;
                tabelaMas[tabelaMas.Length - 1 - i] = nova;
            }

            // točka 2
            Console.WriteLine(Masa.Sestej(tabelaMas));

            // točka 3
            Masa najvecja = Masa.NajvecjaMasa(tabelaMas)[0] * 3;

            // točka 4
            Console.WriteLine(Masa.Sestej(tabelaMas));
        }
    }
}
