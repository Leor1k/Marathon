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
            kontaktGrid.Visibility = Visibility.Hidden;
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
            this.Close();
        }

        private void CloseKontatsBt_Click(object sender, RoutedEventArgs e)
        {
            kontaktGrid.Visibility = Visibility.Hidden;
        }

        private void ShowContacr_Click(object sender, RoutedEventArgs e)
        {
            kontaktGrid.Visibility = Visibility.Visible;
        }

        private void reg_on_marat_bt_Click(object sender, RoutedEventArgs e)
        {
            Grids.HideGrid(Register0for0an0event, matat_text, MainRunnerGrid);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
