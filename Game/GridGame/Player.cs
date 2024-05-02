using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridGame
{
    internal class Player
    {
        private int Wins;
        private int Walls;//začetno kok zidov ima
        private int Pozitins;
        private string Name;

        public Player(string Name,int Walls, int Wins=0, int Pozitions=0)
        {
            this.Name = Name;
            this.Wins = Wins;
            this.Walls = Walls;
            this.Pozitins = Pozitions;
        }

        public string name {  get { return this.Name; } }

        public int StWins
        {
            get { return this.Wins; }
            set {
                if (value < 0) { throw new ArgumentOutOfRangeException("stevilo zmag ne more biti negativno"); }
                this.Wins = value; }
        }

        public int stWalls
        {
            get { return this.Walls; }
            set {if(this.Walls < 0) { throw new ArgumentException("Zidov je lahko samo pozitivno"); } 
                this.Walls = value; }//TODO ali bo samo da odstejemo zid al spremenimo
        }

        public int stPozitins
        {
            get { return this.Pozitins;}
            set {if(this.Pozitins < 0) { throw new ArgumentException("Žetonov je najman 0 na polju"); } 
                this.Pozitins = value;}
        }
    }
}
