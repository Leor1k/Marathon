using AppForMaraphone.Classes;
using AppForMaraphone.Forms;
using AppForMaraphone.Resource;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace AppForMaraphone
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Country> list;
        private List<Runner> runnerList;
        private List<DonateData> donateDatas;
        private List<Charity> charities;
        int btsim = 0;
        public MainWindow()
        {
            InitializeComponent();
            Grids.HideGrid(first_grid, matat_text, AllIn);
            AddClick();
            SelectDescription(point_name.Text);
            DistanseStack.Visibility = Visibility.Hidden;
            loadCountry();
            LoadCharity();
        }
        private void LoadCharity ()
        {
            charities = DataBase.GetCharity();
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
            error_out.Text = "";
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
                    Runner er = DataBase.RunnerEnter(enteredUser);
                    RunnerMenu yeap = new RunnerMenu(er);
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
        private void Registration_bt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CheckReg();
                Runner runner = new Runner(
                    Email_tb.Text,
                    Password_tb.Text,
                    Name_tb.Text,
                    LastName.Text,
                    'R',
                    Gender_cb.Text,
                    Convert.ToDateTime(Date_birth.Text),
                    getCountryByName(Country_cb.Text)
                    );
                DataBase.InsertNewRunner(runner);
                RunnerMenu alp = new RunnerMenu(runner);
                this.Close();
                alp.Show();
            }
            catch (Exception ex)
            {
                error_out.Text = $"Ошибка: {ex.Message}"; 
            }
        }
        public Country getCountryByName(string countryName)
        {
            foreach(Country c in list)
            {
                if (c.Name == countryName)
                {
                    return c;
                }
            }
            return null;
        }
        public void CheckReg()
        {
            if (!CheksProgam.CheckEmail(Email_tb.Text))
            {
                throw new Exception("Неверный формат электронной почты");
            }
            CheksProgam.CheckPass(Password_tb.Text, repeat_password_tb.Text);  
            if(Name_tb.Text.Length == 0)
            {
                throw new Exception("Поле 'Имя' обязательно к заполнению");
            }
            if (LastName.Text.Length == 0)
            {
                throw new Exception("Поле 'Фамилия' обязательно к заполнению");
            }

            CheksProgam.CheckDate(Date_birth.Text);
            if (string.IsNullOrEmpty(Gender_cb.Text))
            {
                throw new Exception("Поле 'Пол' обязательно к заполнению");
            }
            if (string.IsNullOrEmpty(Country_cb.Text))
            {
                throw new Exception("Поле 'Страна' обязательно к заполнению");
            }
        }      
        private void Date_birth_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            TextBox textBox = (TextBox)sender;  
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
                return;
            }
            if (textBox.Text.Length == 2 || textBox.Text.Length == 5)
            {
                textBox.Text += ".";
                textBox.CaretIndex = textBox.Text.Length;
            }
        }
        private void loadCountry ()
        {
            list = DataBase.GetCountryList();
            foreach (Country co in list)
            {
                Country_cb.Items.Add(co.Name);
            }
        }
        private void IwontDonate_Click(object sender, RoutedEventArgs e)
        {
            Grids.HideGrid(Sponsor0a0runner, matat_text, AllIn);
            GetRunnerList();
            more_info_grid.Visibility = Visibility.Hidden;
            s_srok2_tb_Копировать.Text = "0";
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Grids.HideGrid(first_grid, matat_text, AllIn);
        }
        private void GetRunnerList ()
        {
            s_runner_tb. Items.Clear();
            donateDatas = DataBase.GetDonateList();
            foreach (DonateData donItem in donateDatas)
            {
                s_runner_tb.Items.Add(donItem.GetStringDate());
                s_runner_tb.SelectedItem = donItem.GetStringDate();
            }
        }
        private void s_numberCard_tb_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
                return;
            }
            if (textBox.Text.Length == 4 || textBox.Text.Length == 9 || textBox.Text.Length == 14)
            {
                textBox.Text += " ";
                textBox.CaretIndex = textBox.Text.Length;
            }
        }
        private void s_srok1_tb_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
                return;
            }
        }
        private void s_runner_tb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = 0;
            string[] si = s_runner_tb.Text.Split(new char[] {' '});
            foreach (DonateData dd in donateDatas)
            {
                if (dd.FirstNameRunner == si[0] && dd.LastNameRunner == si[1])
                {
                    i = dd.CharityCode;
                }
            }
            foreach (Charity ch in charities)
            {
                if (i == ch.CharId)
                {
                    s_selectedFond.Text = ch.CharityName;
                    s_slectedchar.Text = s_selectedFond.Text;
                    discriotion1.Text = ch.Description;
                    selected_char_image.Source = new BitmapImage(new Uri($"/Resource/Images/LogoCharity/{ch.PictureName}.png", UriKind.Relative));
                }
            }
            
        }

        private void more_info_bt_Click(object sender, RoutedEventArgs e)
        {
            more_info_grid.Visibility = Visibility.Visible;
        }

        private void exit_moreinfo_Click(object sender, RoutedEventArgs e)
        {
            more_info_grid.Visibility = Visibility.Hidden;
        }
        private void s_srok2_tb_Копировать_TextChanged(object sender, TextChangedEventArgs e)
        {
            countDonate();
        }

        private void addten_Click(object sender, RoutedEventArgs e)
        {
            btsim += 10;
            countDonate();
        }

        private void minesten_Click(object sender, RoutedEventArgs e)
        {
            if ((Convert.ToInt32(s_srok2_tb_Копировать.Text) + btsim) - 10 >= 0)
            {
                btsim -= 10;
            }
            countDonate();
        }
        private void  countDonate()
        {
            try
            {
                fullPrice.Text = (Convert.ToInt32(s_srok2_tb_Копировать.Text) + btsim).ToString();
            }
            catch
            {

            }
        }

    }
}
