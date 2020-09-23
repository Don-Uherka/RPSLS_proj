using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gesture
    {
        //member variables
        public List<Gesture> Gestures = new List<Gesture>();
        public string Paper;
        public string Scissors;
        public string Rock;
        public string Lizard;
        public string Spock;
        //constructer
        public Gesture(string Paper, string Scissors, string Rock, string Lizard, string Spock)
        {
            this.Paper = Paper;
            this.Scissors = Scissors;
            this.Rock = Rock;
            this.Lizard = Lizard;
            this.Spock = Spock;
        }

        //methods
    }
}
