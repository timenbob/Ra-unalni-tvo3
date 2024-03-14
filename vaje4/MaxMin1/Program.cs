using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin1
{
    internal class Program
    {
        static T[] MinMax<T>(T[] tabela) where T : IComparable<T>
        {
            if (tabela.Length == 0)
            {
                throw new ArgumentException("Tabela ne sme biti prazna.");
            }

            T min = tabela[0];
            T max = tabela[0];

            foreach (T element in tabela)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
                if (element.CompareTo(max) > 0)
                {
                    max = element;
                }
            }

            return new T[] { min, max };
        }

        static string[] MinMax(string[] tabela)
        {
            if (tabela.Length == 0)
            {
                throw new ArgumentException("Tabela ne sme biti prazna.");
            }

            string min = tabela[0];
            string max = tabela[0];

            foreach (string element in tabela)
            {
                if (element.Length < min.Length)
                {
                    min = element;
                }
                if (element.Length > max.Length)
                {
                    max = element;
                }
            }

            return new string[] { min, max };
        }

        static void Main(string[] args)
        {
            int[] tabela1 = { 5, 2, 8, 4, 10, 3 };
            var minMax1 = MinMax(tabela1);
            Console.WriteLine($"Minimalni element: {minMax1[0]}, Maksimalni element: {minMax1[1]}");

            string[] tabela2 = { "jabolko", "banana", "hruška", "pomaranča", "breskev" };
            var minMax2 = MinMax(tabela2);
            Console.WriteLine($"Minimalni element: {minMax2[0]}, Maksimalni element: {minMax2[1]}");
        }
    }
}
