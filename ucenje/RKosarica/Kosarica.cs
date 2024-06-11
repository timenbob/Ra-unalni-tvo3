using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKosarica
{
    public class Kosarica<T>
    {
        private T objekt; 
        
        public T Objekt
        {
            get { return objekt; }
            set {objekt= value; } 
        }

        public Kosarica(T objekt)
        {
            Objekt = objekt;
        }

        public override string ToString()
        {
            return Objekt.ToString();
        }
    }
}
