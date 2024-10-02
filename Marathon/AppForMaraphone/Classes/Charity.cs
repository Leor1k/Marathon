using System;
using System.Windows.Media.Imaging;

namespace AppForMaraphone.Classes
{
    public class Charity
    {
        public string CharityName { get; } = null;
        public string Description { get; } = null;
        public BitmapImage Image { get; } = null;
        public Charity(string name, string discription, string imageName) 
        {
            CharityName = name;
            Description = discription;
            BitmapImage sss = new BitmapImage(
            new Uri($"pack://application:,,,/AppForMaraphone;component/Resources/Images/LogoCharity/arise-logo.png"));
            Image = sss;
        }
    }
}
