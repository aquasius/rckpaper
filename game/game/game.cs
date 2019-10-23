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
       public Humanplayer player1;
       public Humanplayer player2;
       public CPUPlayer CPUPlayer;


        // constructor 




        // member methods (CAN DO) 
        public void RunGame()
        {
            DisplayRules();

            while(player1.score < 2 && player2.score < 2 || player1.score < 2 && CPUPlayer.score < 2)
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

    
    }
}
