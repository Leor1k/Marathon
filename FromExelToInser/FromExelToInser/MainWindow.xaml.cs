using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            OpenFileDialog exelFile = new OpenFileDialog();
            exelFile.InitialDirectory = @"C:\";
            exelFile.DefaultExt = "xlsx";
            exelFile.Filter = "xlsx";
            if (exelFile.ShowDialog() == true )
            {
                var ElelFile = new FileInfo(exelFile.FileName);
                MessageBox.Show($"")
            }
        }
    }
}
