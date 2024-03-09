using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datoteka_nakjlučnih_števil
{
    internal class nakljucaStevila
    {
        static void Main(string[] args)
        {
            Ustvari(@"C:\Users\HP\source\repos\Programiranje_3\vaje3\datoteka nakjlučnih števil\vaja.txt", 5, 10, 9, 2);
            Console.ReadKey();
        }
        static void Ustvari(string ime, int maxvrstic, int maxstevil, int maxvrednost, int poravnaj=0)
        {
            Random random = new Random(); 
            using(StreamWriter sw = File.CreateText(ime))
            {
                for(int i = 0; i < maxvrstic; i++)
                {
                    string vrstica = "";

                    int stevila=random.Next(maxvrednost+1);
                    for (int j = 0; j < stevila; j++)
                    {
                        int nakljucno = random.Next(maxstevil+1);
                        vrstica += nakljucno.ToString().PadLeft(poravnaj) + "";
                    }
                    sw.WriteLine(vrstica.Trim());
                }
            }
        }
    }
}
