using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using WinFormsApp1;

namespace SuppFuncs
{
    public class SupportFunctions
    {

        private static string excelFilePath = "C:\\Users\\HP\\OneDrive - ac.sce.ac.il\\שולחן העבודה\\db.xlsx";
        

        public static void AddPoints(string username, int pointsToAdd)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                FileInfo excelFile = new FileInfo(excelFilePath);
                if (!excelFile.Exists)
                {
                    throw new FileNotFoundException("Excel file not found.", excelFilePath);
                }

                using (ExcelPackage package = new ExcelPackage(excelFile))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                    if (worksheet == null)
                    {
                        throw new Exception("Worksheet 'Users' not found in Excel file.");
                    }

                    bool userFound = false;
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        string existingUsername = worksheet.Cells[row, 1].Text;

                        if (existingUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                        {
                            userFound = true;

                            // Get the current points
                            int currentPoints = worksheet.Cells[row, 6].GetValue<int>();

                            // Debug output
                            MessageBox.Show($"User: {username}, Current Points: {currentPoints}, Points to Add: {pointsToAdd}");

                            // Add the points
                            worksheet.Cells[row, 6].Value = currentPoints + pointsToAdd;


                            // Save changes
                            package.Save();

                            // Debug output
                            //MessageBox.Show($"Updated Points for {username}: {worksheet.Cells[row, 6].Value}");

                            break;
                        }
                    }

                    if (!userFound)
                    {
                        throw new Exception("User not found in the Excel file.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Print detailed exception information
                Console.WriteLine("Exception message: " + ex.Message);
                Console.WriteLine("Stack trace: " + ex.StackTrace);
                MessageBox.Show("An error occurred while adding points. See console for details.");
            }
        }


        public static void Additemshop(string username, int pointsTosub, int i)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                FileInfo excelFile = new FileInfo(excelFilePath);
                if (!excelFile.Exists)
                {
                    throw new FileNotFoundException("Excel file not found.", excelFilePath);
                }

                using (ExcelPackage package = new ExcelPackage(excelFile))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                    if (worksheet == null)
                    {
                        throw new Exception("Worksheet 'Users' not found in Excel file.");
                    }

                    bool userFound = false;
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        string existingUsername = worksheet.Cells[row, 1].Text;

                        if (existingUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                        {
                            userFound = true;

                            // Get the current points
                            int currentPoints = worksheet.Cells[row, 6].GetValue<int>();

                            if (currentPoints < pointsTosub)
                            {
                                MessageBox.Show("you dont have enough Points !!");
                            }
                            else
                            {
                                MessageBox.Show(" The item has been bought successfully!");

                                // Add the points
                                worksheet.Cells[row, 6].Value = currentPoints - pointsTosub;

                                worksheet.Cells[row, i].Value = worksheet.Cells[row, i].GetValue<int>() + 1;

                                // Save changes
                                package.Save();


                                break;
                            }
                        }
                    }

                    if (!userFound)
                    {
                        throw new Exception("User not found in the Excel file.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Print detailed exception information
                Console.WriteLine("Exception message: " + ex.Message);
                Console.WriteLine("Stack trace: " + ex.StackTrace);
                MessageBox.Show("An error occurred while adding points. See console for details.");
            }
        }

        public static int ShowPoints(string username)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            FileInfo excelFile = new FileInfo(excelFilePath);
            if (!excelFile.Exists)
            {
                throw new FileNotFoundException("Excel file not found.", excelFilePath);
            }

            int points = -1; // Default value if user is not found

            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                if (worksheet == null)
                {
                    throw new Exception("Worksheet 'Users' not found in Excel file.");
                }

                bool userFound = false;
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    string existingUsername = worksheet.Cells[row, 1].Text;

                    if (existingUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        userFound = true;


                        points = worksheet.Cells[row, 6].GetValue<int>();


                        break;
                    }
                }

