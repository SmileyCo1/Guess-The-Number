using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class GuessMyNumber : Form
    {
        int Number;
        int NumberOfTries;
        int BestScore;
        int Total = 0;
        public GuessMyNumber()
        {
            InitializeComponent();
        }

        private void GuessMyNumber_Load(object sender, EventArgs e)
        {
            Random Generator = new Random();
            Number = Generator.Next(0, 101);

            lblOutput.Text = "Try to guess a number between 1 and 100";
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Random Generator = new Random();
            Number = Generator.Next(0, 101);
            lblOutput.Text = "Try to guess a number between 1 and 100";
        }

        private void BtnGuess_Click(object sender, EventArgs e)
        {
            int Guess = Convert.ToInt32(TxtOutput.Text);

            if (Guess > Number)
            {
                lblOutput.Text = "Guess was too high, try again!";
                NumberOfTries++;
            }

            if (Guess < Number)
            {
                lblOutput.Text = "Guess was too low, try again!";
                NumberOfTries++;
            }

            if (Guess == Number)
            {
                lblOutput.Text = "You guessed it right, congrats!";
                if (NumberOfTries > BestScore)
                {
                    TxtScore.Text = Convert.ToString(NumberOfTries);
                }
            }
            TxtGuesses.Text = Convert.ToString(NumberOfTries);
        }

        private void BtnGive_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "The number was " + Number + ". Guess the new number!";
            Random Generator = new Random();
            Number = Generator.Next(0, 101);
        }
    }
}
