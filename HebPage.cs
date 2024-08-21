using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class HebPage : UserControl
    {
        public string LoggedInUser { get; set; }
        private UserControl currentusercontrol;
        public HebPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentusercontrol != null)
            {
                this.Controls.Remove(currentusercontrol);
                currentusercontrol.Dispose();
            }

            currentusercontrol = new HGame1() { LoggedInUser= this.LoggedInUser };
            currentusercontrol.Dock = DockStyle.Fill;
            this.Controls.Add(currentusercontrol);
            currentusercontrol.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentusercontrol != null)
            {
                this.Controls.Remove(currentusercontrol);
                currentusercontrol.Dispose();
            }

            currentusercontrol = new HGame2() { LoggedInUser = this.LoggedInUser };
            currentusercontrol.Dock = DockStyle.Fill;
            this.Controls.Add(currentusercontrol);
            currentusercontrol.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
