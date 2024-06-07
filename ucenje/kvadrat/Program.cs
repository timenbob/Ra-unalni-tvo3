using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace kvadrat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                // Primer uporabe razreda Kvader
                Kvader kvader1 = new Kvader(3, 4, 5);
                Kvader kvader2 = new Kvader(2, 3, 6);
                Kvader kvader3 = new Kvader(1, 5, 4);

                Kvader[] kvadri = { kvader1, kvader2, kvader3 };

                // Izračun površine kvadra
                double povrsina = kvader1.Povrsina();
                Console.WriteLine("Površina kvadra: " + povrsina);

                // Izračun volumna kvadra
                double volumen = Kvader.Volumen(kvader1);
                Console.WriteLine("Volumen kvadra: " + volumen);

                // Izračun površine osnovne ploskve kvadra
                double ploscina = kvader1.Ploscina;
                Console.WriteLine("Ploščina osnovne ploskve kvadra: " + ploscina);

                // Množenje kvadra s faktorjem
                Kvader povecaniKvader = kvader1 * 2;
                Console.WriteLine("Povečani kvader: " + povecaniKvader);

                // Urejanje kvadrov po volumnu
                Array.Sort(kvadri);
                Console.WriteLine("Urejeni kvadri po volumnu:");
                foreach (var kvader in kvadri)
                {
                    Console.WriteLine(kvader);
                }

                // Najdba kvadra z najmanjšo višino
                Kvader najnizjiKvader = Kvader.NajnizjiKvader(kvadri);
                Console.WriteLine("Najnizji kvader: " + najnizjiKvader);
            }
        }

    }
    

    public class Kvader : IComparable<Kvader>
    { 
        double _visina;
        double _globina;
        double _sirina;

        public double Visina
        {
            get { return _visina; }
            set {
                if (value > 0) { _visina = value; }
                else { throw new Exception("negre"); }
            }

        }
        public double Sirina
        {
            get { return _sirina; }
            set
            {
                if (value > 0) { _sirina = value; }
                else { throw new Exception("negre"); }
            }

        }
        public double Globina
        {
            get { return _globina; }

        }

        public Kvader(double visina, double globina, double sirina)
        {
            this.Visina = visina;
            this.Sirina = sirina;
            if (globina > 0) { _globina = globina; }
            else { throw new Exception("negre"); }
        }

        /// <summary>
        /// •	Metodo povrsina, ki vrne površino objekta (kvadra),
        /// </summary>
        /// <returns></returns>
        public double Povrsina()
        {
            return (2 * (Globina * Visina + Globina * Sirina + Visina * Sirina));
        }
        /// <summary>
        /// •	Statično metodo volumen, ki vrne volumen kvadra, podanega kot parameter
        /// </summary>
        /// <param name="kvader"></param>
        /// <returns></returns>
        public static double Volumen(Kvader kvader)
        {

            return kvader.Globina * kvader.Sirina * kvader.Visina;
        }

        /// <summary>
        /// •	Bralno lastnost ploščina, ki pove ploščino osnovne ploskve kvadra (globina x širina),
        /// </summary>
        public double Ploscina
        {
            get { return Globina * Sirina; }
        }

        public static Kvader operator *(Kvader kvader, double faktor)
        {
            if (faktor <= 0)
            {
                throw new Exception("ne množi z manj kot nic");
            }
            return (new Kvader(kvader.Visina * faktor, kvader.Sirina * faktor, kvader.Globina * faktor));
        }

        public static Kvader operator *(double faktor, Kvader kvader)
        {
            return (kvader * faktor);
        }

        public override string ToString()
        {
            return $"Kvader [Višina: {Visina}, Širina: {Sirina}, Globina: {Globina}]";
        }

        public int CompareTo(Kvader other)
        {
                if (other == null) return 1;

                return Volumen(this).CompareTo(Volumen(other));
        }


        public static Kvader NajnizjiKvader(Kvader[] tab)
        {
            int index=0;
            double visina = tab[0].Visina;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i].Visina <= visina)
                {
                    visina = tab[i].Visina;
                    index = i;
                }
            }
            return new Kvader(tab[index].Visina, tab[index].Globina, tab[index].Sirina);
        }

    }

