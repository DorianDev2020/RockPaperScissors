using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
     public class Game
     {
        Player Player1;
        Player Player2;
      
        public void Intro() 
        {

            Console.WriteLine("Welcome To RPSLS!");
            Console.WriteLine("Rock Paper Scissors Lizard Spock! Thats Right We Added A Little Spin To The Classic (You're Welcome)");
            Console.WriteLine("Ok! So Here's How It Works!");
            Console.WriteLine("Rock Beats Scissors");
            Console.WriteLine("Paper Beats Rock");
            Console.WriteLine("Scissors Beats Paper");
            Console.WriteLine("Now Heres Where It Gets Interesting.");
            Console.WriteLine("Rock Crushes Lizard");
            Console.WriteLine("Lizard Poisons Spock");
            Console.WriteLine("Spock Vaporizes Rock");
            Console.WriteLine("Spock Smashes Scissors");
            Console.WriteLine("Scissors Decapitates Lizard");
            Console.WriteLine("Lizard Eats Paper");
            Console.WriteLine("Paper Diproves Spock");
        }

        public void RunGame()
        {
            Intro();
            string numberofPlayers = SetnumberofPlayers();
            ChoosePlayers(numberofPlayers);
            while (Player1.score < 2 && Player2.score < 2)
            {
                Rounds();
            }
            if (Player1.score == 2)
            {
                Console.WriteLine(Player1.playerName + " Wins!");
                Console.ReadLine();
            }
            if (Player2.score == 2)
            {
                Console.WriteLine(Player2.playerName + "Wins!");
                Console.ReadLine();
            }

      

        }



        // member methods
        public string SetnumberofPlayers() 
        {
            Console.Write(" How Many Are Playing");
            string NumberofPlayers = Console.ReadLine();
            return NumberofPlayers;

        }

        public void ChoosePlayers(string Setnumberofplayers)
        {

            
            bool isvalid = false;
            while (isvalid == false)
            {
                if (Setnumberofplayers == "1")
                {
                    Player1 = new Human();
                    Player2 = new Computer();
                    isvalid = true;
                }
                else if (Setnumberofplayers == "2")
                {

                    Player1 = new Human();
                    Player2 = new Computer();
                    isvalid = true;
                }
                else
                {
                    Console.WriteLine("Please Choose A Valid Entry To Continue");
                    Setnumberofplayers = SetnumberofPlayers();
                }
            }
           
        }

        public void Rounds()
        {
            Player1.ChooseGesture();
            Player2.ChooseGesture();
            GestureComparrison();

        }

        public void GestureComparrison()
        {
            if (Player1.gesture == Player2.gesture)
            {
                Console.WriteLine("Draw");
            }
            else if (Player1.gesture == "Rock" && Player2.gesture == "Scissors")
            {
                Console.WriteLine("Rock Beats Scissors" + Player1 + " Wins!");
                Player1.score++;
            }
            else if (Player1.gesture == "Paper" && Player2.gesture == "Rock")
            {
                Console.WriteLine("Paper Beats Rock" + Player1 + " Wins!");
                Player1.score++;
            }
            else if (Player1.gesture == "Scissors" && Player2.gesture == "Paper")
            {
                Console.WriteLine("Scissors beats Paper!" + Player1 + " Wins!");
                Player1.score++;
            }
            else if (Player1.gesture == "Lizard" && Player2.gesture == "Spock")
            {
                Console.WriteLine("Lizard Poisons Spock" + Player1 + " Wins!");
                Player1.score++;
            }
            else if (Player1.gesture == "Spock" && Player2.gesture == "Rock")
            {
                Console.WriteLine("Spock Vaporizes Rock" + Player1 + " Wins");
                Player1.score++;
            }
            else if (Player1.gesture == "Scissors" && Player2.gesture == "Lizard")
            {
                Console.WriteLine("Scissors Decapitates Lizard" + Player1 + " Wins!");
                Player1.score++;
            }
            else if (Player1.gesture == "Paper" && Player2.gesture == "Spock")
            {
                Console.WriteLine("Paper Disproves Spock" + Player1 + " Wins!");
                Player1.score++;
            }
            else if (Player1.gesture == "Lizard" && Player2.gesture == "Paper")
            {
                Console.WriteLine("Lizard Eats Paper" + Player1 + " Wins!");
                Player1.score++;
            }
            else if (Player1.gesture == "Spock" && Player2.gesture == "Scissors")
            {
                Console.WriteLine("Spock Smashes Scissors" + Player1 + " Wins!");
                Player1.score++;
            }
            else
            {
                Console.WriteLine("Please make a Selection From the List");

            }

        }


    }

}
