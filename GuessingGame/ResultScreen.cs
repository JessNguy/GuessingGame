using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class ResultScreen : UserControl
    {
        public ResultScreen()
        {
            InitializeComponent();
            
            
            labelInformation1.Text = "Guess: " + GuessingGame.guessCount;
            labelInformation2.Text = "Orginal Order: ";
            for (int x = 0; x < GuessingGame.numberGuess.Count; x++)
            {
                labelNumber2.Text = " " + Convert.ToString(GuessingGame.numberGuess[x]);
            }

            labelInformation3.Text = "Sorted Order: " ;

            GuessingGame.numberGuess.Sort();

            for (int x = 0; x < GuessingGame.numberGuess.Count; x++)
            {
                labelNumber3.Text = " " + Convert.ToString(GuessingGame.numberGuess[x]);
            }

        }
    }
}
