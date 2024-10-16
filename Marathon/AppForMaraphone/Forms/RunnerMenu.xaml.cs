using AppForMaraphone.Classes;
using AppForMaraphone.Resource;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AppForMaraphone.Forms
{
    /// <summary>
    /// Логика взаимодействия для RunnerMenu.xaml
    /// </summary>
    public partial class RunnerMenu : Window
    {
        private List<Charity> lists = DataBase.GetCharity();
        private int sum;
        private int rsum;
        private int vsnos;
        //private User enterUser;
        private Runner enteredRunner;
        private int selKit;
        public RunnerMenu(Runner er)
        {
            InitializeComponent();
            enteredRunner = er;
            Grids.HideGrid(Ranner0menu, matat_text, MainRunnerGrid);
            kontaktGrid.Visibility = Visibility.Hidden;
            PreLoadCharity();
            PreLoadCountry();
            complectA.IsChecked = true;
            char_sum_tb.Text = "0";
        }
        private void PreLoadCountry()
        {
            List<Country> www = new List<Country>();
            www = DataBase.GetCountryList();
            foreach (Country item in www)
            {
                change_country.Items.Add(item.Name);
            }
            Change_Name.Text = enteredRunner.FirstName;
            Change_LastName.Text = enteredRunner.LastName;
            if (enteredRunner.Gender == "Мужчина")
            {
                change_gender.SelectedIndex = 1;
            }
            else
            {
                change_gender.SelectedIndex = 2;
            }
            change_date.Text = enteredRunner.DateBirth.ToString("dd.MM.yyyy");
            change_country.SelectedItem = enteredRunner.CountryData.Name;
            showEmail.Text = enteredRunner.Email;
        }
        private void PreLoadCharity()
        {
            foreach (Charity charity in lists)
            {
                ComboboxPart cb = new ComboboxPart(charity);
                selectedCharity_cb.Items.Add(cb);
            }
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
        private void selectedCharity_cb_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            moreInfoAboutCharity_bt.IsEnabled = true;
        }
        private void moreInfoAboutCharity_bt_Click(object sender, RoutedEventArgs e)
        {
            MoreInfoGrid.Visibility = Visibility.Visible;
            ComboboxPart asas = selectedCharity_cb.SelectedItem as ComboboxPart;
            foreach (Charity c in lists)
            {
                if (asas.Header == c.CharityName)
                {
                    name_mi_tv.Text = c.CharityName;
                    des_mi.Text = c.Description;
                    image_mi_im.Source = new BitmapImage(new Uri($"/Resource/Images/LogoCharity/{c.PictureName}.png", UriKind.Relative));
                }
            }
        }
        private void closeMoreInfo_bt_Click(object sender, RoutedEventArgs e)
        {
            MoreInfoGrid.Visibility = Visibility.Hidden;
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CountPrice(145);
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CountPrice(-145);
        }
        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            CountPrice(75);
        }
        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        {
            CountPrice(-75);
        }
        private void CheckBox_Unchecked_2(object sender, RoutedEventArgs e)
        {
            CountPrice(-20);
        }
        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            CountPrice(20);
        }
        private void complectA_Checked(object sender, RoutedEventArgs e)
        {
            rsum = 0;
            selKit = 1;
            CountPrice(0);
        }
        private void complectA_Копировать_Checked(object sender, RoutedEventArgs e)
        {
            rsum = 20;
            selKit = 2;
            CountPrice(0);
        }
        private void complectC_Checked(object sender, RoutedEventArgs e)
        {
            rsum = 45;
            selKit = 3;
            CountPrice(0);
        }
        private void CountPrice(int number)
        {
            sum += number;
            SumInDollar.Text = (sum + rsum + vsnos).ToString();
        }
        private void char_sum_tb_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
                return;
            }
        }
        private void char_sum_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                vsnos = Convert.ToInt32(char_sum_tb.Text);
                CountPrice(0);
            }
            catch { }
            if (char_sum_tb.Text.Length == 0)
            {
                char_sum_tb.Text = "0";
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CheckRegOnMarat();
                Charity charity = null;
                foreach (Charity item in lists)
                {
                    ComboboxPart asas = selectedCharity_cb.SelectedItem as ComboboxPart;
                    if (item.CharityName == asas.Header)
                    {
                        charity = item;
                    }
                }
                Registration newReg = new Registration
                    (
                        DataBase.GetIdByEmail(enteredRunner.Email),
                        DateTime.Now, selKit, (sum + rsum + vsnos), charity
                    );
                DataBase.CreateRegistration(newReg);
                Grids.HideGrid(Registration0confirmation, matat_text, MainRunnerGrid);
            }
            catch (Exception ex)
            {
                error_out.Text = ex.Message;
            }
        }
        private void CheckRegOnMarat()
        {
            if (!(km21.IsChecked == true || km42.IsChecked == true || km5.IsChecked == true))
            {
                throw new Exception("Для регестрации, необходимо выбрать хотя бы один вид марафона");
            }
            else if (selectedCharity_cb.SelectedItem == null)
            {
                throw new Exception("Для регестрации, необходимо выбрать благотворительную организацию");
            }
            else if (char_sum_tb.Text == string.Empty || (Convert.ToInt32(char_sum_tb.Text) == 0))
            {
                throw new Exception("Для регестрации, необходая сумма взноса минимум $1");
            }
            else
            {
                string checkedrd = string.Empty;
                if (rsum == 0)
                {
                    checkedrd = "Вариант А ($0): Номер бегуна + RFID браслет";
                }
                else if (rsum == 20)
                {
                    checkedrd = "Вариант В ($20): Вариант А + бейсболка + бутылка воды";
                }
                else
                {
                    checkedrd = "Вариант С ($45): Вариант B + футболка + сувенирный буклет";
                }
                string shure = "Вы уверенны что хотите зарегестрироваться на следующий/е марафоны:\n";
                if (km42.IsChecked == true)
                {
                    shure += km42.Content + ";\n";
                }
                if (km21.IsChecked == true)
                {
                    shure += km21.Content + ";\n";
                }
                if (km5.IsChecked == true)
                {
                    shure += km5.Content + ";\n";
                }
                shure += $"С выбранным набором: {checkedrd}\n";
                shure += $"где ваш взнос в размере {SumInDollar.Text}$ будет направлен в организацию {(selectedCharity_cb.SelectedItem as ComboboxPart).Header}?";
                if (MessageBoxResult.Yes == MessageBox.Show(shure, "Подтвердить", MessageBoxButton.YesNo, MessageBoxImage.Question))
                {
                    MessageBox.Show("yes");
                }
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Grids.HideGrid(Ranner0menu, matat_text, MainRunnerGrid);
        }
        private void regis_bt_Копировать2_Click(object sender, RoutedEventArgs e)
        {
            Grids.HideGrid(Edit0runner0profile, matat_text, MainRunnerGrid);
        }
        private void CheckEditMoments()
        {
            if (Change_Name.Text == string.Empty)
            {
                throw new Exception("Поле имя обязательно к заполнению");
            }
            if (Change_LastName.Text == string.Empty)
            {
                throw new Exception("Поле фамилия обязательно к заполнению");
            }
            if (change_date.Text == string.Empty)
            {
                throw new Exception("Поле дата рождения обязательно к заполнению");
            }
            if (change_password.Text != string.Empty)
            {
                if (change_password_second.Text == string.Empty)
                {
                    throw new Exception("Если вы хотите поменять пароль, необходимо заполнить оба поля ввода пароля");
                }
            }
        }
        private void canel_bt_Click(object sender, RoutedEventArgs e)
        {
            Grids.HideGrid(Ranner0menu, matat_text, MainRunnerGrid);
        }
        private void save_changes_bt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CheckEditMoments();

            }
            catch (Exception ex)
            {
                error.Text = ex.Message;
            }
        }
        private void Change_Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (enteredRunner != null)
            {
                if (enteredRunner.FirstName != Change_Name.Text)
                {
                    Change_Name.Background = Brushes.AliceBlue;
                }
                else
                {
                    Change_Name.Background = Brushes.White;
                }
            }   
        }

        private void Change_LastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (enteredRunner != null)
            {
                if (enteredRunner.LastName != Change_LastName.Text)
                {
                    Change_LastName.Background = Brushes.AliceBlue;
                }
                else
                {
                    Change_LastName.Background = Brushes.White;
                }
            }
        }
    }
}
