using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Game
{
    //Class Will Save A position Point And Then Determine if there is A Card Saved In It or Not
    class Positions
    {
       public int x;
       public int y;
       public Card C;
        public Positions(int x, int y) { 
            this.x = x;
            this.y = y;
            this.C = null;
        }
    }
}
