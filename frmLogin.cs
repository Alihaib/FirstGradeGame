using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using SuppFuncs;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class frmLogin : Form
    {


        public frmLogin()
        {
            InitializeComponent();
            _=txtUsername.Focus();

        }

        private void loginclick(object sender, EventArgs e)
        {

            if (SupportFunctions.CheckLogInFields(txtUsername.Text, txtPassword.Text))
            {
                this.Hide();

                // Pass the logged-in username to Form2
                Form2 mainForm = new Form2(txtUsername.Text)
                {
                    LoggedInUser = txtUsername.Text
                };

                // Show Form2
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("One of the log in fields is wrong", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
       
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 rig=new Form1();
            rig.ShowDialog();
            this.Close();
     
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text="";  
            txtUsername.Focus();    
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
