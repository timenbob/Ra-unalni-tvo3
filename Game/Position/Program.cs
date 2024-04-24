using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Position
{
   
    }
    public class Position
    {
        private int x;
        private int y;

        public Position(int x, int y, Grid.Grid grid)
        {
            if (grid.JeVeljavnaPozicija(x, y))
            {
                this.x = x;
                this.y = y;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Položaj ni znotraj mreže, poskusi ponovno.");
            }
        }
    }
}
