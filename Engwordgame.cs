using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using SuppFuncs;

namespace WinFormsApp1
{
    public partial class Engwordgame : Form
    {
        public string LoggedInUser { get; set; }
        private int remainingAttempts = 5;
        private int score = 0;
        private int correctGuesses = 0;
        private const int totalGuesses = 3;
        private string targetWord;
        private string[] wordList = {
            "HELLO", "WORLD", "GUESS", "CSHARP", "PROGRAM", "COMPUTER", "LANGUAGE", "CODE", "SOFTWARE", "HARDWARE",
            "INTERNET", "KEYBOARD", "MOUSE", "SCREEN", "MONITOR", "PRINTER", "LAPTOP", "DESKTOP", "SERVER", "CLIENT",
            "NETWORK", "DATABASE", "BROWSER", "WEBSITE", "SECURITY", "PASSWORD", "ENCRYPTION", "ALGORITHM", "FUNCTION", "VARIABLE",
            "CONSTANT", "PARAMETER", "ARGUMENT", "LOOP", "CONDITIONAL", "ARRAY", "LIST", "STACK", "QUEUE", "TREE",
            "GRAPH", "NODE", "EDGE", "BRANCH", "LEAF", "ROOT", "LINKEDLIST", "HASHMAP", "DICTIONARY", "SORT",
            "SEARCH", "INSERT", "DELETE", "UPDATE", "QUERY", "COMPILER", "INTERPRETER", "SYNTAX", "SEMANTICS", "DEBUGGER",
            "DEBUG", "TEST", "UNITTEST", "INTEGRATIONTEST", "PERFORMANCE", "OPTIMIZATION", "THREAD", "PROCESS", "MEMORY", "STORAGE",
            "FILE", "DIRECTORY", "PATH", "PERMISSION", "USER", "ADMIN", "SYSTEM", "APPLICATION", "SERVICE", "UTILITY",
            "FRAMEWORK", "LIBRARY", "PACKAGE", "MODULE", "CLASS", "OBJECT", "METHOD", "INTERFACE", "IMPLEMENTATION", "EXTENSION",
            "PLUGIN", "SCRIPT", "CONSOLE", "TERMINAL", "VIRTUALIZATION", "CONTAINERIZATION", "CLOUD", "API", "ENDPOINT"
        };
        private Random random = new Random();
        private int hintsGiven = 0;
        private System.Timers.Timer timer;
        private int timeLeft = 120;

        public Engwordgame()
        {
            InitializeComponent();

            InitializeTimer();  // Initialize the timer here
            StartNewGame();
        }



        private void StartNewGame()
        {
            targetWord = wordList[random.Next(wordList.Length)];
            remainingAttempts = 5;
            hintsGiven = 0;
            timeLeft = 120;
            correctGuesses = 0;
            UpdateAttemptsDisplay();
            UpdateScoreDisplay();
            UpdateHintDisplay();
            inputTextBox.Clear();
            SetTitleText("Guess the Word!", Color.White);
            submitButton.Enabled = true;
            hintButton.Enabled = true;
            timer.Start();
        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer(1000); // 1 second intervals
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                Invoke(new Action(UpdateTimeDisplay));
            }
            else
            {
                timer.Stop();
                Invoke(new Action(TimeUp));
            }
        }

        private void UpdateTimeDisplay()
        {
            timeLeftTextBox.Text = timeLeft + " seconds";
        }

        private void TimeUp()
        {
            if (timer != null)
            {
                timer.Stop();
            }
            SetTitleText("Time's up! The correct word was: " + targetWord, Color.Red);
            SupportFunctions.AddPoints(LoggedInUser, score);
            submitButton.Enabled = false;
            hintButton.Enabled = false;
            inputTextBox.Enabled = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string userInput = inputTextBox.Text.ToUpper().Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter a word.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userInput.Equals(targetWord, StringComparison.OrdinalIgnoreCase))
            {
                correctGuesses++;
                score += 10;
                UpdateScoreDisplay();

                if (correctGuesses < totalGuesses)
                {
                    SetTitleText("Correct! Guess the next word.", Color.Green);
                    targetWord = wordList[random.Next(wordList.Length)];
                    remainingAttempts = 5;
                    hintsGiven = 0;
                    UpdateAttemptsDisplay();
                    UpdateHintDisplay();
                }
                else
                {
                    SetTitleText("Congratulations! You guessed all words correctly!", Color.Green);
                    SupportFunctions.AddPoints(LoggedInUser, score);
                    submitButton.Enabled = false;
                    hintButton.Enabled = false;
                    inputTextBox.Enabled = false;
                    timer.Stop();
                }

                inputTextBox.Clear();
            }
            else
            {
                remainingAttempts--;
                score = Math.Max(0, score - 2);
                UpdateScoreDisplay();

                if (remainingAttempts > 0)
                {
                    SetTitleText("Incorrect. Try again!", Color.Red);
                    UpdateAttemptsDisplay();
                    inputTextBox.Clear();
                }
                else
                {
                    SetTitleText("No more attempts left! The correct word was: " + targetWord, Color.Red);
                    submitButton.Enabled = false;
                    hintButton.Enabled = false;
                    inputTextBox.Enabled = false;
                    timer.Stop();
                    SupportFunctions.AddPoints(LoggedInUser, score);

                }
            }

        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            if (hintsGiven < targetWord.Length - 2)
            {
                hintsGiven++;
                UpdateHintDisplay();
            }
            else
            {
                hintTextBox.Text = "No more hints available.";
                hintTextBox.Font = new Font(hintTextBox.Font, FontStyle.Bold);
            }
        }

        private void UpdateHintDisplay()
        {
            if (hintsGiven == 0)
            {
                hintTextBox.Text = "Click 'Hint' for a clue!";
            }
            else
            {
                hintTextBox.Text = "Hint: The word starts with '" + targetWord.Substring(0, hintsGiven) + "'";
            }
            hintTextBox.Font = new Font(hintTextBox.Font, FontStyle.Italic);
        }

        private void UpdateAttemptsDisplay()
        {
            attemptsTextBox.Text = remainingAttempts.ToString();
        }

        private void UpdateScoreDisplay()
        {
            scoreTextBox.Text = score.ToString();
        }

        private void SetTitleText(string text, Color color)
        {
            labelTitle.Text = text;
            labelTitle.ForeColor = color;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            StartNewGame();
            inputTextBox.Enabled = true;
        }

        private void Engwordgame_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }
    }

}
