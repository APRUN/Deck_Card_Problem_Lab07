using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Card_Problem_Lab07
{
    class Hand
    {
        protected List<Card> cardsinhand = new List<Card>();
       
        int cardcount;
        public Hand()
        {

        }
        public void clear()
        {
            cardsinhand.Clear();
        }
        public void addcard(Card c)
        {
            cardsinhand.Add(c);
            cardcount++;
        }
        public void removecard(Card c)
        {
            int var = search_cardindex(c);
            cardsinhand.RemoveAt(var);
            cardcount--;
        }
        public int search_cardindex(Card c)
        {
            for(int i=0;i<52;i++)
            {
                if(cardsinhand[i]==c)
                {
                    return i;
                }
            }
            return 0;
        }
        public void removecard(int position)
        {
            cardcount--;
        }
        public int getCardcount()
        {
            return cardcount;   
        }
        public void getcard(int position)
        {
            Console.WriteLine(cardsinhand[position+1]);
        }
        public void sortbysuit()
        {
            cardsinhand.Sort();
        }
        public void sortbyvalue()
        {

        }
        public int gethandcardsvalue()
        {
            int values=0;
            foreach(Card card in cardsinhand)
            {
                values=card.getvalue()+values;
            }
            return values;
        }
    }
}
