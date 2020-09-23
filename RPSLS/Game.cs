using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables
        Player playerOne;
        Player playerTwo;
        Human human;
        

        //constructer
        public Game()
        {
            playerOne = new Human();
            
        }

        //methods
        public void ChooseGameMode()
        {
            Console.WriteLine("Do you want one player or two? Type '1' or '2':");
            string response = Console.ReadLine();
            switch(response)
            {
                case "1":
                    playerTwo = new AI();
                    break;
                case "2":
                    playerTwo = new Human();
                    break;
                default:
                    break;
            }

        }
        public void Intro()
        {
            Console.WriteLine( "Welcome! to the most intense game of Rock, Paper, Scissors ever! with a twist" );       
        }
        public void Rules()
        {
            Console.WriteLine("The rules are simple it is just like a normal game of rock, paper, scissors but adding lizard and spock to make things interesting!");
            Console.WriteLine("Rock crushes Scissors,  Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock");

        }
        public void Rounds()
        {            
            //what happens , step by step
            //while loop referencing score
            //I want playerOne and playerTwo to choose a gesture
            //I then want the two gestures to be compared to eachother 
            //I then want the player that had the winning gesture to gain a point            
        }
        public void Comparisons()
        {
            //if both players choose the same thing then we can see that it is a tie
            if(playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("it is a tie");
            }
            else
            {
                //which did playerOne choose 
                switch (playerOne.chosenGesture)
                {
                    //if rock beats lizard and scissors 
                    case "rock":
                        if(playerTwo.chosenGesture == "scissors")
                        {
                            playerOne.score++;
                            Console.WriteLine("rock crushes scissors");
                        }
                        else if(playerTwo.chosenGesture == "lizard")
                        {
                            playerOne.score++;
                            Console.WriteLine("rock crushes lizard");
                        }
                        else if(playerTwo.chosenGesture == "paper")
                        {
                            playerTwo.score++;
                            Console.WriteLine("paper covers rock");
                        }
                        else if(playerTwo.chosenGesture == "spock")
                        {
                            playerTwo.score++;
                            Console.WriteLine("spock vaporizes rock");
                        }
                        break;
                    case "paper":
                        if(playerTwo.chosenGesture == "rock")
                        {
                            playerOne.score++;
                            Console.WriteLine("paper covers rock");
                        }
                        else if(playerTwo.chosenGesture == "spock")
                        {
                            playerOne.score++;
                            Console.WriteLine("paper disproves spock");
                        }
                        else if(playerTwo.chosenGesture == "scissors")
                        {
                            playerTwo.score++;
                            Console.WriteLine("scissors cuts paper");
                        }
                        else if(playerTwo.chosenGesture == "lizard")
                        {
                            playerTwo.score++;
                            Console.WriteLine("lizard eats paper");
                        }
                        break;
                    case "scissors":
                        if(playerTwo.chosenGesture == "paper")
                        {
                            playerOne.score++;
                            Console.WriteLine("scissors cuts paper");
                        }
                        else if(playerTwo.chosenGesture == "lizard")
                        {
                            playerOne.score++;
                            Console.WriteLine("scissors decapitates lizard");
                        }
                        else if(playerTwo.chosenGesture == "rock")
                        {
                            playerTwo.score++;
                            Console.WriteLine("rock crushes scissors");
                        }
                        else if(playerTwo.chosenGesture == "spock")
                        {
                            playerTwo.score++;
                            Console.WriteLine("spock smashes scissors");
                        }
                        break;
                    case "lizard":
                        if(playerTwo.chosenGesture == "spock")
                        {
                            playerOne.score++;
                            Console.WriteLine("lizard poisons spock");
                        }
                        else if(playerTwo.chosenGesture == "paper")
                        {
                            playerOne.score++;
                            Console.WriteLine("lizard eats paper");
                        }
                        else if(playerTwo.chosenGesture == "rock")
                        {
                            playerTwo.score++;
                            Console.WriteLine("rock crushes lizard");
                        }
                        else if(playerTwo.chosenGesture == "scissors")
                        {
                            playerTwo.score++;
                            Console.WriteLine("scissors decapitates lizard");
                        }
                        break;
                    case "spock":
                        if(playerTwo.chosenGesture == "scissors")
                        {
                            playerOne.score++;
                            Console.WriteLine("spock smashes scissors");
                        }
                        else if(playerTwo.chosenGesture == "rock")
                        {
                            playerOne.score++;
                            Console.WriteLine("spock vaporizes rock");
                        }
                        else if(playerTwo.chosenGesture == "lizards")
                        {
                            playerTwo.score++;
                            Console.WriteLine("lizard poisons spock");
                        }
                        else if(playerTwo.chosenGesture == "paper")
                        {
                            playerTwo.score++;
                            Console.WriteLine("paper disproves spock");
                        }
                        break;
                    
                }
            }

            // I want to compare each item in the List and decide which item wins in that given comparison 
            // paper beats rock ect.
            //"rock", "paper", "scissors", "lizard", "spock" }
    }
        public void DisplayWinner()
        {
            if(playerOne.score > 1 && playerTwo.score < 2)
            {
                Console.WriteLine("Player One Wins!");
            }
            else if(playerTwo.score > 1 && playerOne.score < 2)
            {
                Console.WriteLine("Player Two Wins!");
            }
        }
        public void RunGame()
        {
            Intro();
            Rules();
            ChooseGameMode();
            while(playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                Comparisons();
            }
            
                
             
            
            DisplayWinner();










        }
    }
}
