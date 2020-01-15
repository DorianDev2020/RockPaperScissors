using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public Human()
        {
            ChooseName();
        }
        public override void ChooseName()
        {
            Console.WriteLine("Hey There!");
            Console.WriteLine("What's Your Name");
            playerName = Console.ReadLine();
        }

        public override void ChooseGesture()
        {

            bool isTrue = false;
            while (isTrue == false)
            {
                Console.WriteLine("Choose Your Gesture");
                Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock");
                gesture = Console.ReadLine();
                if (gestures.Contains(gesture))
                {
                    isTrue = true;
                }
                else
                {
                    Console.WriteLine("Please Choose A Valid Gesture");
                }

            }

        } 

        

    } 
}
