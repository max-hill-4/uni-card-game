using System;
using System.Collections;
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
            //Create a new dynamic list to hold pack
            pack = new List<Card>();
            //Create 52 cards
            for (int i = 0; i <= 52; i++)

            {
                Card newCard = new Card();
                //Integer value of 1-13
                newCard.CardValue = (i % 13) + 1;
                //Ineger value of 1-4
                newCard.Suit = (i / 13) + 1;
                //Add the card to the list
                pack.Add(newCard);

            }
        }


        public void shuffleCardPack()
        {
            Random rand = new Random();

            for (int i = 51; i >= 0; i--)
            {
                //Swap card with a random card before it
                int randomNumber = rand.Next(0, i);
                (pack[i], pack[randomNumber]) = (pack[randomNumber], pack[i]);
            }

        }

        public List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> topCards = pack.GetRange(pack.Count - amount, amount);
            pack.RemoveRange(pack.Count - amount, amount);
            return topCards;
        }

        
    }
}
