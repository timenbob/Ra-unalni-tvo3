using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin1
{
    internal class minmax
    {
        static T[] MinMax<T>(T[] tabela) where T : IComparable<T>
        {            
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

            return new T[] { min, max };//nova tabela z elementoma min max
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
