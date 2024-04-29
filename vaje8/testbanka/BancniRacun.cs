using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testbanka
{
    public class BancniRacun
    {
        //2.1m je zapis v decimal brez m bi biu double
        //podatki
        private decimal _stanje;

        //Lastnosti
        public decimal Stanje { get { return _stanje; } }

        // konstruktor naredimo če hočmo ko naredimo objekt naredit še kej
        // kliče se le ko uporabimo new
        public BancniRacun()
        {
            _stanje = 5;
            Console.WriteLine("mas 5e");
        }

        //Metode
        public void Dvig(decimal dvig)
        {
            if (dvig < 0)
            {
                throw new ArgumentException("dvig nesme biti negativen to je polog");
            }
            //if (dvig > _stanje) { throw Exception("nimas dovolj denarja"); }
            else {_stanje -= dvig;}
            
        }

        public void Polog(decimal polog)
        {
            if (polog < 0)
            {
                throw new ArgumentException("polog nesme biti negativen to je dvig");
            }
            else {_stanje += polog; }
            
        }
    }
}
