using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SuppFuncs;

namespace WinFormsApp1
{
    public partial class Englettersgame : Form
    {
        public string LoggedInUser { get; set; }
        private string correctOrder = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private int hintIndex = 0;

        public Englettersgame()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string input = textBox2.Text.ToUpper();
            hintIndex = 0;


            for (int i = 0; i < input.Length; i++)
            {
                if (i < correctOrder.Length && input[i] == correctOrder[i])
                {
                    hintIndex++;
                }
                else
                {
                    break;
                }
            }

            if (input.Length > 0 && hintIndex == input.Length)
            {
                textBox1.Text = $"Good job! You've typed {hintIndex} letters correctly.";
            }
            else if (input.Length > 0)
            {
                textBox1.Text = $"Incorrect at position {hintIndex + 1}. Try again!";
            }
            else
            {
                textBox1.Text = "Start typing the letters...";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string input = textBox2.Text;

            if (input.Equals(correctOrder, StringComparison.OrdinalIgnoreCase))
            {
                textBox1.Text = "Correct! You entered the letters in the right order.";
                SupportFunctions.AddPoints(LoggedInUser, 15);
            }
            else
            {
                textBox1.Text = "Incorrect. Please try again.";
            }
        }

        private void Hint_Click(object sender, EventArgs e)
        {
            string input = textBox2.Text.ToUpper();
            hintIndex = 0;


            for (int i = 0; i < input.Length; i++)
            {
                if (i < correctOrder.Length && input[i] == correctOrder[i])
                {
                    hintIndex++;
                }
                else
                {
                    break;
                }
            }
            if (hintIndex < correctOrder.Length)
            {

                textBox1.Text = $"Correct so far: {correctOrder.Substring(0, hintIndex)}";
                textBox1.Text += $"\nHint: The next letter is '{correctOrder[hintIndex]}'";
            }
            else
            {
                textBox1.Text = "You've completed the sequence or no more hints available!";
            }
        }

        private void labelFeedback_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
