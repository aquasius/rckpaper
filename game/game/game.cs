using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class game
    {
        // member variables ( HAS A )
         AbstractPlayer player1;
         AbstractPlayer player2;
        




        // constructor 




        // member methods (CAN DO) 
        public void RunGame()
        {
            DisplayRules();

            string NumberPlayers = ChooseNumberPlayers();
            Console.ReadLine();

           

            CreatePlayers(NumberPlayers);
            player1.ChooseName();
            player2.ChooseName();
            player1.ChooseGesture();
            player2.ChooseGesture();
            


            while (player1.score < 2 && player2.score < 2)
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                GestureRoundWin();
                
            if (player1.score == 2)
                {
                    DetermineWinner();
                    
                }
            else if (player2.score == 2)
                {
                    DetermineWinner();
                    
                }

            }



        }
        public void DisplayRules()
        {
            Console.WriteLine("Choose either 'Rock','Paper','Scissors','Lizard', or 'Spock'  to defeat your opponent!");
            Console.ReadLine();
        }


        private void DetermineWinner()
        {
            if (player1.score == 2)
            {
                Console.WriteLine(player1.name + "you won!");
                Console.ReadLine();
            }

            else if (player2.score == 2)
            {
                Console.WriteLine(player2.name + "you won!");
            }
        }




        public string ChooseNumberPlayers()
        {
            Console.WriteLine("How Many Players are Playing?");
            string NumberPlayers = Console.ReadLine();
            return NumberPlayers;
        }


        public void CreatePlayers(string NumberOfPlayers)
        {
            if (NumberOfPlayers == "1")
            {
                player1 = new Humanplayer();
                player2 = new CPUPlayer();

            }
            else if (NumberOfPlayers == "2")
            {
                player1 = new Humanplayer();
                player2 = new Humanplayer();
            }

        }


        public void GestureRoundWin()
        {
            if (player1.choice == player2.choice)
            {
                Console.WriteLine("You tied!");
                Console.ReadLine();
            }


            else if (player1.choice == "rock" && player2.choice == "scissors" || player2.choice == "lizard")
                {
                player1.score++;
                Console.WriteLine(player1.name + "wins the round!" + " " + "Player 1's score is" + " " + player1.score);
                Console.ReadLine();
                }
            
            else if (player1.choice == "paper" && player2.choice == "rock" || player2.choice == "spock")
            {
                player1.score++;
                Console.WriteLine(player1.name + "wins the round!" + " " + "Player 1's score is" + " " + player1.score);
                Console.ReadLine();
            }

            else if (player1.choice == "scissors" && player2.choice == "paper" || player2.choice =="lizard")
            {
                player1.score++;
                Console.WriteLine(player1.name + "wins the round!" + " " + "Player 1's score is" + " " + player1.score);
                Console.ReadLine();
            }
            else if (player1.choice == "lizard" && player2.choice == "spock" || player2.choice == "spock")
            {
                player1.score++;
                Console.WriteLine(player1.name + "wins the round!" + " " + "Player 1's score is" + " " + player1.score);
                Console.ReadLine();
            }
            else if (player1.choice == "spock" && player2.choice == "scissors" || player2.choice == "rock")
            {
                player1.score++;
                Console.WriteLine(player1.name + "wins the round!" + " " + "Player 1's score is" + " " + player1.score);
                Console.ReadLine();
            }
            
            else 
            { 
                player2.score++;
                Console.WriteLine(player2.name + "wins the round!" + " " + "Player 1's score is" + player2.score);
                Console.ReadLine();
            }
            Console.WriteLine(player1.name + player1.score + player2.name + player2.score);
                    




        }            



            


    }







    
}

