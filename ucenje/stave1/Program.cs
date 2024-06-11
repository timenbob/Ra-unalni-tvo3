using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stave1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ime = "stave.txt";
            while (ime == "")
            {
                Console.WriteLine("vpiši ime datoteke");
                ime = Console.ReadLine();
            }

            StreamReader sr = File.OpenText(ime); // sedaj jo bomo prebrali
            string vrsta = sr.ReadLine(); // preberemo prvo vrstico
            while (vrsta != null) // null : datoteke je konec!
            {
                string[] znaki = vrsta.Split(' ');
                if (znaki.Length != 2) { Console.WriteLine("Napačni podatki"); }
                else
                {
                    try
                    {
                        int goli = int.Parse(znaki[0]);
                        int razlika = int.Parse(znaki[1]);
                        if (goli - razlika >= 0)
                        {

                            Console.WriteLine("" + goli + ";" + razlika);
                        }
                        else { Console.WriteLine("nemogoče"); }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Napačni podatki");
                    }


                    

                }

                vrsta = sr.ReadLine();

            }
            sr.Close();
        }
    }
}
