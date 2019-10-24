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
        public string name;
        
        
        // construct 
        public AbstractPlayer()
        {
           List< gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            score = 0;
        }


        // method(can do)
        public abstract void ChooseGesture();
        
            
        

           public virtual void ChooseName()
        {
            Console.WriteLine("Choose Name");
            name = Console.ReadLine();
        }


    }
}
