using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Card_Problem_Lab07
{
    class Card
    {
        public int value;
        public int suit;
        public Card(int value,int suit)
        {
            this.value = value;
            this.suit = suit;
        }
        public String getsuitasstring()
        {
            if(suit==1)
            {
                return "Clubs";
            }
            if(suit==2)
            {
                return "Diamonds";
            }
            if(suit==3)
            {
                return "Hearts";
            }
            if(suit==4)
            {
                return "Spades";
            }
            return null;
        }
        public string getvalueasstring()
        {
            if (value == 1)
            {
                return "Ace";
            }
            if(value<11&&value>1)
            {
                return value.ToString();
            }
            if(value==11)
            {
                return "Jack";
            }
            if(value==12)
            {
                return "Queen";
            }
            if(value==13)
            {
                return "King";
            }
            return null;
        }
        public string stringtostring()
        {
            Console.WriteLine(getsuitasstring()+" of "+getvalueasstring());
            return null;
        }
        public int getvalue()
        {
            return value;
        }
        public int getsuit()
        {
            return suit;
        }
    }
}
