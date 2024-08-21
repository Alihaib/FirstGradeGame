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
    public partial class Form3 : Form
    {
        public string LoggedInUser { get; set; }
        Random rnd = new Random();
        string[] Maths = { "Add", "Subtract", "Multiply" };
        int total;
        int score;
        int points = 0;
        int quisnum = 1;
        int resetCount = 0;

        public Form3()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAnswer.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers!");
                txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1);
            }
        }

        private void CheckButtonClickEvent(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAnswer.Text, out int userEntered))
            {
                MessageBox.Show("Please enter a valid number!");
                return;
            }

            if (userEntered == total)
            {
                lblAnswer.Text = "Correct";
                lblAnswer.ForeColor = Color.Green;
                score += 1;
                lblScore.Text = "Score: " + score;
            }
            else
            {
                lblAnswer.Text = "Incorrect";
                lblAnswer.ForeColor = Color.Red;
            }

            quisnum += 1;
            quisnum1.Text = "Q" + quisnum;

            if (quisnum > 5)
            {
                if (score >= 4)
                {
                    points += 3;
                    MessageBox.Show($"Amazing!!!!! You Won!! Points: {points}");
                }
                else
                {
                    MessageBox.Show("You Lost");
                }

                if (resetCount < 2)
                {
                    resetCount++;
                    ResetGame();
                }
                else
                {
                    MessageBox.Show($"Game Finished!! You have gained: {points} points.");
                    SupportFunctions.AddPoints(LoggedInUser, points);
                    Close();
                }
            }
            else
            {
                SetUpGame();
            }   
        }

        private void SetUpGame()
        {
            int numA = rnd.Next(1, 10);
            int numB = rnd.Next(1, 10);

            txtAnswer.Text = null;
            int x;
            switch (Maths[rnd.Next(0, Maths.Length)])
            {
                case "Add":
                    total = numA + numB;
                    lblSymbol.Text = "+";
                    lblSymbol.ForeColor = Color.DarkGreen;
                    break;

                case "Subtract":
                    if (numA < numB)
                    {
                        x = numA;
                        numA = numB;
                        numB = x;
                    }
                    total = numA - numB;
                    lblSymbol.Text = "-";
                    lblSymbol.ForeColor = Color.Maroon;
                    break;

                case "Multiply":
                    total = numA * numB;
                    lblSymbol.Text = "x";
                    lblSymbol.ForeColor = Color.Purple;
                    break;
            }

            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();
        }

        private void ResetGame()
        {
            quisnum = 1;
            score = 0;
            lblScore.Text = "Score: " + score;
            quisnum1.Text = "Q" + quisnum;
            SetUpGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quisnum1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //click to back to math page
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}