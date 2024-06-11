using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolikoNajvecjih
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 7,5, 4, 3, 1, 1, 1,7, 8, 9, 8, 8, 9 ,7 };
            Console.WriteLine(tab);
            int[] najvecji= poisci(ref tab);
            Console.WriteLine(tab);
            Console.WriteLine(najvecji);
        }

        public static int KolikoNajvecjih<T>(T[] tab, out int najmanjsi) where T: IComparable<T>
        {
            int stevecMax = 1;
            T elM = tab[0];
            int stevecMin = 1;
            T elm = tab[0];
            foreach (T t in tab)
            {
                if (t.CompareTo(elM) > 0)
                {
                    elM = t;
                    stevecMax = 1;
                }
                else if (t.CompareTo(elM) == 0)
                {
                    stevecMax++;
                }

                if (t.CompareTo(elm) < 0)
                {
                    elm = t;
                }
            }
            najmanjsi = stevecMin;
            return stevecMax;
        }

        public static int[] poisci (ref int[] tab)
        {
            int deljivo = 0;
            int suma = 0;
            int[] tab2 = new int[2];
            for (int i=0; i < tab.Length; i++)
            {
                if(tab[i] % 7 == 0)
                {
                    deljivo++;
                }
                else
                {
                    suma += tab[i];
                }
            }
            int[] tab3 = new int[tab.Length - deljivo];
            int j = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 7 == 0)
                {
                    
                }
                else
                {
                    tab3[j] = tab[i];
                    j++;
                }
            }
            tab = tab3;
            tab2[0] = deljivo;
            tab2[1]= suma;
            return tab2;

        } 

        
    }

}
