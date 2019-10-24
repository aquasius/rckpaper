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
       public AbstractPlayer player1;
       public AbstractPlayer player2;
       


        // constructor 




        // member methods (CAN DO) 
        public void RunGame()
        {
            DisplayRules();

            string NumberPlayers = ChooseNumberPlayers();
            
            CreatePlayers(NumberPlayers);
            player1.ChooseGesture();
            player2.ChooseGesture();

          

            while (player1.score < 2 && player2.score < 2)
            {
                player1.ChooseGesture();

            }




        }
        public void DisplayRules()
        {
            Console.WriteLine("Choose either 'Rock','Paper','Scissors','Lizard', or 'Spock'  to defeat your opponent!");
            Console.ReadLine();
        }
        

        private void DetermineRoundWinner()
        { 
            //if () { }
        
        
        
        
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

    }
}
