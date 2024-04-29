using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridGame
{
    internal class Cell
    {
        Position pozicija=new Position();
        Content vsebina=new Content();

        public Cell(int x, int y)
        {
            pozicija.Pozicija = new int[] { x, y };
        }

        public object[] CelicaGet
        {
            get { return new object[] { pozicija.Pozicija, vsebina.Vsebina }; }//pozicija.Pozicija vrne [x,y]
        }
        public char CelicaSet
        {
            set { vsebina.Vsebina = value; }
        }

    }
}
