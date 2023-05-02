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
            Console.WriteLine("Welcome to MaxH's Card Application! \r\n ");
            while (true)
            {
                Console.WriteLine("Choose functionality \r\n " +
                                        "1. Instructions \r\n " +
                                        "2. Deal 3 Cards \r\n " +
                                        "3. Deal 5 Cards \r\n " +
                                        "4. Quit");

                int menu = Convert.ToInt32(Console.ReadLine());
                //Created a switch statement to allow the user to choose what they want to do

                Game game = new Game();
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Write instructions here \r\n ");
                        break;
                    case 2:
                        ThreeCard threeCard = new ThreeCard();
                        threeCard.Play();
                        break;
                    case 3:
                        FiveCard fiveCard = new FiveCard();
                        fiveCard.Play();
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                }
            }
        }
       
    }
}
