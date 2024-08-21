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
    public partial class mathpage : UserControl
    {
        public string LoggedInUser { get; set; }
        public mathpage()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form3 gameForm = new Form3
            {
                LoggedInUser = this.LoggedInUser // Pass the LoggedInUser to Form3
            };
            gameForm.ShowDialog();

        }

        private void Addpoints_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(LoggedInUser))
            {
                MessageBox.Show("Username is Null.");
                return;
            }
            else
            {
                SupportFunctions.AddPoints(LoggedInUser, 10);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 gameForm = new Form4
            {
                LoggedInUser = this.LoggedInUser // Pass the LoggedInUser to Form3
            };
            gameForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
