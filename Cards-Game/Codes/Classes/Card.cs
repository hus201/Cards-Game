using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Cards_Game
{
    // Custom Made Class Inherited PictureBox Class to Make Cards Fast And Save Its Custom Proprites
    class Card : PictureBox
    {
        // Parameters
        public Image GameCard;
        private Image Background = Cards_Game.Properties.Resources.Back;
        private int CardValue;
        //Constracter
        public Card()
        {
            Image = Background;
            Cursor = Cursors.Hand;
            Width = 100;
            Height = 150;
            SizeMode = PictureBoxSizeMode.StretchImage;

        }
        //OnPaint
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

        }
        //Getter
        public int getValue() => CardValue;
        //Setters
        public void setLocation(int x, int y)
        {
            Location = new Point(x, y);
        }
        public void setCardValue(int value)
        {
            CardValue = value;
            setImages();
        }
        private void setImages()
        {
            switch (CardValue)
            {
                case 1: GameCard = Cards_Game.Properties.Resources._1; break;
                case 2: GameCard = Cards_Game.Properties.Resources._2; break;
                case 3: GameCard = Cards_Game.Properties.Resources._3; break;
                case 4: GameCard = Cards_Game.Properties.Resources._4; break;
                case 5: GameCard = Cards_Game.Properties.Resources._5; break;
                case 6: GameCard = Cards_Game.Properties.Resources._6; break;
                case 7: GameCard = Cards_Game.Properties.Resources._7; break;
                case 8: GameCard = Cards_Game.Properties.Resources._8; break;
                case 9: GameCard = Cards_Game.Properties.Resources._9; break;
            }
        }
        //Function
        public void SwitchImages()
        {
            if (Image == Background) { Image = GameCard; Enabled = false; }
            else { Image = Background; Enabled = true; }


        }


    }


}


