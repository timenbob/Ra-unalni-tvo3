using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        double visina;
        double globina;
        double sirina;

        public double Visina
        {
            get { return visina; }
            set
            {
                if (value >= 0) { visina = value; }
                else { throw new Exception("narobe"); }
            }
        }
        public double Sirina
        {
            get { return sirina; }
            set
            {
                if (value >= 0) { sirina = value; }
                else { throw new Exception("narobe"); }
            }
        }

        public double Globina
        {
            get { return globina; }
        }

        public Kvader(double visina,double aglobina,double sirina)
        {
            Visina = visina;
            Sirina = sirina;
            globina = aglobina;

        }

        public double povrsina()
        {
            return Visina * Sirina + Visina * Globina + Globina * Sirina;
        }

        public static double Volumen(Kvader a)
        {
            return a.Sirina * a.Visina * a.Globina;
        }

        public double Ploščina
        {
            get { return Globina * Sirina; }
        }

        public override string ToString()
        {
            return $"Kvadra: Globina = {Globina}, Širina = {Sirina}, Višina = {Visina}";
        }

        public static Kvader operator *(Kvader a,double koef)
        {
            return new Kvader(a.Visina*koef,a.Globina*koef,a.Sirina*koef);
        }

        public static Kvader operator *(double koef, Kvader a)
        {
            return a * koef;
        }

     
        public int CompareTo(Kvader other)
        {
            if (other == null) return 1; // Null check

            // Primerjaj po prostornini
            return Volumen(this).CompareTo(Volumen(other));
        }

        public static Kvader NajnizjiKvader(Kvader[] kvadri)
        {
            if (kvadri == null || kvadri.Length == 0)
            {
                throw new ArgumentException("Tabela kvadrov ne sme biti prazna.");
            }

            Kvader najnizji = null;
            foreach (var kvader in kvadri)
        {
                if (najnizji == null || kvader.Visina <= najnizji.Visina)
                {
                    najnizji = kvader;
                }
            }

            // Vrnemo nov kvader z enakimi lastnostmi, da ne vplivamo na original
            return new Kvader(najnizji.Globina, najnizji.Sirina, najnizji.Visina);
        }








    }

}
