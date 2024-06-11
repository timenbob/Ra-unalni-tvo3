using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace srednjiElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4, 5, 6 };
            string[] tab2 = { "a", "b", "c", "d" };
            string[] tab3 = { "a", "b", "c" };
            string[] tab4 =new string[10];
            Console.WriteLine(sredina(tab));
            Console.WriteLine(sredina(tab2));
            Console.WriteLine(sredina(tab3));
            Console.WriteLine(sredina(tab4));
        }

        public static T sredina<T>(T[] tab)
        {
            if(tab.Length==0 || tab[0]==null) { throw new ArgumentNullException("tabele je prazna"); }

            if(tab.Length%2==0)//smo sodi 
            {
                if(typeof(T)== typeof(int)|| typeof(T) == typeof(double)) 
                {

                    double product = Convert.ToDouble(tab[tab.Length / 2 - 1]) * Convert.ToDouble(tab[tab.Length / 2]);
                    return (T)Convert.ChangeType(product, typeof(T));
                }
                if (typeof(T) == typeof(string))
                {
                    string product = "" + tab[tab.Length / 2 - 1] + tab[tab.Length / 2];
                    return (T)Convert.ChangeType(product, typeof(T));
                }
                else
                {
                    throw new Exception("wrv");
                }

            }
            else
            {   
                return tab[tab.Length / 2 ];
            }

        }
    }
}
