using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Reflection.Emit;
using SuppFuncs;

namespace WinFormsApp1
{
  
    public partial class HGame1 : UserControl
    {
        public string LoggedInUser { get; set; }
        private int count=0;
        private static string excelFilePath = "C:\\Users\\fadi\\Documents\\db.xlsx";
        private UserControl currentusercontrol;
        private List<Question> questions;
        private int currentQuestionIndex;
        private int numofq;
        
        public HGame1()
        {
            InitializeComponent();
            LoadQuestions();
            ShuffleQuestions();
            currentQuestionIndex = 0;
            numofq = 1;
            DisplayCurrentQuestion();
        }

        private void LoadQuestions()
        {
            questions = new List<Question>
        {
            new Question { Text = "איזה אות באה אחרי האות 'א' ?", Answers = new List<string> { "ב", "ז", "ר", "ח" }, CorrectAnswer = "ב" },
            new Question { Text = "איזה אות באה אחרי האות 'ש' ?", Answers = new List<string> { "ת", "ה", "ל", "פ" }, CorrectAnswer = "ת" },
            new Question { Text = "איזה אות באה אחרי האות 'ז' ?", Answers = new List<string> { "ח", "ג", "ט", "ס" }, CorrectAnswer = "ח" },
            new Question { Text = "איזה אות באה לפני האות 'ר' ?", Answers = new List<string> { "ק", "א", "ע", "כ" }, CorrectAnswer = "ק" },
            new Question { Text = "איזה אות באה לפני האות 'ה' ?", Answers = new List<string> { "ד", "מ", "צ", "נ" }, CorrectAnswer = "ד" },

        };
        }

        private void ShuffleQuestions()
        {
            Random rnd = new Random();
            questions = questions.OrderBy(q => rnd.Next()).ToList();
        }

        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex >= questions.Count)
            {
                MessageBox.Show("You have completed all questions!");
                return;
            }

            var question = questions[currentQuestionIndex];
            label3.Text = "שאלה " + numofq + " :";
            label1.Text = question.Text;
            checkBox1.Text = question.Answers[0];
            checkBox2.Text = question.Answers[1];
            checkBox3.Text = question.Answers[2];
            checkBox4.Text = question.Answers[3];

            // Clear previous selections
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //if (currentusercontrol != null)
            //{
            //    this.Controls.Remove(currentusercontrol);
            //    currentusercontrol.Dispose();
            //}

            //currentusercontrol = new HebPage();
            //currentusercontrol.Dock = DockStyle.Fill;
            //this.Controls.Add(currentusercontrol);
            //currentusercontrol.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var question = questions[currentQuestionIndex];
            numofq++;
            string selectedAnswer = null;

            if (checkBox1.Checked) selectedAnswer = checkBox1.Text;
            else if (checkBox2.Checked) selectedAnswer = checkBox2.Text;
            else if (checkBox3.Checked) selectedAnswer = checkBox3.Text;
            else if (checkBox4.Checked) selectedAnswer = checkBox4.Text;

            if (selectedAnswer == question.CorrectAnswer)
            {
                MessageBox.Show("Correct!");
                count++;
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }

            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                DisplayCurrentQuestion();
            }
            else if (currentQuestionIndex == questions.Count && count >= 3)
            {
                MessageBox.Show("You have completed all questions!");
                SupportFunctions.AddPoints(LoggedInUser, 15);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Game Over!");
                this.Hide();
            }

            //if (currentusercontrol != null)
            //{
            //    this.Controls.Remove(currentusercontrol);
            //    currentusercontrol.Dispose();
            //}

            //currentusercontrol = new HebPage();
            //currentusercontrol.Dock = DockStyle.Fill;
            //this.Controls.Add(currentusercontrol);
            //currentusercontrol.BringToFront();

        }

        }
    }


