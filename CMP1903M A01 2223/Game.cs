using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Game
    {
        Pack pack = new Pack();
        public Game()
        {
            pack.shuffleCardPack();
        }

        public void threeCard()
        {
            List<Card> hand = new List<Card>();
            hand = pack.dealCard(3);

            //generate new hand with same pack, according with 
            // go back to the menu is problem ! and play 

            // from menu i choose this yes 
            // but i wanna be playing on the same pack!!
            // so need to instantiate game!

            int firstNumber = hand[0].CardValue;
            int intOperator = hand[1].Suit;
            int secondNumber = hand[2].CardValue;
            string strOperator = oper(intOperator);
            int answer = Math(firstNumber, strOperator, secondNumber);


            Console.WriteLine(firstNumber + strOperator + secondNumber);
            Console.WriteLine("Your answer: ");
            int userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput == answer) { Console.WriteLine("You are correct!"); }

        }
        public void fiveCard()
        {
            
        }
        private static string oper(int suitValue)
        {
            if (suitValue == 1) { return "+"; }
            if (suitValue == 2) { return "-"; }
            if (suitValue == 3) { return "*"; }
            if (suitValue == 4) { return "/"; }
            return "";
        }
        private static int Math(int firstNumber, string oper, int secondNumber)
        {
            if (oper == "+") { return firstNumber + secondNumber; }
            if (oper == "-") { return firstNumber - secondNumber; }
            if (oper == "*") { return firstNumber * secondNumber; }
            if (oper == "/") { return firstNumber / secondNumber; }
            return 0;
        }

    }
}
