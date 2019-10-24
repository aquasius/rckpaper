using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {

            // display rules x
            // create players x
            // create gesture scenarios x
            // win condition 

            game gameStart = new game();
            gameStart.DisplayRules();
            string NumberOfPlayers = gameStart.ChooseNumberPlayers();
            gameStart.CreatePlayers(NumberOfPlayers);
            
            CPUPlayer nameBot = new CPUPlayer();
            nameBot.ChooseName();

            Humanplayer gameGestures = new Humanplayer();
            gameGestures.ChooseGesture();
            
            
            nameBot.ChooseGesture();
            
        
        
        
        
        }
    }
}
