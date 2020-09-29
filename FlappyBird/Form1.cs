﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipespeed = 13;
        int gravity = 15;
        int score = 0;

        public Form1()
        { 
            try
            {
                InitializeComponent();
                GameMenu.Hide();
            }
            catch
            {
                Console.WriteLine("Failed to initialize.");
            }
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Flappy.Top += gravity;
            PipeBot.Left -= pipespeed;
            PipeTop.Left -= pipespeed;
            ScoreTxt.Text = "Score: " + score;

            if (PipeBot.Left < -150)
            {
                PipeBot.Left = 800;  
                score++;  
            }
            if (PipeTop.Left < -180)
            {
                PipeTop.Left = 950;
                score++;
            }
            
            if (Flappy.Bounds.IntersectsWith(PipeBot.Bounds) ||
                Flappy.Bounds.IntersectsWith(PipeTop.Bounds) ||
                Flappy.Bounds.IntersectsWith(Ground.Bounds)
                )
            {
                endGame(); // Kontrollerar så att Flappy inte fuskar, han får ej röra något. 
            }

            if(score > 5)
            {
                pipespeed = 18;
            }
            if (score > 15)
            {
                pipespeed = 25;
            }
            if (score > 25)
            {
                pipespeed = 40;
            }
            if (score > 40)
            {
                pipespeed = 50;
            }

            if (Flappy.Top < -25)
            {
                endGame(); // Kontrollerar så att Flappy inte fuskar genom att flyga över banan. 
            }
        }
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            // MessageBox.Show("Key press detetced, yi-haa!"); Testar keypress. 
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10; // Flappy går upp.  
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
             //MessageBox.Show("Key release detetced, yi-haa!"); Testar keyrealease.

            if (e.KeyCode == Keys.Space)
            {
                gravity = 10; // Flappy går ner. 
            }

        }

        private void endGame()
        {
            GameTimer.Stop();
            ScoreTxt.Text += " Game Over! ";
            score = 0; 
            pipespeed = 13; // Resetar speed inför '"Retry". 
            GameMenu.Show(); 
        }

        private void LabelRestart_Click(object sender, EventArgs e)
        {
            GameTimer.Start(); 
            GameMenu.Hide();
            Flappy.Location = new Point (72, 149);
            PipeTop.Location = new Point (277, -3);
            PipeBot.Location = new Point(388, 281);
            Ground.Location = new Point(-9, 476);
        }

        private void labelQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public static List<int> Hscore = new List<int>();
        public static List<int> player = new List<int>();

        private void lblHighScore_Click(object sender, EventArgs e)
        {
          
        }
    }
}