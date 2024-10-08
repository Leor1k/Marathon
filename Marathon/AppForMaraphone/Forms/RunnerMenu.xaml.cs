using AppForMaraphone.Classes;
using AppForMaraphone.Resource;
using System;
using System.Collections.Generic;
using System.Windows;
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
        public RunnerMenu(User enteredUser)
        {

            InitializeComponent();    
            Grids.HideGrid(Ranner0menu, matat_text, MainRunnerGrid);
            kontaktGrid.Visibility = Visibility.Hidden;
            PreLoadCharity();         
        }
        private void PreLoadCharity ()
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
            sum += 145;
            SumInDollar.Text = (sum + rsum).ToString();
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            sum -= 145;
            SumInDollar.Text = (sum + rsum).ToString();
        }
        public event Action<int> ValueChanged;

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            sum += 75;
            SumInDollar.Text = (sum + rsum).ToString();
        }
        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        {
            sum -= 75;
            SumInDollar.Text = (sum + rsum).ToString();
        }

        private void CheckBox_Unchecked_2(object sender, RoutedEventArgs e)
        {
            sum -= 20;
            SumInDollar.Text = (sum + rsum).ToString(); ;
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            sum += 20;
            SumInDollar.Text = (sum + rsum).ToString();
        }

        private void complectA_Checked(object sender, RoutedEventArgs e)
        {
            rsum = 0;
            SumInDollar.Text = (sum + rsum).ToString();
        }

        private void complectA_Копировать_Checked(object sender, RoutedEventArgs e)
        {
            rsum = 20;
            SumInDollar.Text = (sum + rsum).ToString();
        }

        private void complectC_Checked(object sender, RoutedEventArgs e)
        {
            rsum = 45;
            SumInDollar.Text = (sum + rsum).ToString();
        }
    }
}
