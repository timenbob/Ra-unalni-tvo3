using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registracije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Registracija[] registracija = { new Registracija("LJ","12345"), new Registracija("KR", "12345"), new Registracija("MB", "12345")};

        }

        public class Registracija
        {
            private string obmocje;
            private string regi;
            public static string[] obmocja = { "LJ", "KR", "KK", "MB", "KP" };

            public string Obmocje
            {
                get { return obmocje; }
                set 
                { 
                    if(obmocja.Contains(value))
                    {
                        obmocje = value; 
                    }
                    else { throw new Exception("ecwe"); }
                    
                }
            }  
            
            public string Regi
            {
                get { return regi; }
                set
                {
                    if (value.Length == 5)
                    {
                       regi = value;
                    }
                    else { throw new Exception("ecwe"); }
                }
                
            }
            public Registracija(string obmocje, string regi)
            {
                Obmocje = obmocje;
                Regi = regi;
                
            }

            public override string ToString()
            {
                return Obmocje+"_"+Regi;
            }

            public static void brisiobomcje( string obmocje)
            {
                string[] novi=new string[obmocja.Length-1];
                int index = 0;
                for(int i=0; i<obmocja.Length; i++)
                {
                    if (obmocja[i] != obmocje)
                    {
                        novi[index] = obmocje;
                        index++;
                    }
                }
                obmocja= novi;
            }
        }
    }
}
