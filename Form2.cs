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
    
    public partial class Form2 : Form
    {
        public string LoggedInUser { get; set; }
        private mathpage mathPageControl;
        private Test shopcontrol;
        private HebPage hebPagecontrol;
        private Engpage engpagecontrol;
        private profile profilecontrol;
        public Form2(string loggedInUser)
        {
            InitializeComponent();
            Initializeprofile(loggedInUser);
            profilecontrol.BringToFront();
            InitializeMathPage(loggedInUser);
            InitializeShop(loggedInUser);
            InitializeHebPage(loggedInUser);
            InitializeEngPage(loggedInUser);
           



        }
        private void Initializeprofile(string loggedInUser)
        {
            
            if (profilecontrol == null)
            {
                profilecontrol = new profile();
                profilecontrol.Dock = DockStyle.Fill;
               
                this.Controls.Add(profilecontrol);
            }

           
            profilecontrol.LoggedInUser = loggedInUser;


        }
        private void InitializeEngPage(string loggedInUser)
        {
            
            if (engpagecontrol == null)
            {
                engpagecontrol = new Engpage();
                engpagecontrol.Dock = DockStyle.Fill;
                
                this.Controls.Add(engpagecontrol);
            }

            
            engpagecontrol.LoggedInUser = loggedInUser;


        }
        private void InitializeMathPage(string loggedInUser)
        {
            
            if (mathPageControl == null)
            {
                mathPageControl = new mathpage();
                mathPageControl.Dock = DockStyle.Fill;
                
                this.Controls.Add(mathPageControl);
            }

            
            mathPageControl.LoggedInUser = loggedInUser;


        }

        private void InitializeShop(string loggedInUser)
        {
            
            if (shopcontrol == null)
            {
                shopcontrol = new Test();
              
                shopcontrol.Dock = DockStyle.Fill;
                
                this.Controls.Add(shopcontrol);
            }

            // Set the LoggedInUser property
            shopcontrol.LoggedInUser = loggedInUser;
            shopcontrol.UpdatePointsLabel(loggedInUser);


        }

        private void InitializeHebPage(string loggedInUser)
        {
            
            if (hebPagecontrol == null)
            {
                hebPagecontrol = new HebPage();
                hebPagecontrol.Dock = DockStyle.Fill;
                 
                this.Controls.Add(hebPagecontrol);
            }

            
            hebPagecontrol.LoggedInUser = loggedInUser;


        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //shop click
        private void button4_Click(object sender, EventArgs e)
        {
            shopcontrol.UpdatePointsLabel(LoggedInUser);
            shopcontrol.BringToFront();
            sidepanel.Top = shopButton.Top;
            sidepanel.Height = shopButton.Height;   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            profilecontrol.UpdateWritingToolsLabel(LoggedInUser);
            profilecontrol.UpdateToysLabel(LoggedInUser);
            profilecontrol.UpdateBookLabel(LoggedInUser); 
            profilecontrol.UpdateStickersLabel(LoggedInUser);
            profilecontrol.UpdatePointsLabel(LoggedInUser);
            profilecontrol.BringToFront();
            sidepanel.Top= profileButton.Top;
            sidepanel.Height = profileButton.Height;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            engpagecontrol.BringToFront();
            sidepanel.Top = englishButton.Top;
            sidepanel.Height = englishButton.Height;    
        }

        private void hebrewButton_Click(object sender, EventArgs e)
        {
            hebPagecontrol.BringToFront();
            sidepanel.Top=hebrewButton.Top;
            sidepanel.Height = hebrewButton.Height; 
            
        }

        private void mathButton_Click(object sender, EventArgs e)
        {
            mathPageControl.BringToFront();
            sidepanel.Top = mathButton.Top;
            sidepanel.Height = mathButton.Height;
        }

        private void test21_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
