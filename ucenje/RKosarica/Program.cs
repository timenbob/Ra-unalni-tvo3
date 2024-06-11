using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKosarica
{
    public class Oseba
    {
        public string Ime { get; set; }
        public int Starost { get; set; }

        public Oseba(string ime, int starost)
        {
            Ime = ime;
            Starost = starost;
        }

        public override string ToString()
        {
            return $"Oseba: {Ime}, Starost: {Starost}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ustvarimo pet objektov tipa Kosarica z različnimi tipi podatkov
            Kosarica<string> kosaricaNiz = new Kosarica<string>("Pozdravljen svet");
            Kosarica<int> kosaricaCeloStevilo = new Kosarica<int>(42);
            Kosarica<Oseba> kosaricaOseba = new Kosarica<Oseba>(new Oseba("Janez", 30));
            Kosarica<double> kosaricaRealnoStevilo = new Kosarica<double>(3.14159);
            Kosarica<int[]> kosaricaTabela = new Kosarica<int[]>(new int[] { 1, 2, 3, 4 });

            // Izpišemo vse objekte na zaslon
            Console.WriteLine(kosaricaNiz);
            Console.WriteLine(kosaricaCeloStevilo);
            Console.WriteLine(kosaricaOseba);
            Console.WriteLine(kosaricaRealnoStevilo);

            // Posebno obravnavanje tabele celih števil
            int[] tabela = kosaricaTabela.Objekt;
            Console.WriteLine("Tabela: " + string.Join(", ", tabela));

            // Spreminjanje vrednosti v kosaricah
            kosaricaNiz.Objekt = "Spremenjen niz";
            kosaricaCeloStevilo.Objekt = 100;
            kosaricaOseba.Objekt = new Oseba("Miha", 25);
            kosaricaRealnoStevilo.Objekt = 2.71828;
            kosaricaTabela.Objekt = new int[] { 5, 6, 7, 8 };

            // Ponoven izpis vseh objektov na zaslon
            Console.WriteLine(kosaricaNiz);
            Console.WriteLine(kosaricaCeloStevilo);
            Console.WriteLine(kosaricaOseba);
            Console.WriteLine(kosaricaRealnoStevilo);

            // Ponovno izpis tabele po spremembi
            tabela = kosaricaTabela.Objekt;
            Console.WriteLine("Tabela po spremembi: " + string.Join(", ", tabela));
        }
    }
}
