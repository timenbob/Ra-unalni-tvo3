using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grid mreža = new Grid(5, 15); // Ustvari mrežo dimenzij 5x5
            mreža.Narisi(); // Izriše mrežo
        }
    }

    public class Grid
    {
        private int lenght;
        private int hight;

        public Grid(int l,int h) 
        {   
            if (l < 0 || h < 0)
            {
                l = 10;
                h = 10;
            }
        this.lenght = l;
        this.hight = h;

        }

        public void Narisi()
        {
            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    Console.Write("+---");
                }
                Console.WriteLine("+");
                for (int j = 0; j < lenght; j++)
                {
                    Console.Write("|   ");
                }
                Console.WriteLine("|");
            }
            for (int j = 0; j < hight; j++)
            {
                Console.Write("+---");
            }
            Console.WriteLine("+");
        }

        public int[] Size
        {
            get { return new[]{lenght,hight }; }
        }

        public bool JeVeljavnaPozicija(int x, int y)
        {
            return x >= 0 && x < lenght && y >= 0 && y < hight;
        }

        public void SetCellValue(Position.Position pozicija, char value)
        {
            if (JeVeljavnaPozicija(pozicija.Position.X, pozicija.Position.Y))
            {
                cells[pozicija.Position.X, pozicija.Position.Y].Content = value;
            }
            else
            {
                throw new ArgumentException("Položaj ni znotraj mreže.");
            }
        }

        public char GetCellValue(Position.Position pozicija)
        {
            if (JeVeljavnaPozicija(pozicija.Position.X, pozicija.Position.Y))
            {
                return cells[pozicija.Position.X, pozicija.Position.Y].Content;
            }
            else
            {
                throw new ArgumentException("Položaj ni znotraj mreže.");
            }
        }

    }


}
