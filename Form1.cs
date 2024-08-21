using SuppFuncs;
using System;
using System.IO;
using System.Windows.Forms;
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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
   
        public Form1()
        {
            InitializeComponent();
            

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //clear button
        private void clear(object sender, EventArgs e)
        {
            String v = "";
            txtUsername.Text = v;
            txtEmail.Text = v;
            txtID.Text = v;
            txtUsername.Focus();
        }

        //show password button
        private void show(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private string GetSelectedGender()
        {
            if(MaleButton.Checked)
            {
                return MaleButton.Text;
            }
            if (FemaleButton.Checked)
            {
                return FemaleButton.Text;
            }
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SupportFunctions.checkRequierments(txtUsername.Text, txtPassword.Text, txtComPassword.Text, txtEmail.Text, txtID.Text) == ""&& !(SupportFunctions.CheckIfUserExists(txtUsername.Text))) { SupportFunctions.SaveUser(txtUsername.Text, txtPassword.Text, txtEmail.Text,GetSelectedGender(), txtID.Text,0);
                MessageBox.Show("Rigesteration Completed !", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show(SupportFunctions.checkRequierments(txtUsername.Text, txtPassword.Text, txtComPassword.Text, txtEmail.Text, txtID.Text), "rigesteration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    


        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }


        //show password checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!(checkBox1.Checked))
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }

        }

        private void txtComPassword_TextChanged(object sender, EventArgs e)
        {
        }

        //back to login
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();   

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //exit button
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            txtComPassword.PasswordChar = '*';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Mailinvalid_Click(object sender, EventArgs e)
        {

        }

        private void Idinvalid_Click(object sender, EventArgs e)
        {

        }

        private void passwordinvalid_Click(object sender, EventArgs e)
        {

        }

        private void cpasswordinvalid_Click(object sender, EventArgs e)
        {

        }

        private void userValid_Click(object sender, EventArgs e)
        {

        }

        private void mailValid_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}