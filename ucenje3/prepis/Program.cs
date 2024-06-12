using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prepis("vnos.txt");
        }

        public static void Prepis(string imeVhod, string imeizhod = "izhod.txt")
        {
            if (File.Exists(imeizhod))
            {
                throw new Exception("dat obstaja");
            }
            else
            {
                using (StreamReader sr = new StreamReader(imeVhod))
            {
                using (StreamWriter sw = new StreamWriter(imeizhod))
                {
                    string vrstica;
                    int stevec = 1;
                    while ((vrstica = sr.ReadLine()) != null)
                    {
                        if (vrstica != "")
                        {
                            sw.WriteLine($"{stevec}: {vrstica}");
                                stevec++;
                        }
                    }
                }


            }
            }

            
        }
    }
}
