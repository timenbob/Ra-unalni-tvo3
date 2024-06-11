using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLaDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zmanjševanec: ");
            double zmanjsevanec = double.Parse(Console.ReadLine());
            if (zmanjsevanec < 0) throw new Exception("Zmanjševanec mora biti pozitiven!");

            Console.Write("Odštevanec: ");
            double odstevanec = double.Parse(Console.ReadLine());
            if (odstevanec < 0) throw new Exception("Odštevanec mora biti pozitiven!");
            else if (odstevanec >= zmanjsevanec) throw new Exception("Odštevanec mora biti manjši od zmanjševanca!");

            Console.WriteLine((double)(zmanjsevanec - odstevanec));
            Console.ReadKey();
        }
    }
}
