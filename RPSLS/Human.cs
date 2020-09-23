using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        // member variables
      

        //constructer
        public Human()
        {
            
        }

        //member methods
        public override void ChooseGesture()
        {
            Console.WriteLine("what number gesture would you like to choose?");
            int counter = 0;
           

            foreach (string item in gestures)
            {
                Console.WriteLine(counter + ": " + item);
                counter++;
            }
            string userinput = Console.ReadLine();
            this.chosenGesture = gestures [Convert.ToInt32(userinput)];
            //need to capture user input
            //once they pick a number, how do we capture a value from the list using that number
            //when we capture it, do we already have a variable that can hold the specific string gesture that they pick?
            Console.WriteLine();
        }
    }
}
