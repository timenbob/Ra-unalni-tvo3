using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GridGame
{
    internal class Grid
    {
        private int n, m;
        private Cell[,] grid;

        public Grid(int n, int m) {
            this.n = n;
            this.m = m;
            grid = new Cell[n, m];
        }

        public int[] GetSize() { return new int[] {this.n,this.m}; }

        public void MakeGrid()
        {
            // Ustvarjanje celic v mreži
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    grid[i, j] = new Cell(i, j);
                }
            }
        }

        public Cell GetCell(int i, int j)
        {   
            if(i<0 || j < 0 || i>this.n || j > this.m)
            {
                throw new EntryPointNotFoundException("To polje ne obstaja");
            }
            return grid[i, j];
        }
    }
}
