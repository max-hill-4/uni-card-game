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
                    if (testObject.shuffleCardPack() == false)
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


    }
}
