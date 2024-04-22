using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnaEnacba
{
    internal class nicle
    {
        static void Main()
        {
            // Testni primeri
            TestniPrimer(1, 4, 4);  // Ena realna rešitev (kvadrat)
            TestniPrimer(1, 2, 1);  // Dve enaki realni rešitvi (kvadrat)
            TestniPrimer(1, -3, 2); // Dve različni realni rešitvi (kvadrat)
            TestniPrimer(0, 2, 3);  // Linearna enačba
            TestniPrimer(0, 0, 4);  // Ni rešitve
            TestniPrimer(0, 0, 0);  // Neskončno rešitev
            TestniPrimer(1, 1, 1);  // Kompleksne rešitve

            Console.ReadLine(); // Počakaj, da uporabnik pritisne Enter
        }

        // Funkcija za izračun ničel kvadratne enačbe ter sprožitev izjeme v primeru napačnih vrednosti
        static double[] ničleKvEnačbe(double a, double b, double c)
        {
            double diskriminanta = b * b - 4 * a * c;

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        throw new Exception("Enačba ima neskončno rešitev.");
                    }
                    else
                    {
                        throw new Exception("Enačba nima rešitve.");
                    }
                }
                else
                {
                    double ničla = -c / b;
                    return new double[] { ničla };
                }
            }
            else
            {
                if (diskriminanta > 0)
                {
                    double ničla1 = (-b + Math.Sqrt(diskriminanta)) / (2 * a);
                    double ničla2 = (-b - Math.Sqrt(diskriminanta)) / (2 * a);
                    return new double[] { ničla1, ničla2 };
                }
                else if (diskriminanta == 0)
                {
                    double ničla = -b / (2 * a);
                    return new double[] { ničla };
                }
                else
                {
                    throw new Exception("Enačba ima kompleksne rešitve.");
                }
            }
        }

        // Testna funkcija za preizkus različnih primerov
        static void TestniPrimer(double a, double b, double c)
        {
            try
            {
                double[] ničle = ničleKvEnačbe(a, b, c);
                Console.WriteLine($"Enačba ({a}x^2 + {b}x + {c}) ima ničle: {string.Join(", ", ničle)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Napaka: {ex.Message}");
            }
        }
    }
}