                if (!userFound)
                {
                    throw new Exception($"User '{username}' not found in the worksheet.");
                }
            }

            return points;
        }
        public static (string password, string email, string gender, string address, string username, int points, int stickers, int toysPack, int coloringBook, int writingTools) LoadUserProfile(string username)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                FileInfo excelFile = new FileInfo(excelFilePath);
                if (!excelFile.Exists)
                {
                    throw new FileNotFoundException("Excel file not found.", excelFilePath);
                }

                using (ExcelPackage package = new ExcelPackage(excelFile))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                    if (worksheet == null)
                    {
                        throw new Exception("Worksheet 'Users' not found in Excel file.");
                    }

                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        string existingUsername = worksheet.Cells[row, 1].Text;

                        if (existingUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                        {
                            string password = worksheet.Cells[row, 2].Text;
                            string email = worksheet.Cells[row, 3].Text;
                            string gender = worksheet.Cells[row, 4].Text;
                            string address = worksheet.Cells[row, 5].Text;
                            int points = worksheet.Cells[row, 6].GetValue<int>();
                            int stickers = worksheet.Cells[row, 7].GetValue<int>();
                            int toysPack = worksheet.Cells[row, 8].GetValue<int>();
                            int coloringBook = worksheet.Cells[row, 9].GetValue<int>();
                            int writingTools = worksheet.Cells[row, 10].GetValue<int>();

                            return (password, email, gender, address, username, points, stickers, toysPack, coloringBook, writingTools);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the profile: {ex.Message}");
            }

            return (null, null, null, null, null, 0, 0, 0, 0, 0);
        }

        public static void SaveUserProfile(string oldUsername, string newUsername, string newPassword)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                FileInfo excelFile = new FileInfo(excelFilePath);
                if (!excelFile.Exists)
                {
                    throw new FileNotFoundException("Excel file not found.", excelFilePath);
                }

                using (ExcelPackage package = new ExcelPackage(excelFile))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                    if (worksheet == null)
                    {
                        throw new Exception("Worksheet 'Users' not found in Excel file.");
                    }

                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        string existingUsername = worksheet.Cells[row, 1].Text;

                        if (existingUsername.Equals(oldUsername, StringComparison.OrdinalIgnoreCase))
                        {
                            worksheet.Cells[row, 1].Value = newUsername;
                            worksheet.Cells[row, 2].Value = newPassword;
                            package.Save();
                            MessageBox.Show("Profile updated successfully!");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the profile: {ex.Message}");
            }
        }


        public static string Showemail(string username)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            FileInfo excelFile = new FileInfo(excelFilePath);
            if (!excelFile.Exists)
            {
                throw new FileNotFoundException("Excel file not found.", excelFilePath);
            }

            string mail = ""; // Default value if user is not found

            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                if (worksheet == null)
                {
                    throw new Exception("Worksheet 'Users' not found in Excel file.");
                }

                bool userFound = false;
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    string existingUsername = worksheet.Cells[row, 1].Text;

                    if (existingUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        userFound = true;


                        mail = worksheet.Cells[row, 3].GetValue<string>();


                        break;
                    }
                }

                if (!userFound)
                {
                    throw new Exception($"User '{username}' not found in the worksheet.");
                }
            }

            return mail;
        }

        public static int ShowStickers(string username)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            FileInfo excelFile = new FileInfo(excelFilePath);
            if (!excelFile.Exists)
            {
                throw new FileNotFoundException("Excel file not found.", excelFilePath);
            }

            int Sticker = -1;

            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                if (worksheet == null)
                {
                    throw new Exception("Worksheet 'Users' not found in Excel file.");
                }

                bool userFound = false;
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    string existingUsername = worksheet.Cells[row, 1].Text;

                    if (existingUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        userFound = true;
                        Sticker = worksheet.Cells[row, 7].GetValue<int>();
                        break;
                    }
                }

                if (!userFound)
                {
                    throw new Exception($"User '{username}' not found in the worksheet.");
                }
            }

            return Sticker;



        }
        public static int ShowColoringBook(string username)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            FileInfo excelFile = new FileInfo(excelFilePath);
            if (!excelFile.Exists)
            {
                throw new FileNotFoundException("Excel file not found.", excelFilePath);
            }

            int ColoringBook = -1;

            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                if (worksheet == null)
                {
                    throw new Exception("Worksheet 'Users' not found in Excel file.");
                }

                bool userFound = false;
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    string existingUsername = worksheet.Cells[row, 1].Text;

                    if (existingUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        userFound = true;
                        ColoringBook = worksheet.Cells[row, 9].GetValue<int>();
                        break;
                    }
                }

                if (!userFound)
                {
                    throw new Exception($"User '{username}' not found in the worksheet.");
                }
            }

            return ColoringBook;



        }


        public static int ShowToys(string username)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            FileInfo excelFile = new FileInfo(excelFilePath);
            if (!excelFile.Exists)
            {
                throw new FileNotFoundException("Excel file not found.", excelFilePath);
            }

            int Toys = -1;

            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                if (worksheet == null)
                {
                    throw new Exception("Worksheet 'Users' not found in Excel file.");
                }

                bool userFound = false;
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    string existingUsername = worksheet.Cells[row, 1].Text;

                    if (existingUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        userFound = true;
                        Toys = worksheet.Cells[row, 8].GetValue<int>();
                        break;
                    }
                }

                if (!userFound)
                {
                    throw new Exception($"User '{username}' not found in the worksheet.");
                }
            }

            return Toys;



        }

        public static int ShowWritingTools(string username)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            FileInfo excelFile = new FileInfo(excelFilePath);
            if (!excelFile.Exists)
            {
                throw new FileNotFoundException("Excel file not found.", excelFilePath);
            }

            int WritingTools = -1;

            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                if (worksheet == null)
                {
                    throw new Exception("Worksheet 'Users' not found in Excel file.");
                }

                bool userFound = false;
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    string existingUsername = worksheet.Cells[row, 1].Text;

                    if (existingUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        userFound = true;
                        WritingTools = worksheet.Cells[row, 8].GetValue<int>();
                        break;
                    }
                }

                if (!userFound)
                {
                    throw new Exception($"User '{username}' not found in the worksheet.");
                }
            }

            return WritingTools;



        }


        public static void SaveUser(string username, string password, string email, string gender, String id, int points)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                FileInfo excelFile = new FileInfo(excelFilePath);
                if (!excelFile.Exists)
                {
                    using (ExcelPackage package = new ExcelPackage(excelFile))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Users");
                        worksheet.Cells["A1"].Value = "Username";
                        worksheet.Cells["B1"].Value = "Password";
                        worksheet.Cells["C1"].Value = "Email";
                        worksheet.Cells["D1"].Value = "Gender";
                        worksheet.Cells["E1"].Value = "Id";
                        worksheet.Cells["F1"].Value = "Points";
                        worksheet.Cells["G1"].Value = "Stickers";
                        worksheet.Cells["H1"].Value = "Toys Pack";
                        worksheet.Cells["I1"].Value = "Coloring Book";
                        worksheet.Cells["J1"].Value = "Writing Tools";


                        package.Save();
                    }
                }

                using (ExcelPackage package = new ExcelPackage(excelFile))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                    if (worksheet == null)
                    {
                        throw new Exception("Worksheet 'Users' not found in Excel file.");
                    }

                    int row = worksheet.Dimension.Rows + 1;

                    worksheet.Cells[row, 1].Value = username;
                    worksheet.Cells[row, 2].Value = password;
                    worksheet.Cells[row, 3].Value = email;
                    worksheet.Cells[row, 4].Value = gender;
                    worksheet.Cells[row, 5].Value = id;
                    worksheet.Cells[row, 6].Value = points;
                    worksheet.Cells[row, 7].Value = 0;
                    worksheet.Cells[row, 8].Value = 0;
                    worksheet.Cells[row, 9].Value = 0;
                    worksheet.Cells[row, 10].Value = 0;



                    package.Save();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("An error occurred while saving to Excel.");
            }
        }
        public static bool CheckIfUserExists(string username)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                FileInfo excelFile = new FileInfo(excelFilePath);
                if (!excelFile.Exists)
                {
                    return false;
                }

                using (ExcelPackage package = new ExcelPackage(excelFile))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                    if (worksheet == null)
                    {
                        throw new Exception("Worksheet 'Users' not found in Excel file.");
                    }

                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        string existingUsername = worksheet.Cells[row, 1].Text;

                        if (existingUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("An error occurred while checking the Excel file.");
            }

            return false;
        }

        public static String checkRequierments(String username, String password, String ComPassword, String email, String id)
        {
            String message = "";
            if (SupportFunctions.CheckIfUserExists(username))
            {
                message += "- Username is used.\n";
            }

            string emailRequierment = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailRequierment))
            {
                message += "- invalid Email.\n";
            }

            if (ComPassword != password)
            {
                message += "- Password confirmation dose not match the password.\n";
            }


            int length = password.Length;
            if (length < 8 || length > 10)
            {
                message += "- Password must contain between 8 and 10 characters \n";
            }

            string passwordRequierment = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[!@$#%^&*])[A-Za-z\d!@$#%^&*]{8,10}$";

            if (!Regex.IsMatch(password, passwordRequierment))
            {
                message += "- Password must contain at least one special character, one digit, and the rest are english letters (!@$#%^&*)\n";
            }

            string usernameRequierment = @"^(?=[A-Za-z\d]{6,8}$)(?=[A-Za-z]*\d{0,2}[A-Za-z]*$)[A-Za-z]*\d?[A-Za-z]*\d?[A-Za-z]*$";

            if (!Regex.IsMatch(username, usernameRequierment))
            {
                message += "- Username must contain at most 2 digits and the rest letters and should be between 6 and 8.\n";
            }

            if (!int.TryParse(id, out _))
            {
                message += "- The ID must be only numbers.\n";
            }
            return message;
        }

        public static bool CheckLogInFields(string username, string password)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            bool found = false;

            try
            {
                FileInfo excelFile = new FileInfo(excelFilePath);
                if (!excelFile.Exists)
                {
                    throw new FileNotFoundException("Excel file not found.", excelFilePath);
                }

                using (ExcelPackage package = new ExcelPackage(excelFile))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                    if (worksheet == null)
                    {
                        throw new Exception("Worksheet 'Users' not found in Excel file.");
                    }

                    int rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        string storedUsername = worksheet.Cells[row, 1].Value?.ToString();
                        string storedPassword = worksheet.Cells[row, 2].Value?.ToString();

                        if (storedUsername.ToLower() == username.ToLower() && storedPassword.ToLower() == password.ToLower())
                        {
                            found = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("An error occurred while searching in Excel.");
            }

            return found;
        }



       


    }


}
