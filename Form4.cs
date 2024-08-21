using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuppFuncs;
namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public string LoggedInUser { get; set; }

        int numA;
        int numB;
        int total;
        int points = 0;
        int score = 0;
        Random rnd = new Random();
        string[] Maths = { "Add", "Subtract", "Multiply" };

        string secretAnswer;
        string userChoice;


        public Form4()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {

            numA = rnd.Next(0, 9);
            numB = rnd.Next(0, 9);

            secretAnswer = Maths[rnd.Next(0, Maths.Length)];

            switch (secretAnswer)
            {
                case "Add":
                    total = numA + numB;
                    break;

                case "Subtract":
                    total = numA - numB;
                    break;

                case "Multiply":
                    total = numA * numB;
                    break;
            }

            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();
            lblTotal.Text = total.ToString();
            lblSymbol.Text = "?";
        }

        private void CheckAnswer()
        {

            if (userChoice == secretAnswer)
            {
                score += 1;
                MessageBox.Show("Correct, Keep up");
                SetUpGame();
                if (score == 3)
                {
                    points += 8;
                    MessageBox.Show("You've earned 8 points! Total points: " + points);
                    SupportFunctions.AddPoints(LoggedInUser, points);

                }
                if (score >= 6)
                {
                    MessageBox.Show("Congratulations! You've reached 16 points. Game over!");
                    SupportFunctions.AddPoints(LoggedInUser, points);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Incorrect, try again!");
                lblSymbol.Text = "?";
            }


        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Q)
            {
                userChoice = "Add";
                lblSymbol.Text = "+";
                CheckAnswer();
            }
            if (e.KeyCode == Keys.W)
            {
                userChoice = "Subtract";
                lblSymbol.Text = "-";
                CheckAnswer();
            }
            if (e.KeyCode == Keys.E)
            {
                userChoice = "Multiply";
                lblSymbol.Text = "x";
                CheckAnswer();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNumA_Click(object sender, EventArgs e)
        {

        }
    }
}
