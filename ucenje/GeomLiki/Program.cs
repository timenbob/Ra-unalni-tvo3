using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomLiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public interface IGeomLik
    {
        double Ploscina();
        double Obseg();
    }

    public class Krog : IGeomLik, IComparable<Krog>
    {
        private int _r;
        private int _Sx;
        private int _Sy;

        public int Polmer
        {
            get { return this._r; }
            set {
                if (value < 0) { throw new ArgumentException("radij more bit večji od 0"); }

                this._r = value; }
        }

        public int Sx
        {
            get { return this._Sx; }
            set { this._Sx = value; } 
        }
        public int Sy
        {
            get { return this.Sy; }
            set { this._Sy = value; }   
        }

        public Krog(int polmer, int sx, int sy)
        {
            Polmer = polmer;
            Sx = sx;
            Sy = sy;
        }

        public double Ploscina()
        {
            return Math.PI * _r * _r;
        }

        public double Obseg()
        {
            return 2 * Math.PI * _r;
        }
        public int CompareTo(Krog other)
        {
            return this.Ploscina().CompareTo(other.Ploscina());
        }

    }
}
