using AppForMaraphone.Classes;
using System.Windows;

namespace AppForMaraphone.Forms
{
    /// <summary>
    /// Логика взаимодействия для RunnerMenu.xaml
    /// </summary>
    public partial class RunnerMenu : Window
    {
        public RunnerMenu(User enteredUser)
        {
            InitializeComponent();
            Grids.HideGrid(Ranner0menu, matat_text, MainRunnerGrid);
        }

        private void back_to_first_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void exit_bt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void logOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
