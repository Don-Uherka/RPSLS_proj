using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        // member variables 
        Random rand;
        //constructer
        public AI()
        {
            rand = new Random();
        
            
        }

        //member methods
        public override void ChooseGesture()
        {

            int number = rand.Next(gestures.Count);
            this.chosenGesture = gestures[number];
            Console.WriteLine();

            //first, get a random number, save it as a variable
            //use that variable to grab a random index of the list
            //set that thing from the list to the AI's member variable
        }
            

        
    }
}
