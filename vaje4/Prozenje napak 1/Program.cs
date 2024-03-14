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
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))//out result nastavi result na upisano vrednost če je true sicer na prevzeto
            {
                Console.WriteLine("NAPAKA: Vnesite celo število.");
            }
            return result;
        }

        static void Racunanje(int n)
        {
            int correctAnswers = 0;
            while (correctAnswers < n)
            {
                int a = rand.Next(1, 101); // naključno število med 1 in 100
                int b = rand.Next(1, 101); // naključno število med 1 in 100
                int operation = rand.Next(3); // naključna operacija (0 za +, 1 za -, 2 za *)

                char op;
                int expected;
                switch (operation)
                {
                    case 0:
                        op = '+';
                        expected = a + b;
                        break;
                    case 1:
                        op = '-';
                        expected = a - b;
                        break;
                    default:
                        op = '*';
                        expected = a * b;
                        break;
                }

                Console.Write($"{a} {op} {b} = ");
                int answer = PreberiInt();
                if (answer == expected)//če je rezultat ena vpisanemu povečamo stevec
                {
                    correctAnswers++;
                    Console.WriteLine("Pravilno!");
                }
                else
                {
                    Console.WriteLine($"NAPAKA: Rezultat ni pravilen. Pravilen odgovor je {expected}.");
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
