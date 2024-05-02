using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = 3; // Število vrstic
            int m = 4; // Število stolpcev

            // Ustvarjanje mreže
            Grid grid = new Grid(n, m);
            grid.MakeGrid();

            // Pridobivanje velikosti mreže
            int[] size = grid.GetSize();
            int rows = size[0];
            int columns = size[1];

            // Izpis mreže
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Cell cell = grid.GetCell(i, j);
                    object[] cellInfo = cell.CelicaGet;
                    Console.Write(cellInfo[1] + " "); // Izpis vsebine celice
                }
                Console.WriteLine();
            }
        }
    }
}
