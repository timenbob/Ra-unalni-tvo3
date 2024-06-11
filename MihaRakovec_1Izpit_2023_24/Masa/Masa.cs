using System;
using System.Linq;

namespace Masa
{
    public class Masa: IComparable<Masa>
    {
        public static string[] dovoljeneEnote = { "kg", "dag", "funt", "g" };

        private string _enota;
        private int _koliko;

        public Masa(int koliko, string enota)
        {
            Koliko = koliko;
            Enota = enota;
        }

        public string Enota
        {
            get { return _enota; }
            set 
            {
                if (!(dovoljeneEnote.Contains(value))) throw new ArgumentException("Dovoljene so le enote: kg, dag, funt in g"); 
                else
                {
                    _enota = value;
                    // pretvorimo v novo enoto
                    int vGramih = Faktor(_enota) * this.Koliko;
                    this.Koliko = (int)(1.0 / Faktor(value) * vGramih);
                }
            }
        }

        public int Koliko
        {
            get { return _koliko;}
            set
            {
                if (value < 0) throw new ArgumentException("Količina ne more biti negativna.");
                else _koliko = value;
            }
        }

        /// <summary>
        /// Za dano mersko enoto vrne, koliko je ta enota izražena v gramih.
        /// </summary>
        /// <param name="enota">Merska enota</param>
        /// <returns></returns>
        public static int Faktor(string enota)
        {
            if (enota == "funt") return 2441;
            else if (enota == "kg") return 1000;
            else if (enota == "dag") return 10;
            else return 1;
        }

        public override string ToString()
        {
            int vGramih = Faktor(_enota) * this.Koliko;
            double vDag = (vGramih / 10);
            return vDag.ToString() + " dag";
        }

        public int CompareTo(Masa other)
        {
            int prvi = this.Koliko * Faktor(this.Enota);
            int drugi = other.Koliko * Faktor(other.Enota);
            return prvi - drugi;
        }

        public static Masa operator +(Masa prvi, Masa drugi)
        {
            int drugiVGramih = drugi.Koliko * Faktor(drugi.Enota);
            int drugiVEnotiPrvega = (int)(1.0 / Faktor(prvi.Enota) * drugiVGramih);
            return new Masa(prvi.Koliko + drugiVEnotiPrvega, prvi.Enota);
        }

        public static Masa operator *(Masa masa, int stevilo)
        {
            if (stevilo <= 0) throw new ArgumentException("Mase lahko množime le z pozitivnimi števili.");
            return new Masa(masa.Koliko * stevilo, masa.Enota);
        }
        public static Masa operator *(int stevilo, Masa masa)
        {
            return masa * stevilo;
        }

        /// <summary>
        /// Vrne tabelo kopij vseh največjih mas iz dane tabele.
        /// </summary>
        /// <param name="tabela">Tabela mas</param>
        /// <returns></returns>
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
                    vseNajvecjeMase[stevecNovihMas] = new Masa(tabela[i].Koliko, tabela[i].Enota);
                }
            }

            return vseNajvecjeMase;
        }

        /// <summary>
        /// vrne novo maso, ki je vsota vseh mas dane table, izražena v najbolj pogosti enoti
        /// </summary>
        /// <param name="tabela">Tabela mas</param>
        /// <returns></returns>
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
