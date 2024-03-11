using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prva
{
    internal class prva
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program izpiše vrednost izraza (a+b)/c, za cela števila a,b,c");
            try
            {
                Console.Write("Vnesi a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Vnesi b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Vnesi c: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("(a+b)/c = " + ((a + b) / c));
            }
            catch(DivideByZeroException) {
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
                Console.WriteLine("Popravi program, da bo to izjemo obravnaval posebej.");
            }
        }
    }
}
