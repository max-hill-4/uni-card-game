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
        protected Pack pack;
        public Game()
        {
            pack = new Pack();
            pack.shuffleCardPack();
        }
        protected static string oper(int suitValue)
        {
            if (suitValue == 1) { return "+"; }
            if (suitValue == 2) { return "-"; }
            if (suitValue == 3) { return "*"; }
            if (suitValue == 4) { return "/"; }
            return "";
        }
        protected static int Math(int firstNumber, string oper, int secondNumber)
        {
            if (oper == "+") { return firstNumber + secondNumber; }
            if (oper == "-") { return firstNumber - secondNumber; }
            if (oper == "*") { return firstNumber * secondNumber; }
            if (oper == "/") { return firstNumber / secondNumber; }
            return 0;
        }
        protected void dealAgain(int answer)
        {
            Console.WriteLine("Your answer: ");
            try {
                int userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput == answer)
                {
                    Console.WriteLine("You are correct!");
                }
                else { Console.WriteLine("You are incorrect!, the answer was " + answer);}
            }
            catch
            {
                Console.WriteLine("Invalid input enter a number!, the answer was " + answer);
            }
            

            

        }
    }
    class FiveCard : Game
        {
            public void Play()
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
                dealAgain(answer);
            }
        }
    class ThreeCard : Game
        {
            public void Play()
            {
                List<Card> hand = new List<Card>();
                hand = pack.dealCard(3);

                int firstNumber = hand[0].CardValue;
                string strOperator = oper(hand[1].Suit);
                int secondNumber = hand[2].CardValue;
                int answer = Math(firstNumber, strOperator, secondNumber);


                Console.WriteLine(firstNumber + strOperator + secondNumber);
                dealAgain(answer);
            }
        }
    
}

