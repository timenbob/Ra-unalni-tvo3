using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public interface IGeomLik
        {
            double Ploščina();
            double Obseg();

        }

        public class GeometrijskaLik<T> where T : IGeomLik
        {
            public static (double, int) Prečisti(T[] liki)
            {
                Dictionary<double, T> likiPoPloščini = new Dictionary<double, T>();
                double izbrisanePloščine = 0;
                int izbrisaniElementi = 0;

                foreach (var lik in liki)
                {
                    double ploščina = lik.Ploščina();
                    if (!likiPoPloščini.ContainsKey(ploščina))
                    {
                        likiPoPloščini.Add(ploščina, lik);
                    }
                    else
                    {
                        // Element z isto ploščino že obstaja, zato ga izbrišemo
                        izbrisanePloščine += ploščina;
                        izbrisaniElementi++;
                    }
                }

                // Izračunamo vsoto obsegov
                double vsotaObsegov = liki.Sum(lik => lik.Obseg());

                return (vsotaObsegov - izbrisanePloščine, izbrisaniElementi);
            }
            public static bool SemEnak(T lik1, T lik2)
            {
                return lik1.Ploščina() == lik2.Ploščina();
            }
        }


    }
}
