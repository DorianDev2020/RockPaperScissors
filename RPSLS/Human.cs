using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public int score;


        public Human()
        {

        }

        public override void ChooseName()
        {
            
            Console.WriteLine("Hey There!");
            Console.WriteLine("What's Your Name");
            playerName = Console.ReadLine();
        }

        //public override void ChooseGesture()
        //{
        //    base.ChooseGesture();
        //    Console.ReadLine();
        //}


    }


   
}
