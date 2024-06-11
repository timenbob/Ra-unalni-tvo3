using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Temperatura : IComparable<Temperatura>
    {
        public string[] enote = { "C", "F", "K" };
        public Dictionary<string, double> absnicle = new Dictionary<string, double>
        {
            { "C",-273 },
            {"F",-441 },
            {"K",0 }

        };

        private string enota;
        private double vrednost;
        public string Enota
        {
            get { return enota; }
            set
            {
                if (enote.Contains(value))
                {
                    Vrednost=PretvoriV(this, value);
                    enota = value;

                }
            }


        }

        public double Vrednost
        {
            get { return vrednost; }
            set
            {
                if (value >= absnicle[enota])
                {
                    vrednost = value;
                }
            }
        }

        public Temperatura(double vre,string en)
        {
            vrednost = vre;
            enota = en;
        }


        public static double PretvoriV(Temperatura A, string enota)
        {
            double vr = A.Vrednost;
            if (A.Enota == enota) { return vr; }
            if (A.Enota == "K" || enota == "C") { return vr + 273.15; }
            if (A.Enota == "C" || enota == "K") { return vr - 273.15; }

            if (A.Enota == "K" || enota == "F") { return vr * 9 / 5 + 32; }
            if (A.Enota == "F" || enota == "K") { return (vr - 32) * 5 / 9 + 273.15; }

            if (A.Enota == "F" || enota == "C") { return (vr - 32) * 5 / 9 + 273.15 + 273.15; }
            if (A.Enota == "C" || enota == "F") { return (vr - 273.15) * 9 / 5 + 32; }
            else { return 0; }
        }

        public static Temperatura pretvori(string enota, double tem, string enota2)
        {
            return new Temperatura(PretvoriV(new Temperatura(tem, enota), enota2), enota2);
        }

        public override string ToString()
        {
            return $"{PretvoriV(this,"C")} C";
        }

        public static Temperatura operator +(Temperatura a, Temperatura b)
        {
            string enota = a.Enota;
            double vsota = PretvoriV(b, enota) + a.Vrednost;
            return new Temperatura(vsota,enota);
        }
        public static Temperatura operator *(double a, Temperatura b)
        {
            string enota = b.Enota;
            double vsota = b.Vrednost * a;
            return new Temperatura(vsota, enota);
        }
        public static Temperatura operator *(Temperatura a, double b)
        {
            return b * a;
        }

        public int CompareTo(Temperatura other)
        {
            return PretvoriV(this, "K").CompareTo(PretvoriV(other, "K"));
        }

        public static Temperatura Mediana(Temperatura[] sez)
        {
            Array.Sort(sez);
            return sez[sez.Length / 2];
        }
    }
}
