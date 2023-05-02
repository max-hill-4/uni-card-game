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
        private int cardvalue;
        private int suit;
        public int CardValue 
        {
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
