namespace WinFormsApp1
{
    partial class profile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelFavoriteGame = new System.Windows.Forms.Label();
            this.labelCoins = new System.Windows.Forms.Label();
            this.labelProductsBought = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.textBoxFavoriteGame = new System.Windows.Forms.TextBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pointsvalue = new System.Windows.Forms.Label();
            this.Gendervalue = new System.Windows.Forms.Label();
            this.mailvalue = new System.Windows.Forms.Label();
            this.WritingToolvalue = new System.Windows.Forms.Label();
            this.Toysvalue = new System.Windows.Forms.Label();
            this.Bookvalue = new System.Windows.Forms.Label();
            this.stickervalue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.IDvalue = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.Label();
            this.ID2Value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(15, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(559, 60);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Personal Information";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(46, 161);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(129, 35);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEmail
            // 
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(46, 224);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(129, 35);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAddress
            // 
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(46, 300);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(129, 35);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "ID:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBirthday
            // 
            this.labelBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBirthday.ForeColor = System.Drawing.Color.White;
            this.labelBirthday.Location = new System.Drawing.Point(46, 368);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(129, 35);
            this.labelBirthday.TabIndex = 5;
            this.labelBirthday.Text = "Birthday:";
            this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGender
            // 
            this.labelGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGender.ForeColor = System.Drawing.Color.White;
            this.labelGender.Location = new System.Drawing.Point(46, 439);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(129, 35);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Gender:";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFavoriteGame
            // 
            this.labelFavoriteGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFavoriteGame.ForeColor = System.Drawing.Color.White;
            this.labelFavoriteGame.Location = new System.Drawing.Point(46, 502);
            this.labelFavoriteGame.Name = "labelFavoriteGame";
            this.labelFavoriteGame.Size = new System.Drawing.Size(159, 35);
            this.labelFavoriteGame.TabIndex = 7;
            this.labelFavoriteGame.Text = "Favorite Game:";
            this.labelFavoriteGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFavoriteGame.Click += new System.EventHandler(this.labelFavoriteGame_Click);
            // 
            // labelCoins
            // 
            this.labelCoins.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCoins.ForeColor = System.Drawing.Color.White;
            this.labelCoins.Location = new System.Drawing.Point(381, 95);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(98, 35);
            this.labelCoins.TabIndex = 8;
            this.labelCoins.Text = "Points:";
            this.labelCoins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProductsBought
            // 
            this.labelProductsBought.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProductsBought.ForeColor = System.Drawing.Color.White;
            this.labelProductsBought.Location = new System.Drawing.Point(381, 161);
            this.labelProductsBought.Name = "labelProductsBought";
            this.labelProductsBought.Size = new System.Drawing.Size(81, 35);
            this.labelProductsBought.TabIndex = 9;
            this.labelProductsBought.Text = "Stickers";
            this.labelProductsBought.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(192, 161);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(142, 34);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.textBoxBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBirthday.ForeColor = System.Drawing.Color.White;
            this.textBoxBirthday.Location = new System.Drawing.Point(192, 368);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.ReadOnly = true;
            this.textBoxBirthday.Size = new System.Drawing.Size(142, 34);
            this.textBoxBirthday.TabIndex = 14;
            // 
            // textBoxFavoriteGame
            // 
            this.textBoxFavoriteGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.textBoxFavoriteGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFavoriteGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFavoriteGame.ForeColor = System.Drawing.Color.White;
            this.textBoxFavoriteGame.Location = new System.Drawing.Point(192, 502);
            this.textBoxFavoriteGame.Name = "textBoxFavoriteGame";
            this.textBoxFavoriteGame.ReadOnly = true;
            this.textBoxFavoriteGame.Size = new System.Drawing.Size(142, 34);
            this.textBoxFavoriteGame.TabIndex = 16;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(34)))));
            this.buttonSaveChanges.FlatAppearance.BorderSize = 0;
            this.buttonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveChanges.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveChanges.ForeColor = System.Drawing.Color.White;
            this.buttonSaveChanges.Location = new System.Drawing.Point(442, 551);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(116, 37);
            this.buttonSaveChanges.TabIndex = 19;
            this.buttonSaveChanges.Text = "Save";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(381, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 35);
            this.label2.TabIndex = 21;
            this.label2.Text = "Writing Tools";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(375, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 35);
            this.label3.TabIndex = 22;
            this.label3.Text = "Coloring Book";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(398, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 35);
            this.label4.TabIndex = 23;
            this.label4.Text = "Toys Pack";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsvalue
            // 
            this.pointsvalue.AutoSize = true;
            this.pointsvalue.ForeColor = System.Drawing.Color.White;
            this.pointsvalue.Location = new System.Drawing.Point(514, 96);
            this.pointsvalue.Name = "pointsvalue";
            this.pointsvalue.Size = new System.Drawing.Size(34, 28);
            this.pointsvalue.TabIndex = 25;
            this.pointsvalue.Text = "30";
            this.pointsvalue.Click += new System.EventHandler(this.label5_Click);
            // 
            // Gendervalue
            // 
            this.Gendervalue.AutoSize = true;
            this.Gendervalue.ForeColor = System.Drawing.Color.White;
            this.Gendervalue.Location = new System.Drawing.Point(192, 446);
            this.Gendervalue.Name = "Gendervalue";
            this.Gendervalue.Size = new System.Drawing.Size(55, 28);
            this.Gendervalue.TabIndex = 26;
            this.Gendervalue.Text = "Male";
            // 
            // mailvalue
            // 
            this.mailvalue.AutoSize = true;
            this.mailvalue.ForeColor = System.Drawing.Color.White;
            this.mailvalue.Location = new System.Drawing.Point(133, 205);
            this.mailvalue.Name = "mailvalue";
            this.mailvalue.Size = new System.Drawing.Size(0, 28);
            this.mailvalue.TabIndex = 27;
            this.mailvalue.Click += new System.EventHandler(this.label6_Click);
            // 
            // WritingToolvalue
            // 
            this.WritingToolvalue.AutoSize = true;
            this.WritingToolvalue.ForeColor = System.Drawing.Color.White;
            this.WritingToolvalue.Location = new System.Drawing.Point(525, 375);
            this.WritingToolvalue.Name = "WritingToolvalue";
            this.WritingToolvalue.Size = new System.Drawing.Size(23, 28);
            this.WritingToolvalue.TabIndex = 28;
            this.WritingToolvalue.Text = "2";
            // 
            // Toysvalue
            // 
            this.Toysvalue.AutoSize = true;
            this.Toysvalue.ForeColor = System.Drawing.Color.White;
            this.Toysvalue.Location = new System.Drawing.Point(525, 231);
            this.Toysvalue.Name = "Toysvalue";
            this.Toysvalue.Size = new System.Drawing.Size(23, 28);
            this.Toysvalue.TabIndex = 29;
            this.Toysvalue.Text = "3";
            // 
            // Bookvalue
            // 
            this.Bookvalue.AutoSize = true;
            this.Bookvalue.ForeColor = System.Drawing.Color.White;
            this.Bookvalue.Location = new System.Drawing.Point(525, 307);
            this.Bookvalue.Name = "Bookvalue";
            this.Bookvalue.Size = new System.Drawing.Size(23, 28);
            this.Bookvalue.TabIndex = 30;
            this.Bookvalue.Text = "1";
            this.Bookvalue.Click += new System.EventHandler(this.label9_Click);
            // 
            // stickervalue
            // 
            this.stickervalue.AutoSize = true;
            this.stickervalue.ForeColor = System.Drawing.Color.White;
            this.stickervalue.Location = new System.Drawing.Point(525, 167);
            this.stickervalue.Name = "stickervalue";
            this.stickervalue.Size = new System.Drawing.Size(23, 28);
            this.stickervalue.TabIndex = 31;
            this.stickervalue.Text = "2";
            this.stickervalue.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(46, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 28);
            this.label11.TabIndex = 32;
            this.label11.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.ForeColor = System.Drawing.Color.White;
            this.textBoxUsername.Location = new System.Drawing.Point(192, 96);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(142, 34);
            this.textBoxUsername.TabIndex = 33;
            // 
            // IDvalue
            // 
            this.IDvalue.AutoSize = true;
            this.IDvalue.BackColor = System.Drawing.Color.Transparent;
            this.IDvalue.ForeColor = System.Drawing.Color.White;
            this.IDvalue.Location = new System.Drawing.Point(192, 286);
            this.IDvalue.Name = "IDvalue";
            this.IDvalue.Size = new System.Drawing.Size(0, 28);
            this.IDvalue.TabIndex = 34;
            // 
            // EmailValue
            // 
            this.EmailValue.AutoSize = true;
            this.EmailValue.ForeColor = System.Drawing.Color.White;
            this.EmailValue.Location = new System.Drawing.Point(172, 231);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(65, 28);
            this.EmailValue.TabIndex = 35;
            this.EmailValue.Text = "label1";
            // 
            // ID2Value
            // 
            this.ID2Value.AutoSize = true;
            this.ID2Value.ForeColor = System.Drawing.Color.White;
            this.ID2Value.Location = new System.Drawing.Point(192, 303);
            this.ID2Value.Name = "ID2Value";
            this.ID2Value.Size = new System.Drawing.Size(65, 28);
            this.ID2Value.TabIndex = 36;
            this.ID2Value.Text = "label5";
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.ID2Value);
            this.Controls.Add(this.EmailValue);
            this.Controls.Add(this.IDvalue);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.stickervalue);
            this.Controls.Add(this.Bookvalue);
            this.Controls.Add(this.Toysvalue);
            this.Controls.Add(this.WritingToolvalue);
            this.Controls.Add(this.mailvalue);
            this.Controls.Add(this.Gendervalue);
            this.Controls.Add(this.pointsvalue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.textBoxFavoriteGame);
            this.Controls.Add(this.textBoxBirthday);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelProductsBought);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.labelFavoriteGame);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "profile";
            this.Size = new System.Drawing.Size(590, 632);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelFavoriteGame;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.Label labelProductsBought;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.TextBox textBoxFavoriteGame;
        private System.Windows.Forms.Button buttonSaveChanges;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label pointsvalue;
        private Label Gendervalue;
        private Label mailvalue;
        private Label WritingToolvalue;
        private Label Toysvalue;
        private Label Bookvalue;
        private Label stickervalue;
        private Label label11;
        private TextBox textBoxUsername;
        private Label IDvalue;
        private Label EmailValue;
        private Label ID2Value;
    }
}

