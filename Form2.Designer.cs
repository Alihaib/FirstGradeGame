namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.mathButton = new System.Windows.Forms.Button();
            this.hebrewButton = new System.Windows.Forms.Button();
            this.englishButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.test21 = new WinFormsApp1.Test2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Controls.Add(this.mathButton);
            this.panel1.Controls.Add(this.hebrewButton);
            this.panel1.Controls.Add(this.englishButton);
            this.panel1.Controls.Add(this.profileButton);
            this.panel1.Controls.Add(this.shopButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 667);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.White;
            this.sidepanel.Location = new System.Drawing.Point(0, 179);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(6, 55);
            this.sidepanel.TabIndex = 5;
            // 
            // mathButton
            // 
            this.mathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mathButton.FlatAppearance.BorderSize = 0;
            this.mathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mathButton.ForeColor = System.Drawing.Color.White;
            this.mathButton.Image = global::WinFormsApp1.Properties.Resources.Math;
            this.mathButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mathButton.Location = new System.Drawing.Point(14, 441);
            this.mathButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mathButton.Name = "mathButton";
            this.mathButton.Size = new System.Drawing.Size(168, 59);
            this.mathButton.TabIndex = 4;
            this.mathButton.Text = "      Math";
            this.mathButton.UseVisualStyleBackColor = true;
            this.mathButton.Click += new System.EventHandler(this.mathButton_Click);
            // 
            // hebrewButton
            // 
            this.hebrewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hebrewButton.FlatAppearance.BorderSize = 0;
            this.hebrewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hebrewButton.ForeColor = System.Drawing.Color.White;
            this.hebrewButton.Image = global::WinFormsApp1.Properties.Resources.Dreidel;
            this.hebrewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hebrewButton.Location = new System.Drawing.Point(14, 375);
            this.hebrewButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hebrewButton.Name = "hebrewButton";
            this.hebrewButton.Size = new System.Drawing.Size(168, 59);
            this.hebrewButton.TabIndex = 3;
            this.hebrewButton.Text = "      Hebrew";
            this.hebrewButton.UseVisualStyleBackColor = true;
            this.hebrewButton.Click += new System.EventHandler(this.hebrewButton_Click);
            // 
            // englishButton
            // 
            this.englishButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.englishButton.FlatAppearance.BorderSize = 0;
            this.englishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.englishButton.ForeColor = System.Drawing.Color.White;
            this.englishButton.Image = global::WinFormsApp1.Properties.Resources.white_book;
            this.englishButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.englishButton.Location = new System.Drawing.Point(14, 308);
            this.englishButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(168, 59);
            this.englishButton.TabIndex = 2;
            this.englishButton.Text = "    English";
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.Click += new System.EventHandler(this.englishButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.ForeColor = System.Drawing.Color.White;
            this.profileButton.Image = global::WinFormsApp1.Properties.Resources.User_Male;
            this.profileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.Location = new System.Drawing.Point(11, 179);
            this.profileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(168, 59);
            this.profileButton.TabIndex = 1;
            this.profileButton.Text = "      Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // shopButton
            // 
            this.shopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shopButton.FlatAppearance.BorderSize = 0;
            this.shopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopButton.ForeColor = System.Drawing.Color.White;
            this.shopButton.Image = ((System.Drawing.Image)(resources.GetObject("shopButton.Image")));
            this.shopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shopButton.Location = new System.Drawing.Point(14, 245);
            this.shopButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(168, 55);
            this.shopButton.TabIndex = 0;
            this.shopButton.Text = "      Shop";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel3.Location = new System.Drawing.Point(166, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 36);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // test21
            // 
            this.test21.Location = new System.Drawing.Point(166, 35);
            this.test21.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.test21.Name = "test21";
            this.test21.Size = new System.Drawing.Size(590, 632);
            this.test21.TabIndex = 9;
            this.test21.Load += new System.EventHandler(this.test21_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 667);
            this.Controls.Add(this.test21);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button mathButton;
        private Button hebrewButton;
        private Button englishButton;
        private Button profileButton;
        private Button shopButton;
        private Panel sidepanel;
        private Test2 test21;
    }
}