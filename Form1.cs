using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {

        int round = 3;
        int TimerPerRound = 6;
        bool gameOver = false;

        string[] CPUchoiceList = { "rock", "paper", "scissor", "paper", "scissor", "rock" };

        int randomnumber = 0;

        Random rnd = new Random();

        string CPUChoice;

        string playerChoice;

        int playerScore;
        int CPUScore;






        public Form1()
        {
            InitializeComponent();

            countDownTimer.Enabled = true;

            playerChoice = "none";

            txtCountDown.Text = "5";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void asd(object sender, EventArgs e)
        {

        }

        private void btnRockClick(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.rock;
            playerChoice = "rock";
        }

        private void btnpaperclick(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.paper;
            playerChoice = "paper";
        }

        private void btnscissorsclick(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.scissors;
            playerChoice = "scissor";
        }

        private void Restartbutton(object sender, EventArgs e)
        {

            playerScore = 0;
            CPUScore = 0;
            round = 3;
            txtScore.Text = "Player: " + playerScore + " - " + "AI: " + CPUScore;

            playerChoice = "none";

            countDownTimer.Enabled = true;
            picPlayer.Image = Properties.Resources.qq;
            piccpu.Image = Properties.Resources.qq;

            gameOver = false;
        }

        private void CountDownTimerEvent(object sender, EventArgs e)
        {
            TimerPerRound -= 1;

            txtCountDown.Text = TimerPerRound.ToString();

            txtRound.Text = "Rounds: " + round;

            if (TimerPerRound < 1)
            {
                countDownTimer.Enabled = false;

                TimerPerRound = 6;

                randomnumber = rnd.Next(0, CPUchoiceList.Length);

                CPUChoice = CPUchoiceList[randomnumber];

                switch (CPUChoice)
                {

                    case "rock":
                        piccpu.Image = Properties.Resources.rock;

                        break;
                    case "paper":
                        piccpu.Image = Properties.Resources.paper;
                        break;
                    case "scissor":
                        piccpu.Image = Properties.Resources.scissors;
                        break;

                }

                if(round > 0)
                {
                    checkgame();
                }
                else
                {

                    if(playerScore > CPUScore)
                    {
                        MessageBox.Show("Player Won The Game");
                    }
                    else
                    {
                        MessageBox.Show("AI Won The Game");
                    }

                    gameOver = true;
                }

            }           
        }
        private void checkgame()
        {
            if (playerChoice == "rock" && CPUChoice == "paper")
            {
                CPUScore += 1;

                round -= 1;

                MessageBox.Show("AI Wins, Paper Covers Rock");

            }
            else if (playerChoice == "scissor" && CPUChoice == "rock")
            {
                CPUScore += 1;

                round -= 1;

                MessageBox.Show("AI Wins, Rock Break Scissor");
            }
            else if (playerChoice == "paper" && CPUChoice == "scissor")
            {
                CPUScore += 1;

                round -= 1;

                MessageBox.Show("AI Wins, Scissor Cuts Paper");
            }
            else if (playerChoice == "rock" && CPUChoice == "scissor")
            {
                playerScore += 1;

                round -= 1;

                MessageBox.Show("Player Wins, Rock Break Scissor");
            }
            else if (playerChoice == "rock" && CPUChoice == "scissor")
            {
                playerScore += 1;

                round -= 1;

                MessageBox.Show("Player Wins, Rock Break Scissor");
            }
            else if (playerChoice == "paper" && CPUChoice == "rock")
            {
                playerScore += 1;

                round -= 1;

                MessageBox.Show("Player Wins, Paper Covers Rock");
            }
            else if (playerChoice == "scissor" && CPUChoice == "paper")
            {
                playerScore += 1;

                round -= 1;

                MessageBox.Show("Player Wins, Scissors Cut Paper");
            }
            else if (playerChoice == "none")
            {
                MessageBox.Show("Make a Choice");
            }
            else
            {
                MessageBox.Show("Draw!");
            }

            startNextRound();
        }

        private void startNextRound()
         
        {
            if(gameOver == true)
            {
                return;
            }

            txtScore.Text = "Player: " + playerScore + " - " + "AI: " + CPUScore;

            playerChoice = "none";

            countDownTimer.Enabled = true;
            picPlayer.Image = Properties.Resources.qq;
            piccpu.Image = Properties.Resources.qq;



        }

        private void txtCountDown_Click(object sender, EventArgs e)
        {

        }
    }
}
