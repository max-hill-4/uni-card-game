using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// MaxH's program.
namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created a pack object
            Test Obj1 = new Test();
            //Tests shuffle methods
            if (!Obj1.testShuffles() ^ !Obj1.testDeals())
            {
                Console.WriteLine("Testing has failed");
            };
            
            //Testing dealing methods
            
        }
    }
}
