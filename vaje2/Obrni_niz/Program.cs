using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrni_niz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi niz: ");
            string mojNiz = Console.ReadLine();
            string obrnjenNiz = "";
            int i = 0;
            while (i<mojNiz.Length)
            {
                obrnjenNiz = mojNiz[i++] + obrnjenNiz;
                //i++;
            }
            Console.WriteLine(obrnjenNiz);
        }
    }
}