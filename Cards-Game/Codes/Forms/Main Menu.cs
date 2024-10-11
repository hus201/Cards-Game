using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards_Game
{
    public partial class MainMenu : Form
    {
        /* 
         MainMenu Form Helps User To Select The Game Settings They Want to Play In
         */
        //Parameters
        GameMode GameMode = GameMode.SinglePlayer;
        Difficulty Difficulty = Difficulty.None;

        //Constractor
        public MainMenu() => InitializeComponent();

        //Settings Selection Functions
        private void RadioChange(object sender, EventArgs e)
        {
            if (rdoSingle.Checked) GameMode = GameMode.SinglePlayer;
            else GameMode = GameMode.MultiPlayer;
            chk();
        }
        private void chkEasy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEasy.Checked)
            {
                Difficulty = Difficulty.Easy; chkNormal.Checked = chkHard.Checked = chkExpert.Checked = false;
            }
            chk();



        }
        private void chkNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNormal.Checked)
            {
                Difficulty = Difficulty.Normal;
                chkEasy.Checked = chkHard.Checked = chkExpert.Checked = false;

            }
            chk();
        }
        private void chkHard_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHard.Checked)
            {
                Difficulty = Difficulty.Hard;
                chkNormal.Checked = chkEasy.Checked = chkExpert.Checked = false;

            }
            chk();
        }
        private void chkExpert_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExpert.Checked)
            {
                Difficulty = Difficulty.Expert;
                chkNormal.Checked = chkHard.Checked = chkEasy.Checked = false;

            }
            chk();
        }
        //Function Method
        void chk()
        {
            if (chkEasy.Checked == false && chkNormal.Checked == false && chkHard.Checked == false && chkExpert.Checked == false) Difficulty = Difficulty.None;
            if (GameMode != GameMode.None && Difficulty != Difficulty.None)
            {
                btnStart.Enabled = true;
            }
            else btnStart.Enabled = false;

        }
        //StartGame Function
        private void btnStart_Click(object sender, EventArgs e)
        {
            CardsGame Game = new CardsGame(Difficulty, GameMode);
            this.Hide();
            Game.ShowDialog();
            this.Show();
        }
    }
}
