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
       public string numberPlayers;


        // constructor 




        // member methods (CAN DO) 
        public void RunGame()
        {
            DisplayRules();

            CreatePlayers(numberPlayers);
            player1.ChooseGesture();
            player2.ChooseGesture();


            while (player1.score < 2 && player2.score < 2 || player1.score < 2 && CPUPlayer.score < 2)
            {
                string player1Choice = player1.ChooseGesture();

                




            }




        }
        private void DisplayRules()
        {
            Console.WriteLine("Choose either 'Rock','Paper','Scissors','Lizard', or 'Spock'  to defeat your opponent!");
        }
        

        private void DetermineRoundWinner()
        { 
            if ()
        
        
        
        
        }
        public string ChooseNumberPlayers()
        {
            Console.WriteLine("How Many Players are Playing?");
            string NumberOfPlayers = Console.ReadLine();
            return NumberOfPlayers;
        }


        public void CreatePlayers(string NumberPlayers)
        {
            if (NumberPlayers == "1")
            {
                player1 = new Humanplayer();
                player2 = new CPUPlayer();

            }
            else if (NumberPlayers == "2")
            {
                player1 = new Humanplayer();
                player2 = new Humanplayer();
            }
                
        }

    }
}
