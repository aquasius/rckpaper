using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class CPUPlayer: AbstractPlayer
    {
        //member variables ( HAS A )
        public string score;
        private Random rand;
        public int gesturesCount;
        public List<string> gestures;
        //constructor




        //member methods (Can Do)
        public override void ChooseGesture()
        {
            rand = new Random();
            gesturesCount = gestures.Count; 
        }

        public override void ChooseName()
        {
            Console.WriteLine("Ch");
        }





    }
}
