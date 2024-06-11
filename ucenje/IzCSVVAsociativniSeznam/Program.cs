using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IzCSVVAsociativniSeznam
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                NaDatoteko("", "izhodna1.txt");

            }

            public static void NaDatoteko(string vhodna, string izhodna)
            {
                if (vhodna == string.Empty) throw new Exception("Nisi podal vhodne datoteke!");

                using (StreamReader sr = File.OpenText(vhodna))
                {
                    using (StreamWriter sw = File.CreateText(izhodna))
                    {
                        string[] lastnosti = sr.ReadLine().Trim().Split(',');
                        string vrstica;
                        int kateraVrstica = 0;

                        while ((vrstica = sr.ReadLine()) != null)
                        {
                            kateraVrstica++;
                            string[] posamezna = vrstica.Trim().Split(',');
                            if (posamezna.Length != lastnosti.Length) throw new Exception($"V vrstici {kateraVrstica}. {vrstica}, je prišlo do napake!");
                            sw.Write("[");
                            for (int i = 0; i < lastnosti.Length - 1; i++)
                            {
                                sw.Write($"({lastnosti[i]}, {posamezna[i]}), ");
                            }
                            sw.Write($"({lastnosti[lastnosti.Length - 1]}, {posamezna[lastnosti.Length - 1]})]\n");
                        }
                    }
                }
            }
        
    }
}

