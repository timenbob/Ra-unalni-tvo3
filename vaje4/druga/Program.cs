using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace druga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool uspesno = false;
            while (uspesno == false) { 

            Console.WriteLine("Progra m izpiše vrednost izraza (a+b)/c, za cela števila a,b,c");
            try
            {
                Console.Write("Vnesi a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Vnesi b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Vnesi c: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("(a+b)/c = " + ((a + b) / c));
                uspesno = true;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("deliš z 0:");
            }
            catch (FormatException)
            {
                Console.WriteLine("ni celo št:");
            }
            catch (Exception e)
            {
                Console.WriteLine("Nekaj je šlo narobe:");
                Console.WriteLine(e.ToString());


            }
        }
        }
    }
}
