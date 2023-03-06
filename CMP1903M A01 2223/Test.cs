using System;
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
            for (int i = 0; i < 3; i++)
			{
				//Im not sure why this doesnt work?
				if (testObject.shuffleCardPack(i) == false);
				{
					return false;
				}
                Console.WriteLine("iteration");
            }
			
			return true;
		}
    }
}
