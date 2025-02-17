using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Hunting_the_Manticore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Player 1, how far away from the city do you want to station the Manticore?: ");
            int Player1Distance = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++) { Console.WriteLine(""); }

            GameRunner Game = new GameRunner(Player1Distance);
            for (int Round = 1; Round < 15; Round++)
            {
                if (Game.GameConinute()) { Game.InformationPrint(Round); }
                else Console.WriteLine("GAME OVER");
            }
        }

        public class GameRunner(int PlayerDistance)
        {
            //class variables
            int CityHealth = 15;
            int ManticoreHealth = 10;
            int Player1Distance = PlayerDistance;




            public void InformationPrint(int Round)
            {
                CityHealth -= 1;
                Console.Write("-------------------------------------------------------\n");
                Console.WriteLine($"STATUS:  Round {Round}  City:{CityHealth}/15  Manticore:{ManticoreHealth}/10 \n The cannon is expected to do {DammageValue(Round)} ");
                Console.Write("Enter desired cannon range: ");
                int Player2Guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"That  round {TargetDistance(Player2Guess, Player1Distance, Round)} the target");
                Console.Write("-------------------------------------------------------\n\n\n");
            }

            private string TargetDistance(int Guess, int Distance, int Round)
            {
                if (Guess > Distance) { return "Overshot"; }
                else if (Guess < Distance) { return "Fell Short of"; }
                else 
                {
                    ManticoreHealth -= DammageValue(Round);
                    return "Hit";
                }
            }

            private int DammageValue(int Round)
            {
                int RoundValue = Round;
                if (RoundValue%3==0 && RoundValue % 5 == 0) { return 10; }
                else if (RoundValue%3==0) { return 3; }
                else if (RoundValue%5 == 0) { return 3; }
                else { return 1; };
            }

            public Boolean GameConinute()
            {
                if (CityHealth>0 && ManticoreHealth>0) { return true; }
                else return false;

            }
        }
    }
}
