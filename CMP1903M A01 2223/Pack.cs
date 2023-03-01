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
            //Initialise the card pack here
            Card[] cards = new Card[52];
            string[] suits = { "Hearts", "Spades", "Clubs", "Diamonds"};

            for (int i = 0; i < 52; i++)
            {
                cards[i] = new Card();
                cards[i].CardValue = i;
                Console.WriteLine(cards[i].CardValue);
                
            }
        }
        /*
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle

        }
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
