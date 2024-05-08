using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvader
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            this.dolzina = dolzina;
            this.sirina = sirina;
            this.visina = visina;
        }

        // Lastnosti
        public double Dolzina
        {
            get { return dolzina; }
            set { dolzina = value; }
        }

        public double Sirina
        {
            get { return sirina; }
            set { sirina = value; }
        }

        public double Visina
        {
            get { return visina; }
            set { visina = value; }
        }

        // Urejanje glede na volumen kvadra
        public int CompareTo(Kvader other)
        {
            double thisVolume = dolzina * sirina * visina;
            double otherVolume = other.dolzina * other.sirina * other.visina;
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
            return $"Dolžina: {dolzina}, Širina: {sirina}, Višina: {visina}";
        }
    }

}
