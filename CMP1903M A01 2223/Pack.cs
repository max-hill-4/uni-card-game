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

        
        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)
            {
                Random rand = new Random();
                
                for (int i = 51; i >= 0; i--)
                {
                    //Swap card with a random card before it
                    int randomNumber = rand.Next(0, i);
                    (pack[i], pack[randomNumber]) = (pack[randomNumber], pack[i]);
                }
                return true;
                
            }
            if (typeOfShuffle == 2)
            {
                int halfDeckSize = pack.Count / 2;
                Random rand = new Random();
                List<Card> firstHalf = pack.GetRange(0, halfDeckSize);
                List<Card> secondHalf = pack.GetRange(0, halfDeckSize);
                List<Card> newPack = new List<Card>();

                while(firstHalf.Count > 0 && secondHalf.Count > 0)
                {
                    // Pick 1  of the halves and put into the new deck
                    if (rand.NextDouble() >= 0.5)
                    //Depending on half 
                    {
                        newPack.Add(firstHalf[firstHalf.Count - 1]);
                        firstHalf.RemoveAt(firstHalf.Count - 1);
                    }

                    else
                    {
                        newPack.Add(secondHalf[secondHalf.Count - 1]);
                        secondHalf.RemoveAt(secondHalf.Count - 1);
                    }
                }
                // Put remaining cards into the pack
                newPack.AddRange(firstHalf);
                newPack.AddRange(secondHalf);
                pack = newPack;
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

        public Card deal()
        {
            //Deals one card
            Card topCard = pack[pack.Count - 1];
            pack.RemoveAt(pack.Count -1);
            return topCard;

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
