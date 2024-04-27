using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridGame
{
    public class Position
    {
        private int x, y; 

        public int[] Pozicija {
            get { return new int[] { x, y }; }
            set
            {
                x = value[0];
                y = value[1];
            }
         
        }
    }
}
