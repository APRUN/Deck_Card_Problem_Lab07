using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Card_Problem_Lab07
{
    class bjh:Hand
    {
            bool isace;
        public bjh(bool a)
        {
            isace = a;
        }
        public int getbjhvalue()
        {
            int cardcount;
            int cardvalue;
            cardcount = getCardcount();
            cardvalue = gethandcardsvalue();
            return cardvalue;
            
        }
    }
}
