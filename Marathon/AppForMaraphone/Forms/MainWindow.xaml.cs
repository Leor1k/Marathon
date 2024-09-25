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
            SelectDescription(point_name.Text);
            DistanseStack.Visibility = Visibility.Hidden;
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
            foreach (var item in DistanseStack.Children)
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
            Grid s2= (Grid)s1.Parent;
            ImagesItem s3 = (ImagesItem)s2.Parent;
            selected_poin_photo.Source = s3.ImageSRS.Source;
            point_name.Text = s3.TextSourse.Text;
            SelectDescription(point_name.Text);
        }
        private void SelectDescription(string SelectedPoint)
        {
            switch (SelectedPoint)
            {
                case "F1 Car":
                    ShowDescription(345);
                    break;
                case "Slug":
                    ShowDescription(0.01);
                    break;
                case "Horse":
                    ShowDescription(15);
                    break;
                case "Sloth":
                    ShowDescription(0.12);
                    break;
                case "Capybara":
                    ShowDescription(35);
                    break;
                case "Jaguar":
                    ShowDescription(80);
                    break;
                case "Worm":
                    ShowDescription(0.03);
                    break;
                case "Bus":
                    ShowCount(10);
                    break;
                case "Pair of Havaianas":
                    ShowCount(0.245);
                    break;
                case "Airbus A380":
                    ShowCount(73);
                    break;
                case "Football Field":
                    ShowCount(105);
                    break;
                case "Ronaldinho":
                    ShowCount(1.81);
                    break;
            }
        }
        private void ShowDescription( double BBB)
        {
            if (SpeedTest.IsEnabled)
            {
                double min;
                int hour=0;
                min = (42/BBB)*60;
                min = Math.Round(min, 1);
                while (min >=60)
                {
                    min -=60;
                    hour++;
                }
                if (hour !=0)
                {
                    discriotion.Text = $"Максимальная скорость {point_name.Text} {BBB}km/h. Это займет {hour} ч. {min} мин. чтобы завершить 42-х километровый  марафон";
                }
                else 
                {
                    discriotion.Text = $"Максимальная скорость {point_name.Text} {BBB}km/h. Это займет {min} мин. чтобы завершить 42-х километровый  марафон";
                }

            }
        }
        private void ShowCount(double BBB)
        {
            int count = Convert.ToInt32(42000/BBB);
            discriotion.Text = $"Длина {point_name.Text} {BBB}м. Это займет {count} из них, чтобы покрыть расстояние в 42 км марафона";
        }
        private void showSpeed_Click(object sender, RoutedEventArgs e)
        {
            SpeedTest.Visibility = Visibility.Visible;
            DistanseStack.Visibility = Visibility.Hidden;
        }

        private void DistanseBt_Click(object sender, RoutedEventArgs e)
        {
            DistanseStack.Visibility = Visibility.Visible;
            SpeedTest.Visibility = Visibility.Hidden;
        }

        private void show_map_Click(object sender, RoutedEventArgs e)
        {
            Grids.HideGrid(Find0out0more0information0, matat_text, AllIn);
        }
        private void ImageClick_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Йоу");
        }
    }
}
