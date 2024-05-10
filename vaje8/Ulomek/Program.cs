using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulomek
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Ulomek : IComparable<Ulomek>
    {
        private int stevec;
        private int imenovalec;

        // Konstruktor
        public Ulomek(int stevec, int imenovalec)
        {
            Stevec = stevec;
            Imenovalec = imenovalec;
        }

        // Lastnosti
        public int Stevec
        {
            get { return stevec; }
            set { stevec = value; }
        }

        public int Imenovalec
        {
            get { return imenovalec; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Imenovalec ne sme biti 0.");
                imenovalec = value;
            }
        }

        // Urejanje glede na vrednost ulomka
        public int CompareTo(Ulomek other)
        {
            double thisValue = (double)stevec / imenovalec;
            double otherValue = (double)other.stevec / other.imenovalec;
            return thisValue.CompareTo(otherValue);
        }

        // Relacijski operatorji
        public static bool operator ==(Ulomek a, Ulomek b)
        {
            return (double)a.stevec / a.imenovalec == (double)b.stevec / b.imenovalec;
        }

        public static bool operator !=(Ulomek a, Ulomek b)
        {
            return !(a == b);
        }

        // Aritmetični operatorji
        public static Ulomek operator +(Ulomek a, Ulomek b)
        {
            return new Ulomek(a.stevec * b.imenovalec + b.stevec * a.imenovalec, a.imenovalec * b.imenovalec);
        }

        public static Ulomek operator -(Ulomek a, Ulomek b)
        {
            return new Ulomek(a.stevec * b.imenovalec - b.stevec * a.imenovalec, a.imenovalec * b.imenovalec);
        }

        // Množenje z naravnim številom
        public static Ulomek operator *(Ulomek a, int b)
        {
            return new Ulomek(a.stevec * b, a.imenovalec);
        }

        // Pomožna metoda za preoblikovanje ulomka v niz
        public override string ToString()
        {
            return $"{stevec}/{imenovalec}";
        }
    }

}
