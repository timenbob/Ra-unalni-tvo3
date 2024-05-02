using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridGame
{
    public class Content
    {
        private char content;
        private char[] veljavne_vsebine = new char[] { 'E', 'X', 'O', 'W' };
        // E=empty X=X O=O W=wall

        public Content(char vsebina ='E')
        {
            this.content = vsebina;
        }

        public char Vsebina {  get { return content; } 
            set 
            {
                if (!veljavne_vsebine.Contains(value))
                {
                    throw new ArgumentException("Neveljavna vsebina celice.");
                }
                if (content == value)
                {
                    throw new ArgumentException("Ta vsebina je že nastavljena");
                }
                if (content == 'W') 
                {
                    throw new ArgumentException("Zidu se neda prekriti");
                }
                else {content = value; }

            } 
        }
    }
}
