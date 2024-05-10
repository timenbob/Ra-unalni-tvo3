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
            Console.WriteLine(kol);
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
            return a.dolzina == b.dolzina && a.sirina == b.sirina && a.visina == b.visina;
        }

        public static bool operator !=(Kvader a, Kvader b)
        {
            return !(a == b);
        }

        // Pomožna metoda za preoblikovanje kvadra v niz
        public override string ToString()
        {
            return $"Dolžina: {this.dolzina}, Širina: {this.sirina}, Višina: {this.visina}";
        }

        // Metoda za površino
        public double Povrsina()
        {
            return 2 * (this.dolzina * this.sirina + this.dolzina * this.visina + this.sirina * this.visina);
        }

        // Metoda za prostornino
        public double Prostornina()
        {
            return this.dolzina * this.sirina * this.visina;
        }
    }
}
