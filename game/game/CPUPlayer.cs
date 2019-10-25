using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class CPUPlayer : AbstractPlayer
    {
        //member variables ( HAS A )
       
         private Random rand;
        public int gesturesCount;
       
        //constructor
        public CPUPlayer()
        {
            rand = new Random();
            gesturesCount = gestures.Count;
        }

    



        //member methods (Can Do)
        public override void ChooseGesture()
        {
            int CpuChoice = rand.Next(gesturesCount);
            choice = gestures[CpuChoice];
            Console.WriteLine(choice);


        }

        public override void ChooseName()
        {
            Console.WriteLine("My Name is Wally");
            Console.ReadLine();
        }

        


        
         
        


    }
}
