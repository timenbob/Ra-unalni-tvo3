using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponovno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vhod = "ig.txt";
            string izhod = "stKoševUrejeno.txt";

            using (StreamReader sr = new StreamReader(vhod))
            {
                using (StreamWriter sw = new StreamWriter(izhod))
                {
                    Dictionary<string,double> map = new Dictionary<string,double>();
                    string vrstica;
                    while ((vrstica = sr.ReadLine()) != null)
                    {
                        string[] kosi = vrstica.Split(',');
                        string ime = kosi[0];
                        string[] pod = vrstica.Split(';');
                        double kosi1 = double.Parse(pod[1]) * double.Parse(pod[2]);

                        map[ime] = kosi1;

                    }
                    var urejen= map.OrderBy(x => - x.Value);
                    foreach(var el in urejen)
                    {
                        sw.WriteLine(el.Key.ToString()+" "+el.Value.ToString());
                    }
                }
            }
        }
    }               
}
