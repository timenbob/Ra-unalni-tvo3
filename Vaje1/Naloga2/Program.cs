using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            String b = Console.ReadLine();

            char[] stringArray_a = a.ToCharArray();
            Array.Reverse(stringArray_a);
            string reversedStr_a = new string(stringArray_a);

            char[] stringArray_b = b.ToCharArray();
            Array.Reverse(stringArray_b);
            string reversedStr_b = new string(stringArray_b);

            int reversedStr_ai = int.Parse(reversedStr_a);
            int reversedStr_bi = int.Parse(reversedStr_b);

            Console.WriteLine(""+ reversedStr_ai+"+"+ reversedStr_bi + "=" + (reversedStr_ai + reversedStr_bi));

        }
    }
}
