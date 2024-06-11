using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mnozimoSe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double stevec = 1;
            double imenovalec = 1;
            string pot = "stevila.txt";
            StreamReader sr = File.OpenText(pot); // sedaj jo bomo prebrali
            string vrst = sr.ReadLine(); // preberemo prvo vrstico
            while (vrst != null) // null : datoteke je konec!
            {
                Console.WriteLine(vrst);
                if (vrst.Contains("/"))
                {
                    string[]cleni =vrst.Split('/');
                    stevec *= int.Parse(cleni[0]);
                    imenovalec *= int.Parse(cleni[1]);
                }
                else
                {
                    stevec *= int.Parse(vrst);
                }
                vrst=sr.ReadLine();// zelo pomembno dat
            }
            sr.Close();
            Console.WriteLine(""+stevec+"/"+imenovalec);
            Console.ReadLine();
        }
    }
}
