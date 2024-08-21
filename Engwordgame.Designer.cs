namespace WinFormsApp1
{
    partial class Engwordgame
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                timer.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.attemptsTextBox = new System.Windows.Forms.TextBox();
            this.hintTextBox = new System.Windows.Forms.TextBox();
            this.timeLeftTextBox = new System.Windows.Forms.TextBox();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.hintButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(100, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(600, 60);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Guess the Word!";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInput
            // 
            this.labelInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInput.ForeColor = System.Drawing.Color.White;
            this.labelInput.Location = new System.Drawing.Point(100, 220);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(600, 35);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "Enter your guess:";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFeedback
            // 
            this.labelFeedback.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFeedback.ForeColor = System.Drawing.Color.White;
            this.labelFeedback.Location = new System.Drawing.Point(100, 80);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(600, 35);
            this.labelFeedback.TabIndex = 2;
            this.labelFeedback.Text = "Feedback";
            this.labelFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTextBox.ForeColor = System.Drawing.Color.White;
            this.inputTextBox.Location = new System.Drawing.Point(300, 260);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(200, 29);
            this.inputTextBox.TabIndex = 3;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // attemptsTextBox
            // 
            this.attemptsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.attemptsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attemptsTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.attemptsTextBox.ForeColor = System.Drawing.Color.White;
            this.attemptsTextBox.Location = new System.Drawing.Point(100, 120);
            this.attemptsTextBox.Multiline = true;
            this.attemptsTextBox.Name = "attemptsTextBox";
            this.attemptsTextBox.ReadOnly = true;
            this.attemptsTextBox.Size = new System.Drawing.Size(600, 90);
            this.attemptsTextBox.TabIndex = 4;
            this.attemptsTextBox.TabStop = false;
            this.attemptsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hintTextBox
            // 
            this.hintTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.hintTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hintTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hintTextBox.ForeColor = System.Drawing.Color.White;
            this.hintTextBox.Location = new System.Drawing.Point(100, 382);
            this.hintTextBox.Name = "hintTextBox";
            this.hintTextBox.ReadOnly = true;
            this.hintTextBox.Size = new System.Drawing.Size(600, 29);
            this.hintTextBox.TabIndex = 7;
            this.hintTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeLeftTextBox
            // 
            this.timeLeftTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.timeLeftTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeLeftTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLeftTextBox.ForeColor = System.Drawing.Color.White;
            this.timeLeftTextBox.Location = new System.Drawing.Point(100, 424);
            this.timeLeftTextBox.Name = "timeLeftTextBox";
            this.timeLeftTextBox.ReadOnly = true;
            this.timeLeftTextBox.Size = new System.Drawing.Size(600, 29);
            this.timeLeftTextBox.TabIndex = 8;
            this.timeLeftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.scoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreTextBox.ForeColor = System.Drawing.Color.White;
            this.scoreTextBox.Location = new System.Drawing.Point(100, 466);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.ReadOnly = true;
            this.scoreTextBox.Size = new System.Drawing.Size(600, 29);
            this.scoreTextBox.TabIndex = 9;
            this.scoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(220, 320);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(150, 50);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Check Answer";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // hintButton
            // 
            this.hintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.hintButton.FlatAppearance.BorderSize = 0;
            this.hintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hintButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hintButton.ForeColor = System.Drawing.Color.White;
            this.hintButton.Location = new System.Drawing.Point(430, 320);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(150, 50);
            this.hintButton.TabIndex = 6;
            this.hintButton.Text = "Get a Hint";
            this.hintButton.UseVisualStyleBackColor = false;
            this.hintButton.Click += new System.EventHandler(this.hintButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(687, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Engwordgame
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.hintButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.attemptsTextBox);
            this.Controls.Add(this.hintTextBox);
            this.Controls.Add(this.timeLeftTextBox);
            this.Controls.Add(this.scoreTextBox);
            this.Name = "Engwordgame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess the Word Game";
            this.Load += new System.EventHandler(this.Engwordgame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox attemptsTextBox;
        private System.Windows.Forms.TextBox hintTextBox;
        private System.Windows.Forms.TextBox timeLeftTextBox;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button hintButton;
        private Button button1;
    }
}