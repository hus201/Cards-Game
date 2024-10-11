using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Cards_Game
{
    public partial class CardsGame : Form
    {

        /*
         Game Form The Form That the Acctual Game Will Be In
         */
        // parameters 
        Positions[] pos;
        Card[] Cards;
        CardValues[] values;
        int[] Scores;
        Card Card1;
        Card Card2;
        int[] Time;
        Label[] Labels;
        int CurrentPlayer = 0;
        GameMode GM;

        //Constractor It Will Also Calculate The Size Of Form According to Number Of Cards There
        public CardsGame(Difficulty Diff, GameMode gameMode)
        {
            
            GM = gameMode;
            InitializeComponent();
            //
            setPositions(Diff);

            //
            int columns = getColumns((int)Diff);
            int rows = getRows((int)Diff);
            //
            int width = columns * 110 + 24;
            int height = rows * 180 + (24 * (int)GM);
            //
            Labels = new Label[((int)GM * 3)];
            Scores = new int[(int)GM];
            Time = new int[(int)GM];
            if (GM == GameMode.SinglePlayer)
            {
                Time[0] = 0;
                Scores[0] = 0;
                Labels[0] = new Label();
                Labels[1] = new Label();
                Labels[2] = new Label();
                Labels[0].Text = "Player1 :";
                Labels[1].Text = "Score : ";
                Labels[2].Text = "";
                Labels[0].Location = new Point(0, height - Labels[0].Height);
                Labels[1].Location = new Point((int)(width * 0.4), height - Labels[1].Height);
                Labels[2].Location = new Point((int)(width * 0.8), height - Labels[2].Height);


            }
            else
            {

                Time[0] = 0;
                Scores[0] = 0;
                Labels[0] = new Label();
                Labels[1] = new Label();
                Labels[2] = new Label();
                Labels[0].Text = "Player1 :";
                Labels[1].Text = "Score : ";
                Labels[2].Text = "";
                Labels[0].Location = new Point(0, height - Labels[0].Height * 2);
                Labels[1].Location = new Point((int)(width * 0.4), height - Labels[1].Height * 2);
                Labels[2].Location = new Point((int)(width * 0.8), height - Labels[2].Height * 2);
                Time[1] = 0;
                Scores[1] = 0;
                Labels[3] = new Label();
                Labels[4] = new Label();
                Labels[5] = new Label();
                Labels[3].Text = "Player2 :";
                Labels[4].Text = "Score : ";
                Labels[5].Text = "";
                Labels[3].Location = new Point(0, height - Labels[3].Height);
                Labels[4].Location = new Point((int)(width * 0.4), height - Labels[4].Height);
                Labels[5].Location = new Point((int)(width * 0.8), height - Labels[5].Height);
            }
            for (int i = 0; i < Labels.Length; i++) Controls.Add(Labels[i]);
            this.ClientSize = new Size(width, height);
            Player1.Start();

        }
       
        //Functions

        /* Method That Will Set Automactilly Where The  Positions  Of Cards 
         * Will Be According to Number of Rows And Cols Then Set The Cards Randomly In These
         * Position Finally Calling Another Method That Will Assign Cards With Values 
         */
        void setPositions(Difficulty Diff)
        {
            int x = 12, y = 12;
            pos = new Positions[(int)Diff];

            int Index = 0;

            for (int row = 0; row < getRows((int)Diff); row++)
            {
                for (int col = 0; col < getColumns((int)Diff); col++)
                {
                    pos[Index] = new Positions((y + (col * 110)), x + (row * 180));
                    Index++;
                }



            }
            Cards = new Card[(int)Diff];
            for (int k = 0; k < (int)Diff; k++)
            {
                Cards[k] = new Card();
                Cards[k].Click += this.click_card;
            }
            int r = new Random().Next(0, (int)Diff);
            int i = 0;
            while (i < (int)Diff)
            {
                if (pos[r].C == null)
                {
                    Cards[i].setLocation(pos[r].x, pos[r].y);
                    pos[r].C = Cards[i];
                    i++;
                }
                else r = new Random().Next(0, (int)Diff);
            }
            setValues(Diff);
        }
        /* This Method Will Calculate Autmactily How Many Values Will Be There 
         * Then Randomly Assign These Values To Cards 
         * And Show These Cards In The Form
         */
        void setValues(Difficulty Diff)
        {

            values = new CardValues[(int)Diff];
            int Index = 0;
            for (int Loop = 0; Loop < (int)Diff / 2; Loop++)
            {
                values[Index] = new CardValues(Loop + 1);
                Index++;
                values[Index] = new CardValues(Loop + 1);
                Index++;
            }
            int r = new Random().Next(0, (int)Diff);
            int i = 0;
            while (i < (int)Diff)
            {
                if (values[r].isUsed == false)
                {

                    Cards[i].setCardValue(values[r].v);
                    values[r].isUsed = true;
                    i++;
                }
                else r = new Random().Next(0, (int)Diff);
            }
            for (int j = 0; j < (int)Diff; j++) Controls.Add(Cards[j]);







        }
        /* This Will Show The Cards For 2 Seconds At Start Of the Game 
         * To Get The Player Idea How To Player Without Dependence on Luck Only
         * Note: It Will Also Cause A delay on Closing The Form For 2 Seconds
         */
        private void FirstRun(object sender, EventArgs e)
        {
            for (int i = 0; i < Cards.Length; i++) Cards[i].SwitchImages();
            Task.Delay(2000).Wait();
            for (int i = 0; i < Cards.Length; i++) Cards[i].SwitchImages();
        }
        //Events

        /* This Event Will Handle The Game Scoring System So 
         * IF The User Clicked In Card IF its the First Card Clicked On It Will Be Saved
         * And Will Show The CardImage Until  Second Card Clikced On 
         * It Will show the Both Cards Images for 0.5s Then Check The Equality Between Them 
         * If They Are Equal Its Will Add 10 Scores To Player That Got It 
         * If all Cards Has Been Sloved Then It Will Show End Message 
         * And Calculate Who is The Winner if its MultiPlayer
         */
        private void click_card(object sender, EventArgs e)
        {
            Card temp = (Card)sender;
            if (Card1 == null)
            {
                Card1 = temp;
                Card1.SwitchImages();
            }
            else if (Card2 == null)
            {
                Card2 = temp;
                Card2.SwitchImages();
                Task.Delay(500).Wait();
                if (Card1.getValue() == Card2.getValue())
                {
                    Scores[CurrentPlayer] += 10;
                    Labels[1 + (CurrentPlayer * 3)].Text = "Score = " + Scores[CurrentPlayer].ToString();
                    Card1.Enabled = Card1.Visible = false;
                    Card2.Enabled = Card2.Visible = false;
                    Card1 = Card2 = null;
                    int ScoresSum = 0;
                    for (int i = 0; i < Scores.Length; i++) ScoresSum += Scores[i];
                    if (ScoresSum == ((Cards.Length + 1) / 2) * 10)
                    {
                        Player1.Stop();
                        Player2.Stop();
                        String Result_Msg = "";
                        if (GM == GameMode.MultiPlayer)
                        {
                            String winner = "";
                            if (Scores[0] == Scores[1]) winner = "Draw !"; else if (Scores[0] > Scores[1]) winner = "Player1 Wins !"; else winner = "Player2 Wins !";
                            Result_Msg = "Game Ended ! \n" +
                                "Player1 Scores : " + Scores[0].ToString() + " He Played for : " + Format_Time(Time[0]) + "\n" +
                                "Player2 Scores : " + Scores[1].ToString() + " He Played for : " + Format_Time(Time[1]) + "\n" +
                                winner;
                        }
                        else Result_Msg = "Congratultion! \n you Finished the game in : " + Format_Time(Time[0]);
                        MessageBox.Show(Result_Msg);
                        this.Close();
                    }
                }
                else
                {
                    Card1.SwitchImages();
                    Card2.SwitchImages();
                    Card1 = Card2 = null;
                    if (GM == GameMode.MultiPlayer) SwitchPlayers();
                }
            }




        }
        //This Method Will Handle The Time Change And Show IT In Formated Way
        private void timer_Tick(object sender, EventArgs e)
        {
            Time[CurrentPlayer]++;
            int time_label = (CurrentPlayer == 0) ? 2 : 5;
            Labels[time_label].Text = Format_Time(Time[CurrentPlayer]);
        }


        //Supportive Methods

        // Simple Method That Will Set Time In MM:SS Format
        String Format_Time(int time)
        {
            int mins = (time / 60);
            String Minutes = (mins >= 10) ? mins.ToString() : "0" + mins.ToString();
            int secs = (time % 60);
            String Seconds = (secs >= 10) ? secs.ToString() : "0" + secs.ToString();
            return Minutes + ":" + Seconds;
        }
       // Method That Will Switch Between Player 1 And 2 When Any Get Cards Wrong
        void SwitchPlayers()
        {
            if (CurrentPlayer == 0)
            {
                Player1.Stop();
                Player2.Start();
                CurrentPlayer = 1;
            }
            else
            {
                Player2.Stop();
                Player1.Start();
                CurrentPlayer = 0;
            }

        }
        //Method To Get How Many Rows That The Cards Will be In
        int getRows(int Cards)
        {
            if (Cards != 18) return 2;

            return 3;
        }
        //Method To Get How Many Columns That The Cards Will be In
        int getColumns(int Cards)
        {
            if (Cards == 18 || Cards == 12) return 6;
            if (Cards == 6) return 3;
            return 2;
        }
        
    }

}
