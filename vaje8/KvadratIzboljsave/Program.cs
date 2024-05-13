using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvaderIzboljsave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kvader kol = new Kvader(5,1,5);
            Kvader kol2 = new Kvader(5, 2, 5);
            if (kol != kol2) { Console.WriteLine("jes"); };
            Console.WriteLine(kol);
            Console.WriteLine(kol.Povrsina().ToString());
            Console.WriteLine(kol.Prostornina().ToString());
            if (kol.CompareTo(kol2)<0) { Console.WriteLine("jes"); };
        }
    }

    public class Kvader : IComparable<Kvader>
    {
        private double dolzina;
        private double sirina;
        private double visina;

        // Konstruktor
        public Kvader(double dolzina, double sirina, double visina)
        {
            Dolzina = dolzina;
            Sirina = sirina;
            Visina = visina;
        }

        // Lastnosti
        public double Dolzina
        {
            get { return dolzina; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Dolžina mora biti pozitivna.");
                }
                this.dolzina = value;
            }
        }

        public double Sirina
        {
            get { return sirina; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Širina mora biti pozitivna.");
                }
                this.sirina = value;
            }
        }

        public double Visina
        {
            get { return visina; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Višina mora biti pozitivna.");
                }
                this.visina = value;
            }
        }

        // Urejanje glede na volumen kvadra
        public int CompareTo(Kvader other)
        {
            double thisVolume = this.Prostornina();
            double otherVolume = other.Prostornina();
            return thisVolume.CompareTo(otherVolume);
        }

        // Relacijski operatorji
        public static bool operator ==(Kvader a, Kvader b)
        {
            return a.Dolzina == b.Dolzina && a.Sirina == b.Sirina && a.Visina == b.Visina;
        }

        public static bool operator !=(Kvader a, Kvader b)
        {
            return !(a == b);
        }

        // Pomožna metoda za preoblikovanje kvadra v niz
        public override string ToString()
        {
            return $"Dolžina: {Dolzina}, Širina: {Sirina}, Višina: {Visina}";
        }

        // Metoda za površino
        public double Povrsina()
        {
            return 2 * (Dolzina * Sirina + Dolzina * Visina + Sirina * Visina);
        }

        // Metoda za prostornino
        public double Prostornina()
        {
            return Dolzina * Sirina * Visina;
        }
    }
}
