using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomLiki
{
    public interface IGeomLik
    {
        double Ploscina();
        double Obseg();
    }

    public class Krog: IGeomLik, IComparable<Krog>
    {
        Random random;

        private int _polmer;
        private int _sx;
        private int _sy;

        public Krog(int polmer, int sx, int sy)
        {
            Polmer = polmer;
            Sx = sx;
            Sy = sy;
            random = new Random();
        }

        public int Polmer
        {
            get { return _polmer; }
            set 
            {
                if (value < 0) throw new ArgumentException("Polmer mora biti pozitiven.");
                else _polmer = value;
            }
        }

        public int Sx
        {
            get { return _sx; }
            set { _sx = value; }
        }
        public int Sy
        {
            get { return _sy; }
            set { _sy = value; }
        }

        public double Obseg()
        {
            return 2 * Math.PI * Polmer;
        }

        public double Ploscina()
        {
            return Math.Pow(Polmer,2) * Math.PI;
        }

        public int CompareTo(Krog other)
        {
            if (this.Ploscina() > other.Ploscina()) return 1;
            else if (this.Ploscina() < other.Ploscina()) return -1;
            else return 0;
        }

        /// <summary>
        /// Vrne true, če se ploščini kroga in lika ne razlikujeta za več kot dano toleranco.
        /// </summary>
        /// <param name="other">Lik, ki ima ploščino</param>
        /// <param name="toleranca">koliko se lahko ploscini razlikujeta</param>
        /// <returns></returns>
        public bool SemEnak(IGeomLik other, double toleranca)
        {
            return Math.Abs(this.Ploscina() - other.Ploscina()) < toleranca;
        }

        /// <summary>
        /// Vrne nov Krog, ki ima enako ploscino kot dani lik.
        /// </summary>
        /// <param name="lik">Lik, ki ima ploscino</param>
        /// <returns></returns>
        public Krog Spremeni(IGeomLik lik)
        {
            int polmer = (int) Math.Sqrt(lik.Ploscina() / Math.PI);
            int sx = random.Next(-100, 100);
            int sy = random.Next(-100, 100);
            return new Krog(polmer, sx, sy);
        }

        static void Main(string[] args)
        {
        }
    }
}
