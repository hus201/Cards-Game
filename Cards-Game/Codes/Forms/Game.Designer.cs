
namespace Cards_Game
{
    partial class CardsGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Player1 = new System.Windows.Forms.Timer(this.components);
            this.Player2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.Interval = 1000;
            this.Player1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Player2
            // 
            this.Player2.Interval = 1000;
            this.Player2.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // CardsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 333);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CardsGame";
            this.Text = "Game";
            this.Activated += new System.EventHandler(this.FirstRun);
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.Timer Player1;
        private System.Windows.Forms.Timer Player2;
    }
}

