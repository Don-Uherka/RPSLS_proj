using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        // member variables
        public int score;
        public string chosenGesture;
        public List<string> gestures;

        //constructer
        public Player()
        {
            score = 0;
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        }

        //member methods
        public abstract void ChooseGesture();
        

        
    }
}
