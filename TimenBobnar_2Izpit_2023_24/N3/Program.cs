using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura tem = new Temperatura(5,"C");
         
            Console.WriteLine(tem);
        }
    }

    public class Temperatura
    {
        private double _vrednost;
        private string _enota;

        /// <summary>
        /// nastavimo vrednost
        /// </summary>
        public double Vrednost
        {
            get { return _vrednost; }
            set
            {
                if (value < AbsolutnaNičla())
                    throw new ArgumentException("Vrednost temperature ne more biti pod absolutno ničlo.");
                _vrednost = value;
            }
        }

        /// <summary>
        /// nastavimo enoto
        /// </summary>
        public string Enota
        {
            get { return _enota; }
            set
            {
                if (value != "C" && value != "F" && value != "K")
                    throw new ArgumentException("Neveljavna enota.");

                // Pretvorimo temperaturo, če spremenimo enoto
                if (_enota != null && _enota != value)
                {
                    Vrednost = Pretvori(this, value).Vrednost;
                }
                _enota = value;
            }
        }

        public Temperatura(double vrednost, string enota)
        {
            _enota = enota; // Postavi enoto brez pretvorbe
            Vrednost = vrednost; // Preveri absolutno ničlo
        }

        public override string ToString()
        {
            return $"{_vrednost} {_enota}";
        }

        /// <summary>
        /// funkcija vrne vrednost v drugi enoti
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="vEnoto"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double PretvoriVrednost(Temperatura temp, string vEnoto)
        {
            if (temp.Enota == vEnoto)
                return temp.Vrednost;

            double vrednostVKelvin;

            // Najprej pretvori v Kelvin
            switch (temp.Enota)
            {
                case "C":
                    vrednostVKelvin = temp.Vrednost + 273.15;
                    break;
                case "F":
                    vrednostVKelvin = (temp.Vrednost - 32) * 5 / 9 + 273.15;
                    break;
                case "K":
                    vrednostVKelvin = temp.Vrednost;
                    break;
                default:
                    throw new ArgumentException("Neveljavna začetna enota.");
            }

            // Potem pretvori iz Kelvin v želeno enoto
            switch (vEnoto)
            {
                case "C":
                    return vrednostVKelvin - 273.15;
                case "F":
                    return (vrednostVKelvin - 273.15) * 9 / 5 + 32;
                case "K":
                    return vrednostVKelvin;
                default:
                    throw new ArgumentException("Neveljavna ciljna enota.");
            }
        }

        /// <summary>
        /// vrnemo nvi objekt v novi enoti
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="vEnoto"></param>
        /// <returns></returns>
        public static Temperatura Pretvori(Temperatura temp, string vEnoto)
        {
            double novaVrednost = PretvoriVrednost(temp, vEnoto);
            return new Temperatura(novaVrednost, vEnoto);
        }

        private double AbsolutnaNičla()
        {
            switch (_enota)
            {
                case "C":
                    return -273.15;
                case "F":
                    return -459.67;
                case "K":
                    return 0;
                default:
                    throw new ArgumentException("Neveljavna enota.");
            }
        }

        public static Temperatura operator +(Temperatura t1, Temperatura t2)
        {
            double t2VrednostVT1Enoti = PretvoriVrednost(t2, t1.Enota);
            return new Temperatura(t1.Vrednost + t2VrednostVT1Enoti, t1.Enota);
        }

        public static Temperatura operator *(Temperatura t, int faktor)
        {
            return new Temperatura(t.Vrednost * faktor, t.Enota);
        }

        
        }
    }
    }
