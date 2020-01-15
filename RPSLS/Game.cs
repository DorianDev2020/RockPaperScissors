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
        bool isvalid = false;


        public void RunGame()
        {
            // member methods
             string Setnumberofplayers() // master method
            {
                Console.Write("How Many Players");
                string NumberofPlayers = Console.ReadLine();
                return NumberofPlayers;

            }

             void Rounds()
            {
                Player1.ChooseGesture();
                Player2.ChooseGesture();
                GestureComparrison();


            }

             void SetPlayers(string NumberofPlayers)
            {
                bool isvalid = false;
                while (isvalid == false)

                    if (NumberofPlayers == "1")
                    {
                        Player1 = new Human();
                        Player2 = new Computer();
                        isvalid = true;
                    }
                    else if (NumberofPlayers == "2")
                    {

                        Player1 = new Human();
                        Player2 = new Computer();
                        isvalid = true;
                    }
                    else
                    {
                        Console.WriteLine("Please Choose A Valid Entry To Continue");

                    }

            }
             void Round()
            {



            }

             void GestureComparrison()
            {
                if (Player1.gesture == Player2.gesture)
                {
                    Console.WriteLine("Draw");
                }
                else if (Player1.gesture == "Rock" && Player2.gesture == "Scissors")
                {
                    Console.WriteLine("Rock Beats Scissors" + Player1 + "Wins!");
                }
                else if (Player1.gesture == "Paper" && Player2.gesture == "Rock")
                {
                    Console.WriteLine("Paper Beats Rock" + Player1 + "Wins!");
                }
                else if (Player1.gesture == "Scissors" && Player2.gesture == "Paper")
                {
                    Console.WriteLine("Scissors beats Paper!" + Player1 + "Wins!");
                }
                else if (Player1.gesture == "Lizard" && Player2.gesture == "Spock")
                {
                    Console.WriteLine("Lizard Poisons Spock" + Player1 + "Wins!");
                }
                else if (Player1.gesture == "Spock" && Player2.gesture == "Rock")
                {
                    Console.WriteLine("Spock Vaporizes Rock" + Player1 + "Wins");
                }
                else if (Player1.gesture == "Scissors" && Player2.gesture == "Lizard")
                {
                    Console.WriteLine("Scissors Decapitates Lizard" + Player1 + "Wins!");
                }
                else if (Player1.gesture == "Paper" && Player2.gesture == "Spock")
                {
                    Console.WriteLine("Paper Disproves Spock" + Player1 + "Wins!");
                }
                else if (Player1.gesture == "Lizard" && Player2.gesture == "Paper")
                {
                    Console.WriteLine("Lizard Eats Paper" + Player1 + "Wins!");
                }
                else if (Player1.gesture == "Spock" && Player2.gesture == "Scissors")
                {
                    Console.WriteLine("Spock Smashes Scissors" + Player1 + "Wins!");
                }
                else
                {
                    Console.WriteLine("Please make a Selection From the List");
                }
            }
        


        

        

       
        }
     }

}
