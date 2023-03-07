using System;
using System.Diagnostics.Eventing.Reader;

namespace CMP1903M_A01_2223
{
	public class Test
	{
		public Test()
		{
			
        }
		public bool testShuffles()
		{
            Pack testObject = new Pack();
            for (int i = 1; i <= 3; i++)
			{
                //Im not sure why this doesnt work?
                Console.WriteLine(i);
                if (testObject.shuffleCardPack(i) == false)
				{
                    Console.WriteLine("shufflecard returned false");
                    return false;
				}
				
            }
            return false;
        }
    }
}
