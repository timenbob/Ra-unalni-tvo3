using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnostavnaStevila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "12. 3. 2020";
            string str2 = "D12";
            string str3 = "a1b2c3d9";
            string str4 = "1";
            Console.WriteLine(EnostavnaStevila(str4));


        }

        public static int EnostavnaStevila(string str)
        {
            int number1;
            int number2;
            int number3;

            int stevec = 0;
            if (str.Length == 0) { return 0; }
            if (str.Length == 1) 
            {
                if (Int32.TryParse("" + str[0], out number1))
                {
                    return 1;
                }
            }

            for (int i = 1; i < str.Length-1; i++)
            {
                bool bol1 = Int32.TryParse(""+  str[i - 1], out number1);
                bool bol2 = Int32.TryParse("" + str[i ], out number2);
                bool bol3 = Int32.TryParse("" + str[i +1], out number3);
                if (bol1 == false && bol2 == true && bol3 == false) 
                {
                    stevec++;
                }

            }
            if (Int32.TryParse("" + str[0], out number1) && !Int32.TryParse("" + str[1], out number1) ){ stevec++; }
            if (Int32.TryParse("" + str[str.Length - 1], out number1) && !Int32.TryParse("" + str[str.Length - 2], out number1)) { stevec++; }

            return stevec;
        }
    }
}
