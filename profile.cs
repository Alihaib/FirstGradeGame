using System;
using System.Drawing;
using System.Windows.Forms;
using SuppFuncs;

namespace WinFormsApp1
{
    public partial class profile : UserControl
    {
        public string LoggedInUser { get; set; }
        public profile()
        {
            InitializeComponent();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Simulate retrieving data from a database
            RetrieveUserData();

            // Set the TextChanged event for the name and password text boxes to a common handler
            textBoxUsername.TextChanged += TextBox_TextChanged;
            textBoxPassword.TextChanged += TextBox_TextChanged;
            Toysvalue.Text=SupportFunctions.ShowToys(LoggedInUser).ToString();
            pointsvalue.Text = SupportFunctions.ShowPoints(LoggedInUser).ToString();
            EmailValue.Text=SupportFunctions.Showemail(LoggedInUser);
            stickervalue.Text=SupportFunctions.ShowStickers(LoggedInUser).ToString();
            Bookvalue.Text=SupportFunctions.ShowColoringBook(LoggedInUser).ToString();
            WritingToolvalue.Text=SupportFunctions.ShowWritingTools(LoggedInUser).ToString();


        }


        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Cast the sender to a TextBox
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                // Handle text changes as needed
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            // Retrieve the new username and password from the text boxes
            string newUsername = textBoxUsername.Text;
            string newPassword = textBoxPassword.Text;

            try
            {
                // Update the user information in the Excel file
                SupportFunctions.SaveUserProfile(LoggedInUser, newUsername, newPassword);

                // Update the LoggedInUser to reflect the new username
                LoggedInUser = newUsername;

                // Notify the user that the update was successful
                MessageBox.Show("Username and password updated successfully!", "Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur during the save operation
                MessageBox.Show($"An error occurred while updating the profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void labelFavoriteGame_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
        public void UpdatePointsLabel(string username)
        {
            try
            {
                // Assuming PointsManager is the class with ShowPoints method
                // Adjust according to your class name

                // Retrieve points for the given username
                int points = SupportFunctions.ShowPoints(username);

                // Update the label's text
                pointsvalue.Text = $"{points}";
            }
            catch (Exception ex)
            {
                // Handle errors, e.g., user not found, file issues
                pointsvalue.Text = "Error: " + ex.Message;
            }
        }

        public void UpdateStickersLabel(string username)
        {
            try
            {
                
                int stickers = SupportFunctions.ShowStickers(username);

                
                stickervalue.Text = $"{stickers}";
            }
            catch (Exception ex)
            {
                
                stickervalue.Text = "Error: " + ex.Message;
            }
        }

        public void UpdateBookLabel(string username)
        {
            try
            {
                
                int Book = SupportFunctions.ShowColoringBook(username);

                
                Bookvalue.Text = $"{Book}";
            }
            catch (Exception ex)
            {
                
                Bookvalue.Text = "Error: " + ex.Message;
            }
        }

        public void UpdateToysLabel(string username)
        {
            try
            {
                
                int Toys = SupportFunctions.ShowToys(username);

                
                Toysvalue.Text = $"{Toys}";
            }
            catch (Exception ex)
            {
               
                pointsvalue.Text = "Error: " + ex.Message;
            }
        }

        public void UpdateWritingToolsLabel(string username)
        {
            try
            {
              
                int WritingToolsLabe = SupportFunctions.ShowWritingTools(username);

                
                WritingToolvalue.Text = $"{WritingToolsLabe}";
            }
            catch (Exception ex)
            {
               
                stickervalue.Text = "Error: " + ex.Message;
            }
        }
        private void RetrieveUserData()
       {
            
            var userInfo = GetUserInfo();

            // Update the UI with the retrieved data
            textBoxUsername.Text = userInfo.Username;
            textBoxPassword.Text = userInfo.Password;
            EmailValue.Text = userInfo.Email;
            ID2Value.Text = userInfo.Address;
            textBoxBirthday.Text = userInfo.Birthday;
            Gendervalue.Text = userInfo.Gender; 
            //textBoxGender.Text = userInfo.Gender;
            textBoxFavoriteGame.Text = userInfo.FavoriteGame;
            //textBoxCoins.Text = userInfo.Coins.ToString();
            //textBoxProductsBought.Text = userInfo.ProductsBought.ToString();
        }

        private UserInfo GetUserInfo()
        {
            // Load the user profile from Excel using the LoggedInUser as the key
            var userProfile = SupportFunctions.LoadUserProfile(LoggedInUser);

            // Check if the user profile was successfully retrieved
            if (userProfile.username != null)
            {
                // Return the user info retrieved from the Excel file
                return new UserInfo
                {
                    Username = userProfile.username,
                    Password = userProfile.password,
                    Email = userProfile.email,
                    Address = userProfile.address,
                    Birthday = "01/01/1990", // Replace with actual value if stored in Excel
                    Gender = userProfile.gender,
                    FavoriteGame = "Chess", // Replace with actual value if stored in Excel
                    Coins = userProfile.points, // Assuming points is equivalent to coins
                    ProductsBought = userProfile.stickers + userProfile.toysPack + userProfile.coloringBook + userProfile.writingTools
                };
            }
            else
            {
                MessageBox.Show("User profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }


    public class UserInfo
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string FavoriteGame { get; set; }
        public int Coins { get; set; }
        public int ProductsBought { get; set; }
    }
}
