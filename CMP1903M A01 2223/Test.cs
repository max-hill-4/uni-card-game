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
                // Checks if pack is the same as a normal pack, or its been shuffled.
                Pack testObject = new Pack();
                Pack defualtObject = new Pack();
                testObject.shuffleCardPack();
                if (testObject == defualtObject)
                {
                    return false;
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
            List<Card> listData = testObject.dealCard(5);
            return true;
        }

        catch (Exception e)
        {
            Console.WriteLine(e.ToString());

        }
        return false;

        }

    }
}