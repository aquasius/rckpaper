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


        //constructor




        //member methods (Can Do)
        public override void ChooseGesture()
        {
            choices = choices[RandomNumber];
        }






    }
}
