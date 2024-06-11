using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Masa
{
    public class Masa : IComparable<Masa>
    {
        public static string[] enoteVse = { "kg", "dag", "funt", "g" };
        Dictionary<string, int> pretvori = new Dictionary<string, int>
        {
            { "kg", 1000 },
            { "dag", 100 },
            { "funt", 2441 },
            {"g",1 }
        };

        string _enota;
        int kolicina;

        public string Enota
        {
            get { return _enota; }
            set 
            {
                int vg = Kolicina * pretvori[_enota];
                int vE = vg / pretvori[value];
                _enota = value;
                Kolicina = vE;
            }
        }
        public int Kolicina
        {
            get { return kolicina; }
            set 
            {
                if (value < 0) { throw new ArgumentException("kolicina mora biti pozitivna"); }
                kolicina = value;
            }
        }

        public Masa(int kolicina, string enota)
        {
            kolicina = 1;
            _enota = "g";
            Enota = enota;
            Kolicina = kolicina;
        }
       
        public static int Faktor(string enota)
        {
            if (enota == "kg") { return 1000; }
            else if (enota == "dag") { return 100; }
            else if (enota == "funt") { return 2441; }
            else if (enota == "g") { return 1; }
            else { throw new ArgumentException("neveljavna enota"); }
        }

        public override string ToString()
        {
            return $"{Kolicina} {Enota}";
        }

        public static Masa operator +(Masa a,Masa b)
        {
            string en = a.Enota;
            int kol= a.Kolicina*Faktor(en)+b.Kolicina+Faktor(b.Enota);
            Masa odg = new Masa(kol, "g");
            odg._enota = en;
            return odg;
        }

        public static Masa operator *(Masa a, int b)
        {
            if (b <= 0) { throw new ArgumentException("nemoremo mnoziti z negativnom"); }
            else
            {
                return new Masa(a.kolicina*b, a.Enota);
            }
           
        }

        public static Masa operator *( int b,Masa a)
        {
            return a * b;

        }

        public int CompareTo(Masa other)
        {
            return this.Kolicina * Faktor(this.Enota).CompareTo(other.Kolicina * Faktor(other.Enota));
        }

        public static Masa[] NajvecjaMasa(Masa[] tabela)
        {
            int stNajvecjih = 0;
            Masa najvecjaMasa = new Masa(0, "g");
            // poiscemo koliko je najvecjih (dolzina nove tabele)
            for (int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i].CompareTo(najvecjaMasa) == 0) stNajvecjih++;
                else if (tabela[i].CompareTo(najvecjaMasa) > 0)
                {
                    stNajvecjih = 1;
                    najvecjaMasa = tabela[i];
                }
            }
            // ustvarimo in napolnimo novo tabelo kopij najvecjih
            Masa[] vseNajvecjeMase = new Masa[stNajvecjih];
            int stevecNovihMas = 0;
            for (int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i].CompareTo(najvecjaMasa) == 0)
                {
                    vseNajvecjeMase[stevecNovihMas] = new Masa(tabela[i].Kolicina, tabela[i].Enota);
                }
            }

            return vseNajvecjeMase;
        }
        public static Masa Sestej(Masa[] tabela)
        {
            Masa vsota = new Masa(0, "g");
            int stGramov = 0;
            int stDag = 0;
            int stFunt = 0;
            int stKg = 0;
            for (int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i].Enota == "g") stGramov++;
                else if (tabela[i].Enota == "dag") stDag++;
                else if (tabela[i].Enota == "funt") stFunt++;
                else if (tabela[i].Enota == "kg") stKg++;
                vsota = vsota + tabela[i];
            }

            int najStEnote = Math.Max(stGramov, Math.Max(stDag, Math.Max(stFunt, stKg)));
            if (najStEnote == stGramov) vsota.Enota = "g";
            else if (najStEnote == stDag) vsota.Enota = "dag";
            else if (najStEnote == stFunt) vsota.Enota = "funt";
            else if (najStEnote == stKg) vsota.Enota = "kg";

            return vsota;
        }
    }
}
