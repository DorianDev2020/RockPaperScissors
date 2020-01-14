using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        public int score;

        public Computer()
        {
            score = 0;
            ChooseName();
        }

        public override void ChooseName()
        {
            //Console.WriteLine("Hello My Name Is Sheldon");
            //Console.WriteLine("Shall We Begin?");
            playerName = "Matty B Smokes";
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Choose Your Gesture");

            //How To Generate A Random Number
            Random rnd = new Random();
            // consider bounds for random number with respect to list
            int randomnumber = rnd.Next(1,6);
            gesture = gestures[randomnumber];

        }



    }
}
    

