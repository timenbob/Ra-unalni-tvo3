using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromSt
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 90;
            int b = 130;
            string odg = "Palindromska števila med 90 in 130 so 99, 101, 111, 121.";
            Console.WriteLine(Program.Palindroma(a, b)); 
        }

        public static string Palindroma(int a, int b)
        {
            string niz = "";
            int j = 0;
            for(int i = a; i<=b; i++)
            {
                string obrnjenNiz = "";
                foreach (char h in i.ToString())
                {
                    obrnjenNiz = h + obrnjenNiz;
                }
                if (i.ToString() == obrnjenNiz)
                {
                    niz= niz+ i.ToString()+", ";
                }
            }
            if(niz=="")
            {
                return ($"Med {a} in {b} ni palindromskih števil.");
            }
            else
            {
                niz=niz.Substring(0,niz.Length-2);
                return ($"Palindromska števila med {a} in {b} so {niz}.");
            }
        }


    }
}
