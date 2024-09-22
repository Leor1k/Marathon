using AppForMaraphone.Classes;
using System;
using System.Windows;
using System.Windows.Controls;


namespace AppForMaraphone
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HideGrid(first_grid);
        }
        private void exit_bt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void HideGrid(Grid selectedGrid)
        {
            foreach (var grid in AllIn.Children)
            {
                if (grid.GetType() == typeof(Grid))
                {
                    Grid grid1 = grid as Grid;
                    grid1.Visibility = Visibility.Hidden;
                }
            }
            selectedGrid.Visibility = Visibility.Visible;
            if(selectedGrid.Name =="first_grid")
            {
                matat_text.Text = "";
            }
            else
            {
                matat_text.Text = selectedGrid.Name.Replace('0',' ');
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HideGrid(first_grid);       
        }
        private void be_runner_bt_Click(object sender, RoutedEventArgs e)
        {
            HideGrid(Register0as0a0runner);
        }
        private void old_runner_Click(object sender, RoutedEventArgs e)
        {
            HideGrid(Login);
        }
        private void check_pass_Checked(object sender, RoutedEventArgs e)
        {
            pass_pb.Visibility = Visibility.Hidden;
            pass_tv.Visibility = Visibility.Visible;
            pass_tv.Text = pass_pb.Password;
        }
        private void check_pass_Unchecked(object sender, RoutedEventArgs e)
        {
            pass_tv.Visibility = Visibility.Hidden;
            pass_pb.Visibility = Visibility.Visible;
            pass_pb.Password = pass_tv.Text;
        }
        private void log_bt_Click(object sender, RoutedEventArgs e)
        {
            HideGrid(Login);
        }
        private void regis_bt_Click(object sender, RoutedEventArgs e)
        {
            HideGrid(Register0as0a0runner0);
        }
        private void login_bt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(email_tv.Text.Length == 0)
                {
                    throw new Exception("Поле Email обязательно к заполнению");
                }
                string pass = null;
                if (check_pass.IsChecked == true)
                {
                    if (pass_tv.Text.Length == 0)
                    {
                        throw new Exception("Поле пароль обязательно к заполнению");
                    }
                    pass = pass_tv.Text.Trim();
                }
                else
                {
                    if (pass_pb.Password.Length == 0)
                    {
                        throw new Exception("Поле пароль обязательно к заполнению");
                    }
                    pass = pass_pb.Password.Trim();
                }
                User enteredUser = DataBase.UserEnter(email_tv.Text.Trim(), pass); 
                if (enteredUser == null)
                {
                    throw new Exception("Неверный логин или пароль.");
                }
                MessageBox.Show($"Vse good");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}"); 
            }
        }
    }
}
