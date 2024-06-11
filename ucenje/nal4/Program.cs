using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nal4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, double> slovar = new Dictionary<string, double>();
            string pot = @"ig.txt";
            StreamReader sr = File.OpenText(pot);
            string vrstica =sr.ReadLine();
            while (vrstica != null)
            {
                string[] parts = vrstica.Split(',');
                string ime = parts[0];
                string[] parts2= vrstica.Split(';');
                double vr = double.Parse(parts2[1])* double.Parse(parts2[2]);
                slovar[ime] = vr;
                Console.WriteLine(ime+","+vr);
                vrstica = sr.ReadLine();
                

            }
            sr.Close();
            var sortedSlovar = slovar.OrderBy(x => -x.Value);

            string pot2 = @"stKoševUrejeno.txt";
            StreamWriter dat = File.CreateText(pot2); 
            foreach(var s in sortedSlovar)
            {
                dat.WriteLine(""+s.Key+","+ s.Value);
            }

            dat.Close();




        }
    }
}
