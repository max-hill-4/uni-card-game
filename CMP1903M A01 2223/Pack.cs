using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;
        public Pack()

        {

            //string[] suits = { "Hearts", "Spades", "Clubs", "Diamonds"};
            pack = new List<Card>();
            for (int i = 0; i < 52; i++)
            {
                Card newCard = new Card();
                newCard.CardValue = i % 13;
                newCard.Suit = (i / 13);
                pack.Add(newCard);
                Console.WriteLine(newCard.CardValue);


            }
        }

        
        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)
            {
                Random rand = new Random();
                
                for (int i = 52; i >= 0; i--)
                {
                    int randomNumber = rand.Next(0, i);
                    (pack[i], pack[randomNumber]) = (pack[randomNumber], pack[i]);
                }
                return true;
            }
            if (typeOfShuffle == 2)
            {
                return true;
            }
            if (typeOfShuffle == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
        */
    }
}
