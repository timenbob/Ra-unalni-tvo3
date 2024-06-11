using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnozenjeVDat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mnozi("ok.txt"));
            Console.WriteLine(Mnozi("ne.txt"));
        }

        public static string Mnozi(string vhod)
        {
            int cudne = 0;
            bool ali = true;
            int imenovalec = 1;
            int stevec = 1;

            using (StreamReader sr = new StreamReader(vhod))
            {
                string vrstica;

                while ((vrstica = sr.ReadLine()) != null)
                {
                    vrstica = vrstica.Trim();
                    if (string.IsNullOrWhiteSpace(vrstica))
                    {
                        cudne++;
                        continue;
                    }

                    string[] kosi = vrstica.Split('/');
                    int stevecVrstice;

                    if (kosi.Length == 1 && int.TryParse(kosi[0], out stevecVrstice))
                    {
                        stevec *= stevecVrstice;
                    }
                    else if (kosi.Length == 2 && int.TryParse(kosi[0], out stevecVrstice) && int.TryParse(kosi[1], out int imenovalecVrstice))
                    {
                        stevec *= stevecVrstice;
                        imenovalec *= imenovalecVrstice;
                    }
                    else
                    {
                        ali = false;
                        cudne++;
                    }
                }
            }

            if (ali)
            {
                return $"{stevec}/{imenovalec}";
            }
            else
            {
                throw new Exception($"Število napačnih vrstic: {cudne}");
            }
        }
    }
}
