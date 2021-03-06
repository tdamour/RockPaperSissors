﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class TheRing : Form
    {
        //Global variables 

        Random rand = new Random();
        int computerWins, userWins, ties, total;
       

        public TheRing()
        {
            InitializeComponent();
        }

        //if user clicks on btnRock to choose the Golem as their champion 

        private void btnRock_Click(object sender, EventArgs e)
        {
            //this basicially sets up the pictures and grabs pictures from Resources.
            //the picture box becomes visible 
            picPlayer.Visible = true;
            picPlayer.Image = Properties.Resources.rock;  
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;

            //randomization of computer choice 
            int computer = rand.Next(0, 6);


            if (computer == 1)   //computer selects Rock (golem) 
            {
                ShowRock();

                MessageBox.Show("Tie");
                ties += 1; 
                TiesCount.Text = ties.ToString(); 
            }
            else if(computer == 2)   //if computer selects Paper (venus flybeast) 
            {
                ShowPaper(); 

                MessageBox.Show("Computer Wins");
                computerWins += 1;
                ComputerCount.Text = computerWins.ToString(); 
            }
            else if(computer == 3) //if computer selects Scissors (space knight) 
            {
                ShowScissors(); 

                MessageBox.Show("Player Wins");
                userWins += 1;
                PlayerCount.Text = userWins.ToString(); 
            }
            else if(computer == 4) //if computer selects Lizard(spiked jaw dragon) 
            {
                ShowLizard(); 

                MessageBox.Show("Player Wins");
                userWins += 1;
                PlayerCount.Text = userWins.ToString();

            }
            else                  // if computer selects Spock (mind lord) 
            {
                ShowSpock(); 

                MessageBox.Show("Computer Wins");
                computerWins += 1;
                ComputerCount.Text = computerWins.ToString();

            }

        }

        //if user picks The Venus FlyBeast (paper) as their champion ... 

        private void btnPaper_Click(object sender, EventArgs e)
        {

            picPlayer.Visible = true;
            picPlayer.Image =  Properties.Resources.paper;
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;

            int computer = rand.Next(0, 6);

            if (computer == 1)  //if computer pick Rock (golem) 
            {
                ShowRock(); 

                MessageBox.Show("Player Wins");
                userWins += 1;
                PlayerCount.Text = userWins.ToString();
            }
            else if (computer == 2)  //if computer picked Paper (venus flybeast)
            {
                ShowPaper(); 

                MessageBox.Show("Tie");
                ties += 1;
                TiesCount.Text = ties.ToString(); 
            }
            else if(computer == 3)  //if computer pick Scissors (space knight) 
            {
                ShowScissors(); 

                MessageBox.Show("Computer Wins");
                computerWins += 1;
                ComputerCount.Text = computerWins.ToString(); 
            }
            else if (computer == 4) //if computer selects Lizard(spiked jaw dragon) 
            {
                ShowLizard(); 

                MessageBox.Show("Computer Wins");
                computerWins += 1;
                ComputerCount.Text = computerWins.ToString();


            }
            else                  // if computer selects Spock (mind lord) 
            {
                ShowSpock(); 

                MessageBox.Show("Player Wins");
                userWins += 1;
                PlayerCount.Text = userWins.ToString();
              
            }

        }

        //if player pick Space Knight (scissors) as their champion ... 

        private void btnScisscors_Click(object sender, EventArgs e)
        {

            picPlayer.Visible = true;
            picPlayer.Image =  Properties.Resources.scissors;
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;

            int computer = rand.Next(0, 6);
           

            if (computer == 1) //computer picks Rock(golem) 
            {
                ShowRock(); 

                MessageBox.Show("Computer Wins");
                computerWins += 1;
                ComputerCount.Text = computerWins.ToString(); 
            }
            else if (computer == 2) //computer picks Paper(venus flybeast) 
            {

                ShowPaper(); 

                MessageBox.Show("Player Wins");
                userWins += 1;
                PlayerCount.Text = userWins.ToString();
            }
            else if(computer ==3) //computer picks Scissors(space knight) 
            {

                ShowScissors(); 

                MessageBox.Show("Tie");
                ties += 1;
                TiesCount.Text = ties.ToString(); 
            }
            else if (computer == 4) //if computer selects Lizard(spiked jaw dragon) 
            {
                ShowLizard(); 

                MessageBox.Show("Player Wins");
                userWins += 1;
                PlayerCount.Text = userWins.ToString();


            }
            else                  // if computer selects Spock (mind lord) 
            {
                ShowSpock(); 

                MessageBox.Show("Computer Wins");
                computerWins += 1;
                ComputerCount.Text = computerWins.ToString();
               

            }

        }

        // if player choose the Spiked Jaw Dragon (lizard) as their champion... 

        private void btnLizard_Click(object sender, EventArgs e)
        {
            picPlayer.Visible = true;
            picPlayer.Image =  Properties.Resources.lizard;
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;

            int computer = rand.Next(0, 6);

            if (computer == 1) //computer picks Rock(golem) 
            {
                ShowRock(); 

                MessageBox.Show("Computer Wins");
                computerWins += 1;
                ComputerCount.Text = computerWins.ToString();
            }
            else if (computer == 2) //computer picks Paper(venus flybeast) 
            {

                ShowPaper(); 

                MessageBox.Show("Player Wins");
                userWins += 1;
                PlayerCount.Text = userWins.ToString();
            }
            else if (computer == 3) //computer picks Scissors(space knight) 
            {

                ShowScissors(); 

                MessageBox.Show("Computer Wins");
                computerWins += 1;
                ComputerCount.Text = computerWins.ToString();
             
            }
            else if (computer == 4) //if computer selects Lizard(spiked jaw dragon) 
            {
                ShowLizard(); 

                MessageBox.Show("Tie");
                ties += 1;
                TiesCount.Text = ties.ToString();

            }
            else                  // if computer selects Spock (mind lord) 
            {
                ShowSpock(); 

                MessageBox.Show("Player Wins");
                userWins += 1;
                PlayerCount.Text = userWins.ToString();

            }

        }

        //if player chooses Mind Lord (spock) to be their champion... 

        private void btnSpock_Click(object sender, EventArgs e)
        {
            picPlayer.Visible = true;
            picPlayer.Image =  Properties.Resources.spock;
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;

            int computer = rand.Next(0, 6);

            if (computer == 1) //computer picks Rock(golem) 
            {
                ShowRock(); 

                MessageBox.Show("Player Wins");
                userWins += 1;
                PlayerCount.Text = userWins.ToString();
              
            }
            else if (computer == 2) //computer picks Paper(venus flybeast) 
            {

                ShowPaper(); 

                MessageBox.Show("Computer Wins");
                computerWins += 1;
                ComputerCount.Text = computerWins.ToString();

            }
            else if (computer == 3) //computer picks Scissors(space knight) 
            {

                ShowScissors(); 

                MessageBox.Show("Player Wins");
                userWins += 1;
                PlayerCount.Text = userWins.ToString();
             

            }
            else if (computer == 4) //if computer selects Lizard(spiked jaw dragon) 
            {
                ShowLizard(); 

                MessageBox.Show("Computer Wins");
                computerWins += 1;
                ComputerCount.Text = computerWins.ToString();


            }
            else                  // if computer selects Spock (mind lord) 
            {
                ShowSpock(); 

                MessageBox.Show("Tie");
                ties += 1;
                TiesCount.Text = ties.ToString();

            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //total calc... 
            total = computerWins + userWins + ties; 

            //if computer has more wins 
            if (computerWins > userWins)
            {
                MessageBox.Show("You don't deserved to be champion !" + "\n\nStats :" + "\nPlayer Wins : " + userWins + "\nComputer Wins : " + computerWins + "\nTies : " + ties + "\nTotal Hands : " + total);
                this.Close();
            }
            else if (userWins > computerWins) //if user have more wins 
            {
                MessageBox.Show("Fine... you are worthy of the title of champion !" + "\n\nStats :" + "\nPlayer Wins : " + userWins + "\nComputer Wins : " + computerWins + "\nTies : " + ties + "\nTotal Hands : " + total);
                this.Close();
            }
            else //if player & computer have the same amount of wins... 
            {
                MessageBox.Show("Seriously ? " + "\n\nStats :" + "\nPlayer Wins : " + userWins + "\nComputer Wins : " + computerWins + "\nTies : " + ties + "\nTotal Hands : " + total);
                this.Close();
            }

          
        }

        //Method calls for showcasing of the monsters for the computer... 


        private void ShowRock()
        {
            picComputer.Visible = true;
            picComputer.Image =  Properties.Resources.rock;
            picComputer.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void ShowPaper()
        {
            picComputer.Visible = true;
            picComputer.Image =  Properties.Resources.paper;
            picComputer.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void ShowScissors()
        {
            picComputer.Visible = true;
            picComputer.Image =  Properties.Resources.scissors;
            picComputer.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void ShowLizard()
        {
            picComputer.Visible = true;
            picComputer.Image =  Properties.Resources.lizard;
            picComputer.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void ShowSpock()
        {
            picComputer.Visible = true;
            picComputer.Image =  Properties.Resources.spock;
            picComputer.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}
