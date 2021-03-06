﻿namespace FlappyBird
{
    partial class Form1
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
            this.ScoreTxt = new System.Windows.Forms.Label();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Flappy = new System.Windows.Forms.PictureBox();
            this.PipeBot = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameMenu = new System.Windows.Forms.GroupBox();
            this.labelQuit = new System.Windows.Forms.Label();
            this.LabelRestart = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            this.GameMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScoreTxt
            // 
            this.ScoreTxt.AutoSize = true;
            this.ScoreTxt.BackColor = System.Drawing.Color.White;
            this.ScoreTxt.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTxt.Location = new System.Drawing.Point(16, 55);
            this.ScoreTxt.Name = "ScoreTxt";
            this.ScoreTxt.Size = new System.Drawing.Size(99, 31);
            this.ScoreTxt.TabIndex = 5;
            this.ScoreTxt.Text = "SCORE:";
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.White;
            this.Ground.Image = global::FlappyBird.Properties.Resources._411_4119076_flappy_bird_ground;
            this.Ground.Location = new System.Drawing.Point(-14, 732);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(824, 117);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 4;
            this.Ground.TabStop = false;
            // 
            // Flappy
            // 
            this.Flappy.Image = global::FlappyBird.Properties.Resources.flappyBird;
            this.Flappy.Location = new System.Drawing.Point(108, 229);
            this.Flappy.Name = "Flappy";
            this.Flappy.Size = new System.Drawing.Size(72, 60);
            this.Flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flappy.TabIndex = 3;
            this.Flappy.TabStop = false;
            // 
            // PipeBot
            // 
            this.PipeBot.Image = global::FlappyBird.Properties.Resources.pipeBottom;
            this.PipeBot.Location = new System.Drawing.Point(548, 412);
            this.PipeBot.Name = "PipeBot";
            this.PipeBot.Size = new System.Drawing.Size(136, 332);
            this.PipeBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBot.TabIndex = 2;
            this.PipeBot.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.Image = global::FlappyBird.Properties.Resources.pipeTop;
            this.PipeTop.Location = new System.Drawing.Point(416, -5);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(136, 262);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 0;
            this.PipeTop.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // GameMenu
            // 
            this.GameMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameMenu.Controls.Add(this.labelQuit);
            this.GameMenu.Controls.Add(this.LabelRestart);
            this.GameMenu.Location = new System.Drawing.Point(279, 271);
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(223, 122);
            this.GameMenu.TabIndex = 6;
            this.GameMenu.TabStop = false;
            this.GameMenu.Text = "Menu";
            // 
            // labelQuit
            // 
            this.labelQuit.AutoSize = true;
            this.labelQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelQuit.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuit.Location = new System.Drawing.Point(72, 64);
            this.labelQuit.Name = "labelQuit";
            this.labelQuit.Size = new System.Drawing.Size(81, 33);
            this.labelQuit.TabIndex = 2;
            this.labelQuit.Text = "QUIT";
            this.labelQuit.Click += new System.EventHandler(this.labelQuit_Click);
            // 
            // LabelRestart
            // 
            this.LabelRestart.AutoSize = true;
            this.LabelRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelRestart.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRestart.Location = new System.Drawing.Point(47, 23);
            this.LabelRestart.Name = "LabelRestart";
            this.LabelRestart.Size = new System.Drawing.Size(133, 33);
            this.LabelRestart.TabIndex = 1;
            this.LabelRestart.Text = "RESTART";
            this.LabelRestart.Click += new System.EventHandler(this.LabelRestart_Click);
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.White;
            this.lblHighScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHighScore.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(16, 14);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(169, 31);
            this.lblHighScore.TabIndex = 3;
            this.lblHighScore.Text = "HIGH SCORE:";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BackColor = System.Drawing.Color.White;
            this.lblValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValue.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(182, 14);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(29, 31);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(794, 848);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.ScoreTxt);
            this.Controls.Add(this.GameMenu);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeBot);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.Flappy);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird Ripoff";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            this.GameMenu.ResumeLayout(false);
            this.GameMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox PipeBot;
        private System.Windows.Forms.PictureBox Flappy;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label ScoreTxt;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.GroupBox GameMenu;
        private System.Windows.Forms.Label labelQuit;
        private System.Windows.Forms.Label LabelRestart;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblHighScore;
    }
}

