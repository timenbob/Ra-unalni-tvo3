using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Majica
{
    internal class Program
    {
        static void Main(string[] args) {}
    }

    public class Majica
    {
        private int velikost;
        private string barva;
        private Boolean rokavi;

        public Majica(int velikost, string barva, Boolean rokavi)
        {   
            if (velikost >5 || velikost<1) {
                throw new Exception("Majca ima velikosti le od 1 do 5");            
            }

            this.velikost = velikost;
            this.barva = barva;
            this.rokavi = rokavi;
        }

        public int Velikost 
        {
            get{return velikost;}
            set { 
                if (1 <= value || value<= 5){velikost = value; } 
            }
        }
        public String Barva
        {
            get { return barva; }
            set
            {
                if (typeof(string) == value.GetType())  
                { 
                    barva = value;
                }
            }
        }

        public String Rokavi
        {
            get { 
                if (rokavi == true)
                {
                    return "dolgi";
                }
                else
                {
                    return "kratki";
                }
                
                }
            set { throw new Exception("Ne uničuj majc"); }
        }

    }
}
