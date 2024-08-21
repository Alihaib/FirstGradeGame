using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Engpage : UserControl
    {
        public string LoggedInUser { get; set; }
        public Engpage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Engwordgame gameForm = new Engwordgame
            {
                LoggedInUser = this.LoggedInUser// Pass the LoggedInUser to Form3
            };
            gameForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Englettersgame gameForm = new Englettersgame
            {
                LoggedInUser = this.LoggedInUser// Pass the LoggedInUser to Form3
            };
            gameForm.ShowDialog();
        }
    }
}
