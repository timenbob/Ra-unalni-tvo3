using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prozenje_napak_1
{
    internal class Program
    {
        static Random rand = new Random();

        /// <summary>
        /// funkcija nas sprasuje da vpišemo int dokler ga pravilno ne vpišemo
        /// </summary>
        /// <returns></returns>
        static int PreberiInt()
        {
            int rezultat;
            while (!int.TryParse(Console.ReadLine(), out rezultat))//out rezultat nastavi rezultat na upisano vrednost če je true sicer na prevzeto
            {
                Console.WriteLine("NAPAKA: Vnesite celo število.");
            }
            return rezultat;
        }

        static void Racunanje(int n)
        {
            int odg = 0;
            while (odg < n)
            {
                int a = rand.Next(1, 101); // naključno število med 1 in 100
                int b = rand.Next(1, 101); // naključno število med 1 in 100
                int operant = rand.Next(3); // naključna operacija (0 za +, 1 za -, 2 za *)

                char op;
                int vrednost;
                switch (operant)
                {
                    case 0:
                        op = '+';
                        vrednost = a + b;
                        break;
                    case 1:
                        op = '-';
                        vrednost = a - b;
                        break;
                    default:
                        op = '*';
                        vrednost = a * b;
                        break;
                }

                Console.Write($"{a} {op} {b} = ");
                int odgovor = PreberiInt();
                if (odgovor == vrednost)//če je rezultat ena vpisanemu povečamo stevec
                {
                    odg++;
                    Console.WriteLine("Pravilno!");
                }
                else
                {
                    Console.WriteLine($"NAPAKA: Rezultat ni pravilen. Pravilen odgovor je {vrednost}.");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Vpiši ste racunov: ");
            int n= int.Parse(Console.ReadLine());
            Racunanje(n);
        }
    }
}
