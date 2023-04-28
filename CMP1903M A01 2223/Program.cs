using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// MaxH's program.
namespace CMP1903M_A01_2223
{
    class Program
    {
        void Main(string[] args)
        {
            //Created a pack object
            Console.WriteLine("Welcome to MaxH's Card Application! \r\n ");
            Console.WriteLine("Choose functionality \r\n " +
                                    "1. Instructions \r\n " +
                                    "2. Deal 3 Cards \r\n " +
                                    "3. Quit");
            
            int menu = Convert.ToInt32(Console.ReadLine());
            //Created a switch statement to allow the user to choose what they want to do

            switch (menu)
                {
                    case 1:
                        Console.WriteLine("Write instructions here \r\n ");
                        break;
                    case 2:
                        Game();
                        break;
                    case 3:
                        Console.WriteLine("Goodbye! \r\n ");
                        System.Environment.Exit(0);
                        break;

                }
            Console.ReadKey();
        }
        private void Game() 
        {
            //Create cards and hand
            //If i recall this its going to make another pack! i need to solve this. - create a pack at start.
            List<Card> hand = new List<Card>();
            Pack pack = new Pack();
            pack.shuffleCardPack();
            hand = pack.dealCard(3);

            //Choose a operator
            int firstNumber = hand[0].CardValue;
            int oper = hand[1].Suit;
            int secondNumber = hand[2].CardValue;
            int[] ans = pack.Math(firstNumber, oper, secondNumber);

            //still have the problem with need string of operator chosen to display!
            // object array return ans + string op?
            // return string array and change ans back to int?
            Console.WriteLine(firstNumber + oper + secondNumber);
            Console.WriteLine("Your answer: ");
            int ans = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hand[1].CardValue + char.Parse(op) + hand[2].CardValue);
            if (ans == hand[1].CardValue hand[2].CardValue)
                        {
                Console.WriteLine("Answer was correct");
            }


        }
    }
}
