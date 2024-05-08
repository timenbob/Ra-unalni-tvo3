using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektor2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class Vektor2D : IComparable<Vektor2D>
    {
        private double x;
        private double y;

        // Konstruktor
        public Vektor2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Lastnosti
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        // Urejanje glede na dolžino vektorja
        public int CompareTo(Vektor2D other)
        {
            double thisLength = Math.Sqrt(x * x + y * y);
            double otherLength = Math.Sqrt(other.x * other.x + other.y * other.y);
            return thisLength.CompareTo(otherLength);
        }

        // Relacijski operatorji
        public static bool operator ==(Vektor2D a, Vektor2D b)
        {
            return a.x == b.x && a.y == b.y;
        }

        public static bool operator !=(Vektor2D a, Vektor2D b)
        {
            return !(a == b);
        }

        // Aritmetični operatorji
        public static Vektor2D operator +(Vektor2D a, Vektor2D b)
        {
            return new Vektor2D(a.x + b.x, a.y + b.y);
        }

        public static Vektor2D operator -(Vektor2D a, Vektor2D b)
        {
            return new Vektor2D(a.x - b.x, a.y - b.y);
        }

        // Množenje z naravnim številom
        public static Vektor2D operator *(Vektor2D a, int b)
        {
            return new Vektor2D(a.x * b, a.y * b);
        }

        // Pomožna metoda za preoblikovanje vektorja v niz
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }

}
