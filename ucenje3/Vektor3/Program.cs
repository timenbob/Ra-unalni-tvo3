using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Vektor3
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Vektor3K
    {
        int x;
        int y;

        public int X
        {
            get { return x; }
            set
            {
                if (value > 0) { throw new Exception("cwuiu"); }
                else { x = value; }
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                if (value > 0) { throw new Exception("cwuiu"); }
                else { y = value; }
            }
        }

        public Vektor3K()
        {
            X = -1;
            Y = -1;
        }
        public Vektor3K(int x = -1, int y = -1)
        {
            X = x;
            Y = y;
        }

        public Vektor3K(string inti = "-1 -1")
        {
            string[] stevila = inti.Split(' ');
            if (stevila.Length == 2)
            {
                int x;
                int y;
                if(int.TryParse(stevila[0],out x) && int.TryParse(stevila[1],out y))
                {
                    X = x;
                    Y = y;
                }
                else { throw new Exception("hbi"); }


            }
            else { throw new Exception("hbi"); }
        }

        public double Dolzina
        {
            get {return Math.Sqrt(X * X + Y * Y);}
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public static Vektor3K operator*(Vektor3K ve,int a)
        {
            return new Vektor3K(ve.X * a, ve.Y * a);
        }

        public static Vektor3K NajskrajsaRaz(Vektor3K[] tab)
        {

            Vektor3K od=tab[0];
            foreach (Vektor3K ve in tab)
            {
                if (od.Dolzina >= ve.Dolzina)
                {
                    od = ve;
                }
            }
            return new Vektor3K(od.X, od.Y);
        }
    }
}
