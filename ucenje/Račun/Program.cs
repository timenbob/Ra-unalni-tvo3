using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Račun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ustvarimo nov račun za USD z tečajem 0.85 (1 USD = 0.85 EUR).
            Racun mojRacun = new Racun("USD", 0.85);

            // Polaganje 100 evrov na račun.
            mojRacun.Polog(100);

            // Izpis stanja.
            Console.WriteLine(mojRacun);

            // Polaganje dodatnih 50 evrov.
            mojRacun.Polog(50);

            // Izpis posodobljenega stanja.
            Console.WriteLine(mojRacun);
        }
    }

    public class Racun
    {
        private string valuta;
        private double stanje;
        private double tecaj;

        

        public Racun(string valuta, double tecaj)
        {
            this.valuta = valuta;
            this.stanje = 0;
            this.tecaj = tecaj;
        }

        public double StanjeEUR
        {
            get { return stanje * tecaj; }
        }

        public void Polog(double znesek)
        {
            stanje = znesek/tecaj;
        }

        public override string ToString()
        {
            return $"Stanje na računu: {stanje} {valuta}, kar je {StanjeEUR} EUR.";
        }

    }
}
