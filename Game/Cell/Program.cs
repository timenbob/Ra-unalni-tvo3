using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell
{
    public class Cell
    {
        public Position.Position Position { get; private set; }
        private char content; // Privatna spremenljivka za vsebino polja

        public Cell(int x, int y, char content, Grid.Grid grid)
        {
            Position = new Position.Position(x, y, grid); // Uporaba razreda Position za določitev položaja
            Content = content; // Nastavitev vsebine polja
        }

        public char Content
        {
            get { return content; }
            set
            {
                // Preverimo, ali je nova vsebina polja veljavna
                if (value == ' ' || value == 'X' || value == 'O' || (content == 'W' && value == 'W'))
                {
                    content = value;
                }
                else
                {
                    throw new ArgumentException("Nepodprta vsebina polja.");
                }
            }
        }
    }
}
