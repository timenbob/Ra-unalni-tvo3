using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nalogaC
{
    public class Artikel
    {

        private double _CenaNaKg;
        private double _Masa;

        public double Masa
        {
            get { return _Masa; }
        }
        public double CenaNaKg
        {
            get { return _CenaNaKg; }
        }

        public Artikel(double cena, double nakg)
        {
            _Masa = cena;
            _CenaNaKg = nakg;
            
        } 
    }
    public class Narocilo
    {
        //private Artikel[] artikli;

        private List<Artikel> artikli = new List<Artikel>();

        private double cena;
        private int velikost;

        public double Cena
        {
            get
            {
                double cena = 0;
                for (int i = 0; i < artikli.Count; i++)
                {
                    cena += artikli[i].Masa + artikli[i].CenaNaKg;
                }
                return cena;
            }
        }
        public int Velikost
        {
            get { return artikli.Count; }
        }

        public Narocilo()
        {
            artikli = new List<Artikel>();
        }

        public void DodajArtikel(Artikel ar)
        {
            artikli.Add(ar);
        }

        public Artikel VrniArtikel(int i)
        {
            return artikli[i];
        }

        public static Narocilo operator +(Narocilo a ,Artikel b)
        {
            Narocilo nar = new Narocilo();
            for (int i = 0;i < a.artikli.Count;i++)
            {
                nar.DodajArtikel(a.artikli[i]);
            }
            nar.DodajArtikel(b);

            return nar;

        } 
    }
}
