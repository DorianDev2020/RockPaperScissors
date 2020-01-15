using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
     public class Game : Player
     {
        Player Player1;
        Player Player2;

        // member methods
        public string Setnumberofplayers() // master method
        {
            Console.Write("How Many Players");
            string NumberofPlayers = Console.ReadLine();
            return NumberofPlayers;

        }

        public void Rounds()
        {
            Player1.ChooseGesture();
            Player2.ChooseGesture();
            GestureComparrison();


        }

        public void SetPlayers (string NumberofPlayers)
        {
            if(NumberofPlayers == "1")
            {
                Player1 = new Human();
                Player2 = new Computer();
            }
            else if(NumberofPlayers =="2")
            {

                Player1 = new Human();
                Player2 = new Computer();
            }

        }

        public void GestureComparrison()
        {
            if 
            

        }
     }
}
