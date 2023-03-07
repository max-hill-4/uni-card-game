using System;
using System.Diagnostics.Eventing.Reader;

namespace CMP1903M_A01_2223
{
	public class Test
	{

        public bool testShuffles()
        {
            Pack testObject = new Pack();
            for (int i = 1; i <= 3; i++)
            {
                //Iterates through all shuffle methods and checks if return tr
                if (testObject.shuffleCardPack(i) == false)
                {
                    return false;
                }

            }
            return false;
        }
        public bool testDeals()
        {
            Pack testObject = new Pack();
            testObject.deal





        }

    }
}
