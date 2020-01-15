using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        public override void ChooseName()
        {
            
            playerName = "Sheldon";
        }

        public override void ChooseGesture()
        {
            Console.Write("Choose Your Gesture");
            //How To Generate A Random Number
            Random rnd = new Random();
            // consider bounds for random number with respect to list
            int randomnumber = rnd.Next(1,6);
            gesture = gestures[randomnumber];

        }



    }
}
    

