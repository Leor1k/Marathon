using Microsoft.Win32;
using System.IO;
using System.Windows;
using OfficeOpenXml;
using System.Text;
using System;
using System.Security.Cryptography;

namespace FromExelToInser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Выберите Excel файл"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                FileInfo file = new FileInfo(filePath);

                using (ExcelPackage package = new ExcelPackage(file))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;
                    rowCount = 10;
                    string pathIsert = "INSERT INTO [dbo].[User] ([Email], [Password], [FirstName], [LastName], [RoleId]) VALUES ";
                    for (int row = 2; row <= rowCount; row++)
                    {               
                        for (int col = 1; col <= colCount; col++)
                        {   
                            //MessageBox.Show(worksheet.Cells[row, col].Value?.ToString() + "\t");
                            switch (col)
                            {
                                case 1:
                                    pathIsert += $"(N'{worksheet.Cells[row,col].Value?.ToString()}', ";
                                    break;
                                case 2:
                                    pathIsert += $"N'{HashPassword(worksheet.Cells[row, col].Value?.ToString())}', ";
                                    break;
                                case 3:
                                    pathIsert += $"N'{worksheet.Cells[row, col].Value?.ToString()}', ";
                                    break;
                                case 4:
                                    pathIsert += $"N'{worksheet.Cells[row, col].Value?.ToString()}', ";
                                    break;
                                case 5:
                                    if (row == rowCount)
                                    {
                                        pathIsert += $"N'{worksheet.Cells[row, col].Value?.ToString()}');\n";
                                    }
                                    else
                                    {
                                        pathIsert += $"N'{worksheet.Cells[row, col].Value?.ToString()}'),\n";
                                    }
                                    break;    
                            }                     
                        }                     
                    }
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string path = Path.Combine(desktopPath, "InsertUsers.sql");
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(pathIsert);
                        // Добавляем информацию в файл.
                        fs.Write(info, 0, info.Length);
                    }
                    MessageBox.Show("Файл успешно создан и находится на рабочем столе");
                }
            }
            else
            {
                MessageBox.Show("Нет");
            }
        }
        public static string HashPassword(string password)
        {
            byte[] salt = GenerateSalt();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltedPassword = new byte[salt.Length + passwordBytes.Length];
            Buffer.BlockCopy(salt, 0, saltedPassword, 0, salt.Length);
            Buffer.BlockCopy(passwordBytes, 0, saltedPassword, salt.Length, passwordBytes.Length);
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(saltedPassword);
                byte[] saltedHash = new byte[salt.Length + hash.Length];
                Buffer.BlockCopy(salt, 0, saltedHash, 0, salt.Length);
                Buffer.BlockCopy(hash, 0, saltedHash, salt.Length, hash.Length);
                return Convert.ToBase64String(saltedHash);
            }
        }

        private static byte[] GenerateSalt()
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }
    }
}
