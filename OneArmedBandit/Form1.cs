using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random rand = new Random();


        // int value for score initialized to 10
        int score = 10;
        int first;
        int second;
        int third;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {

            
            for (int i = 0; i <= 40; i++)
            {
                
                // get random values for each reel (store each in separate int variable)
                first = rand.Next(1, 4);
                second = rand.Next(1, 4);
                third = rand.Next(1, 4);

                // check value of reel 1 with a switch statement and set appropriate image
                switch (first)
                {
                    case 1:
                        reel1.Image = Properties.Resources._7_100x125;
                        break;
                    case 2:
                        reel1.Image = Properties.Resources.cherry_100x125;
                        break;
                    case 3:
                        reel1.Image = Properties.Resources.diamond_100x125;
                        break;
                }



                // check value of reel 2 with a switch statement and set appropriate image
                switch (second)
                {
                    case 1:
                        reel2.Image = Properties.Resources._7_100x125;
                        break;
                    case 2:
                        reel2.Image = Properties.Resources.cherry_100x125;
                        break;
                    case 3:
                        reel2.Image = Properties.Resources.diamond_100x125;
                        break;
                }

                // check value of reel 3 with a switch statement and set appropriate image
                switch (third)
                {
                    case 1:
                        reel3.Image = Properties.Resources._7_100x125;
                        break;
                    case 2:
                        reel3.Image = Properties.Resources.cherry_100x125;
                        break;
                    case 3:
                        reel3.Image = Properties.Resources.diamond_100x125;
                        break;
                }
                reel1.Refresh();
                reel2.Refresh();
                reel3.Refresh();
                if (i >= 20)
                {
                    Thread.Sleep(100 + (i * 5));
                }
                else
                {
                    Thread.Sleep(75);
                }
                
                
            }
           
                    /// STOP HERE ----------------------------------------------------------
                    /// Test to make sure that your program will display random
                    /// images to each reel. Only continue on after you know this works
                    /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            if (first == second && second == third)
            {
                // If yes show "winner" statement and add 3 to score.
                outputLabel.Text = "Winner!";
                score = score + 3;

            }
            else
            {
                // If no show "play again" statement and subtract 1 from score. 
                outputLabel.Text = "Play again?";
                score = score - 1;

            }
            // if score has reached 0 display "lose" message and set button enabled property to false
            if (score == 0)
            {
                outputLabel.Text = "You lose";
                spinButton.Enabled = false;
            }
            // display updated score
            scoreDisplay.Text = score + "";
            
        }
    }
}
