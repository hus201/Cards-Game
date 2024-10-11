using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Game
{
    //Class Will be Saving A Card Values And Determine if its Used At Any Card Or Not
    class CardValues
    {
        public int v;
        public bool isUsed ;
        public CardValues(int value) {
            v = value;
            isUsed = false;
        }
    }
}
