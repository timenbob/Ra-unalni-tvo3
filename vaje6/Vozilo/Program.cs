using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozilo
{
    

    public class Vozilo
    {
        //podatki
        private double gorivo;
        private double kapaciteta;
        private double poraba;

        //konstruktor
        public Vozilo(double kapaciteta, double poraba)
        {
            if (kapaciteta <= 0)
            {
                throw new ArgumentException("Kapaciteta ne sme biti negativna");
            }
            if (poraba <= 0)
            {
                throw new ArgumentException("Poraba ne sme biti negativna");

            }
            else
            {
                this.kapaciteta = kapaciteta;
                this.poraba = poraba;
                this.gorivo = kapaciteta;
            }
            
        }
        //lastnost get neki mi naredimo set nastavi
        public double PreostaliKilometri
        {
            get
            {
                return gorivo / poraba * 100;
            }
        }

        //metoda
        public void Crpalka()
        {
            gorivo = kapaciteta;
        }

        public Boolean AliPrevozi(double[] pot)
        {
            foreach (var el in pot)
            {
                if (el == 0)
                {
                    Crpalka();
                }
                if (el < 0 )
                {
                    throw new Exception("narobe pot");
                }
                if (el > PreostaliKilometri)
                {
                    return false;
                }
                gorivo -= el * poraba;
            }
            return true;
        }
    }
}
