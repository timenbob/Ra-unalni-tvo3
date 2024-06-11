using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomLiki1
{
    public interface IGeomLik
    {
        double Ploscina();
        double Obseg();
    }

    public class Krog : IGeomLik, IComparable<Krog>
    {
        Random rand = new Random();
        private int _Polmer;
        private int _Sx;
        private int _Sy;

        public int Polmer
        {
            set
            {
                if (value < 0) { throw new ArgumentException("polmer mora bit vec kot 0"); }
                _Polmer = value;
            }
            get { return _Polmer; }
        }

        public int Sx
        {
            get { return _Sx; }
            set { _Sx = value; }
        }
        public int Sy
        {
            get { return _Sy; }
            set { _Sy = value; }
        }

        public double Ploscina()
        {
            return Math.PI * _Polmer * _Polmer;
        }

        public double Obseg()
        {
            return 2 * Math.PI * _Polmer;
        }
        public int CompareTo(Krog other)
        {
            return this.Ploscina().CompareTo(other.Ploscina());
        }

        public bool SemEnak(IGeomLik other, double toleracnca)
        {
            
            return (Math.Abs(this.Ploscina() - other.Ploscina()) <= toleracnca);
        }

        public Krog( int polmer, int sx, int sy)
        {
            
            Polmer = polmer;
            Sx = sx;
            Sy = sy;
 
        }

        public Krog Spremeni(IGeomLik other)
        {
            double pl = other.Ploscina();
            int polmer= (int) Math.Sqrt(pl/Math.PI);
            int randomNumber = rand.Next(-100, 100);
            int randomNumber2 = rand.Next(-100, 100);

            return new Krog(polmer,randomNumber,randomNumber2);

        }

    }



    internal class Program
    {
            static void Main(string[] args)
            {
            }
    }
    
}
