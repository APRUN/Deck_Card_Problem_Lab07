using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Card_Problem_Lab07
{
    class Deck
    {
        Card[] deck = new Card[52];
         protected int count = 0;
        public Deck()
        {
            for(int f=0;f<4;f++)
            {
            for(int i=0;i<52;i++)
            {
                deck[count] = new Card(f, i);
                    count++;
            }
            }
        }
        public void shuffle()
        {
            Random rnd = new Random();
            Card temp;
            for(int n=0;n<52;n++)
            {
                int num = rnd.Next(0,52);
                temp = deck[num];
                deck[num] = deck[n];
                deck[n] = temp;
            }
               count=52;
        }
        public Card dealcard()
        {
            if(count>0)
            {
                count--;
                return deck[count];
            }
            else
            {
                return null;
            }
        }
        public int cardleft()
        {
            return count;
        }
    }
}
