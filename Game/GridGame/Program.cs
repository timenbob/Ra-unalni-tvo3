using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grid polje = new Grid(10, 5);
            polje.MakeGrid();

        }
    }
}
