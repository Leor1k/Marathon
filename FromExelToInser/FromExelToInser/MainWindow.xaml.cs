using Microsoft.Win32;
using System.IO;
using System.Windows;
using OfficeOpenXml;
using System.Text;
using System;

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
                                    pathIsert += $"N'{worksheet.Cells[row, col].Value?.ToString()}', ";
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
    }
}
