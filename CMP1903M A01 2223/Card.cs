using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        private int cardvalue;
        private int suit;
        public int CardValue 
        {
            // TD: Variable names.
            get { return cardvalue; }
            set { cardvalue = value; }
        }
        public int Suit
        {
            get { return suit; }
            set { suit = value; }
        }
    }
}
