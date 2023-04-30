using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
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
            string strOperator = oper(hand[1].Suit);
            int secondNumber = hand[2].CardValue;
            int answer = Math(firstNumber, strOperator, secondNumber);


            Console.WriteLine(firstNumber + strOperator + secondNumber);
            Console.WriteLine("Your answer: ");
            int userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput == answer) { Console.WriteLine("You are correct!"); }
            else { Console.WriteLine("You are incorrect!, the answer was " + answer); }
            dealAgain();

        }
        public void fiveCard()
        {
            List<Card> hand = new List<Card>();
            hand = pack.dealCard(5);


            int firstNumber = hand[0].CardValue;
            string firstOperator = oper(hand[1].Suit);
  
            int secondNumber = hand[2].CardValue;

            string secondOperator = oper(hand[3].Suit);
            int thirdNumber = hand[4].CardValue;
            
            int firstThree = Math(firstNumber, firstOperator, secondNumber);
            int answer = Math(firstThree, secondOperator, thirdNumber);

            Console.WriteLine(firstNumber + firstOperator + secondNumber + secondOperator + thirdNumber);
            Console.WriteLine("Your answer: ");
            int userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput == answer) { Console.WriteLine("You are correct!"); }
            else { Console.WriteLine("You are incorrect!, the answer was " + answer); }
            dealAgain();
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

        private void dealAgain()
        {
            Console.WriteLine("Choose functionality \r\n " +
                                    "1. Deal 3 \r\n " +
                                    "2. Deal 5 \r\n " +
                                    "3. Back to the menu");
            int userinput = Convert.ToInt32(Console.ReadLine());
            switch (userinput)
            {
                case 1:
                   threeCard();
                    break;
                case 2:
                    fiveCard();
                    break;
                case 3:
                    break;
            }
        }
    }
}
