using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public abstract class AbstractPlayer
    {
        // member (Has A)
        public int score;
        public string choices;
        List<string> gestures;
       
          
        
        // construct 
        public AbstractPlayer()
        {
            gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            score = 0;
        }
        
        
        // method(can do)
           public virtual void ChooseGesture()
        {
            Console.WriteLine("Choose your gesture");
            Console.ReadLine();
        }
    
    
    }
}
