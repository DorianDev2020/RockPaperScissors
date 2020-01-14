using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public string playerName;
        public int randomint;
        public string gesture;
        public List<string> gestures;
        public Player()
        {
            //I like the .Add list way just so its super transparent
            playerName = null;
            randomint = 0;
            gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }

        public abstract void ChooseName();

        public virtual void ChooseGesture()
        {
            Console.WriteLine("Choose Your Gesture");
            gesture = Console.ReadLine();
        }

    }

    
    
    
}
