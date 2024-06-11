using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzCSVvHTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CSVHTML("vhod.txt", "izhod.txt");
        }

        public static void CSVHTML(string imeVhod, string imeIzhod)
        {
            //potrebujemo povezovalni niz ter nato ustvariti povezave
            string vhod = imeVhod;
            string izhod = imeIzhod;

            using (StreamReader sr = new StreamReader(vhod))
            {
                using(StreamWriter sw = new StreamWriter(izhod)) 
                {
                    sw.WriteLine("<table>");
                    string vrstica;
                    while((vrstica = sr.ReadLine()) != null)
                    {
                        string[] kosi = vrstica.Split(',');
                        if (kosi.Length == 3)
                        {
                            sw.WriteLine("<tr>");
                            foreach (string kosi2 in kosi)
                            {
                                sw.WriteLine("<td>"+kosi2+"</td>");
                            }

                            sw.WriteLine("</tr>");

                        }
                    }
                    sw.WriteLine("</table>");
                }
            }
            

        }
    }
}
