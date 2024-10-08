using AppForMaraphone.Classes;
using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace AppForMaraphone.Resource
{
    /// <summary>
    /// Логика взаимодействия для ComboboxPart.xaml
    /// </summary>
    public partial class ComboboxPart : UserControl
    {
        public string Header { get; set; }

        public ComboboxPart(Charity charonchik)
        {
            InitializeComponent();
            Logos.Source = new BitmapImage(new Uri($"/Resource/Images/LogoCharity/{charonchik.PictureName}.png", UriKind.Relative));
            NameChar.Text = charonchik.CharityName;
            Header = NameChar.Text;
        }
    }
}
