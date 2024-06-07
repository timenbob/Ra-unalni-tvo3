using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsota1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static dynamic Sestej(dynamic[] sez)
        {
            dynamic res = sez[0]; // Nastavimo začetni rezultat na prvi element v seznamu
            for (int i = 1; i < sez.Length; i++) // Začnemo z zanko od indeksa 1
            {
                res = res + sez[i]; // Seštevamo elemente od drugega naprej
            }
            return res;
        }

        public static T SestejGen<T>(T[] sez) //where T : struct
        {
            T res = sez[0]; 
            for (int i = 1; i < sez.Length; i++) // Začnemo z zanko od indeksa 1
            {
                res = (dynamic)res + (dynamic)sez[i]; // Seštevamo elemente od drugega naprej
            }
            return res;
        }
    }
}
