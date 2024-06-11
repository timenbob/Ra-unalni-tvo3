using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majica
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Majica
    {
        private HashSet<string> mozneBarve = new HashSet<string>();


        private int velikost;
        private string barva;
        private bool rokavi;

        public int Velikost
        {
            get { return velikost; }
            set {
                if (value >= 1 && value <= 5) { velikost = value; }
                else { throw new ArgumentException("take velikosti ni")}
            }
        }

        public string Barva
        {
            get { return barva; }
            set { barva = value; }
        }

        public bool Rokavi
        {
            get { return rokavi; }
        }
    }
}
