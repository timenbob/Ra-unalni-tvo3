using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fun2(10,20,6));
            Console.WriteLine(fun2(20, 40, 5));
        }

        public static string fun2(int a,int b,int k)
        {
            List<int> list = new List<int>();
            for (int i = a;i<=b;i++)
            {
                bool ja = true;
                string stevek = i.ToString();
                foreach(char s in stevek)
                {   
                    if(s == '0') { continue; }
                    if (k % int.Parse("" + s) != 0)
                    {
                        ja = false;
                        break;
                    }
                }
                if (ja)
                {
                    list.Add(i);
                }
            }

            if (!list.Any()) { return $"V intervalu[{a},{b}] ni celih st deljivih z {k}"; }
            else
            {
                string dodatek = "";
                foreach (int i in list)
                {
                    dodatek = dodatek +i.ToString()+", ";
                }
                string odg =dodatek.Substring(0,dodatek.Length-2);
                return $"Cela st iz intevala [{a},{b}] kjer vsaka deli 6 so:{odg}.";
            }
        }
    }
}
