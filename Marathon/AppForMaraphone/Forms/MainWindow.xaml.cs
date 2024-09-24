using AppForMaraphone.Classes;
using AppForMaraphone.Forms;
using AppForMaraphone.Resource;
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
            Grids.HideGrid(first_grid, matat_text, AllIn);
            AddClick();
        }
        private void exit_bt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grids.HideGrid(first_grid, matat_text, AllIn);
        }
        private void be_runner_bt_Click(object sender, RoutedEventArgs e)
        {
            Grids.HideGrid(Register0as0a0runner, matat_text, AllIn);
        }
        private void old_runner_Click(object sender, RoutedEventArgs e)
        {
            Grids.HideGrid(Login, matat_text, AllIn);
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
            Grids.HideGrid(Login, matat_text, AllIn);
        }
        private void regis_bt_Click(object sender, RoutedEventArgs e)
        {
            Grids.HideGrid(Register0as0a0runner0, matat_text, AllIn);
        }
        private void login_bt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (email_tv.Text.Length == 0)
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
                if (enteredUser.RoleId == 'R')
                {
                    RunnerMenu yeap = new RunnerMenu(enteredUser);
                    yeap.Show();
                    this.Close();       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}"); 
            }
        }

        private void more_info_button_Click(object sender, RoutedEventArgs e)
        {
            Grids.HideGrid(Find0out0more0information, matat_text, AllIn);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void longs_bt_Click(object sender, RoutedEventArgs e)
        {
            Grids.HideGrid(How0long0is0marathon,matat_text,AllIn);
        }
        private void AddClick()
        {
            foreach (var item in SpeedTest.Children)
            {
                if (typeof(ImagesItem) == item.GetType())
                {
                    ImagesItem images = (ImagesItem)item;
                    images.selectItem.Click += SelectItem_Click;
                }
            }
        }

        private void SelectItem_Click(object sender, RoutedEventArgs e)
        {
            Button s = (Button)sender;
            Canvas s1 = (Canvas)s.Parent;

           foreach (var item in s1.Children )
            {
                if (typeof(Image) == item.GetType())
                {
                    Image image = (Image)item;
                    selected_poin_photo = image;                 
                }
            }
        }
    }
}
