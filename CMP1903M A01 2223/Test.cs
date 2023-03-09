using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace CMP1903M_A01_2223
{
	public class Test
	{

        public bool testShuffles()
        {

            try
            {
                Pack testObject = new Pack();
                for (int i = 1; i <= 3; i++)
                {
                    //Iterates through all shuffle methods and checks if return true
                    if (testObject.shuffleCardPack(i) == false)
                    {
                        return false;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return true;
        }
        public bool testDeals()
        {
            Pack testObject = new Pack();
            //Using try and catch loops which will error if function is stopped
            try
            {
                Card data = testObject.deal();
                List<Card> listData = testObject.dealCard(5);
                return true;
            }
                
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());

            }
            return false;


        }

    }
}
