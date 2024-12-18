﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SuppFuncs;
using OfficeOpenXml;



namespace WinFormsApp1
{
    public class Excel
    {
        private static string excelFilePath = "C:\\Users\\HP\\OneDrive - ac.sce.ac.il\\שולחן העבודה\\db.xlsx";

        public static void SaveToExcel(string username, string password, string email, string gender, String id, double points)
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
                        worksheet.Cells["A1"].Value = "Name";
                        worksheet.Cells["B1"].Value = "Password";
                        worksheet.Cells["C1"].Value = "Email";
                        worksheet.Cells["D1"].Value = "Gender";
                        worksheet.Cells["E1"].Value = "Id";
                        worksheet.Cells["F1"].Value = "Points";

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

        public static String checkValidity(String username, String password, String email, String id)
        {
            String message = "";
            if (SupportFunctions.CheckIfUserExists(username))
            {
                message += "- Username is already used.\n";
            }

            string usernamePattern = @"^(?=[A-Za-z\d]{6,8}$)(?=[A-Za-z]*\d{0,2}[A-Za-z]*$)[A-Za-z]*\d?[A-Za-z]*\d?[A-Za-z]*$";

            if (!Regex.IsMatch(username, usernamePattern))
            {
                message += "- Username must contain at most 2 digits and the rest letters and should be between 6 and 8.\n";
            }


            int length = password.Length;
            if (length < 8 || length > 10)
            {
                message += "- Password must be between 8 and 10 characters long\n";
            }

            string passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[!@$#%^&*])[A-Za-z\d!@$#%^&*]{8,10}$";

            if (!Regex.IsMatch(password, passwordPattern))
            {
                message += "- Password must contain at least one letter, one digit, and one special character (!@$#%^&*)\n";
            }
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                message += "- Email is invalid.\n";
            }


            if (!int.TryParse(id, out _))
            {
                message += "- The ID must be only numbers.\n";
            }
            return message;
        }

        public static bool SearchInExcel(string username, string password)
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

        public static void SaveLoginState(string username, bool isLoggedIn)
        {
            string path = @"entranceState.txt";
            File.WriteAllText(path, $"{username},{isLoggedIn}");
        }

        public static bool IsUserLoggedIn()
        {
            string path = @"entranceState.txt";
            if (File.Exists(path))
            {
                string[] loginState = File.ReadAllText(path).Split(',');
                if (loginState.Length == 2 && bool.Parse(loginState[1]))
                {
                    return true;
                }
            }
            return false;
        }

        public static void ClearLoginState()
        {
            string path = @"entranceState.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
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
    }
}
