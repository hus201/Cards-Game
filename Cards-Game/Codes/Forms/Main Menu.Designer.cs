
namespace Cards_Game
{
    partial class MainMenu
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
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.rdoMulti = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.chkExpert = new System.Windows.Forms.CheckBox();
            this.chkHard = new System.Windows.Forms.CheckBox();
            this.chkNormal = new System.Windows.Forms.CheckBox();
            this.chkEasy = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Checked = true;
            this.rdoSingle.Location = new System.Drawing.Point(3, 41);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(83, 17);
            this.rdoSingle.TabIndex = 0;
            this.rdoSingle.TabStop = true;
            this.rdoSingle.Text = "SinglePlayer";
            this.rdoSingle.UseVisualStyleBackColor = true;
            // 
            // rdoMulti
            // 
            this.rdoMulti.AutoSize = true;
            this.rdoMulti.Location = new System.Drawing.Point(3, 64);
            this.rdoMulti.Name = "rdoMulti";
            this.rdoMulti.Size = new System.Drawing.Size(76, 17);
            this.rdoMulti.TabIndex = 1;
            this.rdoMulti.Text = "MultiPlayer";
            this.rdoMulti.UseVisualStyleBackColor = true;
            this.rdoMulti.CheckedChanged += new System.EventHandler(this.RadioChange);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdoMulti);
            this.panel1.Controls.Add(this.rdoSingle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 112);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game MODE";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblDifficulty);
            this.panel2.Controls.Add(this.chkExpert);
            this.panel2.Controls.Add(this.chkHard);
            this.panel2.Controls.Add(this.chkNormal);
            this.panel2.Controls.Add(this.chkEasy);
            this.panel2.Location = new System.Drawing.Point(130, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 111);
            this.panel2.TabIndex = 3;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(14, 2);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(47, 13);
            this.lblDifficulty.TabIndex = 3;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // chkExpert
            // 
            this.chkExpert.AutoSize = true;
            this.chkExpert.Location = new System.Drawing.Point(17, 87);
            this.chkExpert.Name = "chkExpert";
            this.chkExpert.Size = new System.Drawing.Size(56, 17);
            this.chkExpert.TabIndex = 3;
            this.chkExpert.Text = "Expert";
            this.chkExpert.UseVisualStyleBackColor = true;
            this.chkExpert.CheckedChanged += new System.EventHandler(this.chkExpert_CheckedChanged);
            // 
            // chkHard
            // 
            this.chkHard.AutoSize = true;
            this.chkHard.Location = new System.Drawing.Point(17, 64);
            this.chkHard.Name = "chkHard";
            this.chkHard.Size = new System.Drawing.Size(49, 17);
            this.chkHard.TabIndex = 2;
            this.chkHard.Text = "Hard";
            this.chkHard.UseVisualStyleBackColor = true;
            this.chkHard.CheckedChanged += new System.EventHandler(this.chkHard_CheckedChanged);
            // 
            // chkNormal
            // 
            this.chkNormal.AutoSize = true;
            this.chkNormal.Location = new System.Drawing.Point(17, 41);
            this.chkNormal.Name = "chkNormal";
            this.chkNormal.Size = new System.Drawing.Size(59, 17);
            this.chkNormal.TabIndex = 1;
            this.chkNormal.Text = "Normal";
            this.chkNormal.UseVisualStyleBackColor = true;
            this.chkNormal.CheckedChanged += new System.EventHandler(this.chkNormal_CheckedChanged);
            // 
            // chkEasy
            // 
            this.chkEasy.AutoSize = true;
            this.chkEasy.Location = new System.Drawing.Point(17, 18);
            this.chkEasy.Name = "chkEasy";
            this.chkEasy.Size = new System.Drawing.Size(49, 17);
            this.chkEasy.TabIndex = 0;
            this.chkEasy.Text = "Easy";
            this.chkEasy.UseVisualStyleBackColor = true;
            this.chkEasy.CheckedChanged += new System.EventHandler(this.chkEasy_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 130);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(238, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 174);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoSingle;
        private System.Windows.Forms.RadioButton rdoMulti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.CheckBox chkExpert;
        private System.Windows.Forms.CheckBox chkHard;
        private System.Windows.Forms.CheckBox chkNormal;
        private System.Windows.Forms.CheckBox chkEasy;
        private System.Windows.Forms.Button btnStart;
    }
}