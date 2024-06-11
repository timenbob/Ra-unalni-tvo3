using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StevkeSoDelitelhji
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int k = 666;
            Console.WriteLine(Program.stevke(a, b, k)); 
        }

        public static string stevke(int a,int b, int k)
        {
            string[] stevila = new string[b - a+1];
            int index = 0;
            for (int i = a; i<=b; i++)
            {
                string stevilo = "" + i;
                bool bl = true;
                for (int j = 0; j < stevilo.Length-1; j++)
                {
                    if(k%int.Parse(""+stevilo[j])!=0)
                    {
                        bl = false;
                        break;
                        
                    }
                }

                if(bl)
                {
                    stevila[index] = stevilo;
                    index++;

                }
                bl = true;
            }
            
            string niz = "";
            foreach (string s in stevila)
            {
                if(s != null)
                {
                    niz = niz + " " + s + ",";
                }
            }
            
            if (niz.Length > 0)
            {
                niz=niz.Substring(0,niz.Length-1);
                return $"Cela števila iz intervala[{a}, {b}], v katerih vsaka neničelna štev - ka deli {k}, so:{niz}.";

            }
            else { return $"V intervalu [{a}, {b}] ni celih števil, v katerih vsaka neničelna števka deli {k}."; }
        }
    }
}
