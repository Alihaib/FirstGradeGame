using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using System.Reflection.Emit;
using SuppFuncs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Test : UserControl
    {
        private static string excelFilePath = "C:\\Users\\HP\\OneDrive - ac.sce.ac.il\\שולחן העבודה\\db.xlsx";
        public string LoggedInUser { get; set; }

        public Test()
        {
       
            InitializeComponent();
            UpdatePointsLabel(LoggedInUser);

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            if (!File.Exists(excelFilePath))
            {
                Console.WriteLine("The file does not exist.");
                return;
            }
            using (ExcelPackage package = new ExcelPackage(new FileInfo(excelFilePath)))
            {
                // Get the first worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                SuppFuncs.SupportFunctions.Additemshop(LoggedInUser, 10, 7);
            }
            UpdatePointsLabel(LoggedInUser);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            if (!File.Exists(excelFilePath))
            {
                Console.WriteLine("The file does not exist.");
                return;
            }
            using (ExcelPackage package = new ExcelPackage(new FileInfo(excelFilePath)))
            {
                // Get the first worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                SuppFuncs.SupportFunctions.Additemshop(LoggedInUser,50, 8);
            }
            UpdatePointsLabel(LoggedInUser);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            if (!File.Exists(excelFilePath))
            {
                Console.WriteLine("The file does not exist.");
                return;
            }
            using (ExcelPackage package = new ExcelPackage(new FileInfo(excelFilePath)))
            {
                // Get the first worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                SuppFuncs.SupportFunctions.Additemshop(LoggedInUser, 15, 9);
            }
            UpdatePointsLabel(LoggedInUser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            if (!File.Exists(excelFilePath))
            {
                Console.WriteLine("The file does not exist.");
                return;
            }
            using (ExcelPackage package = new ExcelPackage(new FileInfo(excelFilePath)))
            {
                // Get the first worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];
                SuppFuncs.SupportFunctions.Additemshop(LoggedInUser, 30, 10);
                
            }
            UpdatePointsLabel(LoggedInUser);
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        public  void UpdatePointsLabel(string username)
        {
            try
            {
                // Assuming PointsManager is the class with ShowPoints method
                 // Adjust according to your class name

                // Retrieve points for the given username
                int points = SupportFunctions.ShowPoints(username);

                // Update the label's text
                label9.Text = $"Points: {points}";
            }
            catch (Exception ex)
            {
                // Handle errors, e.g., user not found, file issues
                label9.Text = "Error: " + ex.Message;
            }
        }

        // Example method to simulate button click to update points
    

        private void Test_Load(object sender, EventArgs e)
        {
            string username = LoggedInUser;
            UpdatePointsLabel(username);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string username = LoggedInUser;
            UpdatePointsLabel(username);
        }
    }
}
