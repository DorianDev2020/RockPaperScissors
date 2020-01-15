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
        public int score;
        public string gesture;
        public List<string> gestures;
        public Player()
        {
            //I like the .Add list way just so its super transparent
            gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }
        public abstract void ChooseName();

        public abstract void ChooseGesture();
       
    }

    
    
    
}
