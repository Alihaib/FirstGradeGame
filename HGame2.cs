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
    public partial class HGame2 : UserControl
    {
        public string LoggedInUser { get; set; }
        private int count;
        private static string excelFilePath = "C:\\Users\\fadi\\Documents\\db.xlsx";
        private UserControl currentusercontrol;
        private List<Question> questions;
        private int currentQuestionIndex;
        private int numofq;
        public HGame2()
        {
            InitializeComponent();
            LoadQuestions();
            ShuffleQuestions();
            currentQuestionIndex = 0;
            numofq = 1;
            count = 0;
            DisplayCurrentQuestion();
        }

        private void LoadQuestions()
        {
            questions = new List<Question>
        {
            new Question { Text = "הילד ______ את התפוח.", Answers = new List<string> { "אכל", "הלך", "שיחק", "כתב" }, CorrectAnswer = "אכל" },
            new Question { Text = "הילד ______ על המחברת.", Answers = new List<string> { "הלך", "זרק", "כתב", "ראה" }, CorrectAnswer = "כתב" },
            new Question { Text = "אתמול ______ כדורגל עם חברים.", Answers = new List<string> { "אכלתי", "שיחקתי", "אמרתי", "שמרתי" }, CorrectAnswer = "שיחקתי" },
            new Question { Text = "מחר אני הולך ______ סרט.", Answers = new List<string> { "לשחק", "לכנס", "לשחות", "לראות" }, CorrectAnswer = "לראות" },
            new Question { Text = "אני ______ אנגלית בבית הספר.", Answers = new List<string> { "משחק", "לומד", "אוכל", "צוחק" }, CorrectAnswer = "לומד" },

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
            if (currentusercontrol != null)
            {
                this.Controls.Remove(currentusercontrol);
                currentusercontrol.Dispose();
            }

            currentusercontrol = new HebPage();
            currentusercontrol.Dock = DockStyle.Fill;
            this.Controls.Add(currentusercontrol);
            currentusercontrol.BringToFront();
        }



        private void button1_Click_1(object sender, EventArgs e)
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

